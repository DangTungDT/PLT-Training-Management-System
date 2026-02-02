using BLL;
using DTO;
using GUI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Helpers;

namespace GUI.UserControls.Schedule
{

    public partial class UcSchedule : UserControl
    {
        List<Label> _labelsNameCourse;
        List<Label> _labelsClass;
        List<Label> _labelsTime;
        List<Label> _labelsRoom;
        private readonly LessonPlanBLL _lessonPlanBLL = new LessonPlanBLL();
        private List<LessonPlanDTO> _LessonPlans = new List<LessonPlanDTO>();
        private List<LessonScheduleDTO> _lessonSchedules = new List<LessonScheduleDTO>();

        private SchoolBLL _schoolBLL = new SchoolBLL();
        private SemesterBLL _semesterBLL = new SemesterBLL();
        private RoomBLL _roomBL = new RoomBLL();
        private ClassBLL _classBLL = new ClassBLL();
        private CourseBLL _courseBLL = new CourseBLL();
        private LessonScheduleBLL _lessonScheduleBLL = new LessonScheduleBLL();

        private List<CbItemDate> _weekItems = new List<CbItemDate>();
        // suppress combo events while programmatically setting DataSource/SelectedIndex
        private bool _suppressComboEvents = false;
        public event Action<UserControl> OpenUserControlAddSchedule;
        public UcSchedule()
        {
            InitializeComponent();
        }

        private void UcSchedule_Load(object sender, EventArgs e)
        {
            AddControlToListLabel();
            LoadDataForComboboxSchool();
            LoadDataForComboboxSemester();
        }
        private void LoadWeeksForSemester(int selectedSemesterId)
        {
            var semesterBll = new SemesterBLL();
            var semester = semesterBll.GetById(selectedSemesterId);
            if (semester == null) return;

            if (semester.StartDate == null || semester.EndDate == null)
            {
                MessageBox.Show(
                    "Học kỳ không có ngày bắt đầu hoặc ngày kết thúc hợp lệ.",
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            DateTime start = semester.StartDate.Value.Date;
            DateTime end = semester.EndDate.Value.Date;

            var weeks = new List<DateTime>();
            // first item is start date (per your spec)
            weeks.Add(start);

            // compute the Monday of the week that contains 'end'
            int endDay = (int)end.DayOfWeek;
            int offsetToMondayFromEnd = (endDay - (int)DayOfWeek.Monday + 7) % 7;
            DateTime lastMonday = end.AddDays(-offsetToMondayFromEnd);

            // compute first Monday after start (include start already)
            int startDay = (int)start.DayOfWeek;
            int offsetToNextMonday = ((int)DayOfWeek.Monday - startDay + 7) % 7;
            DateTime nextMonday = start.AddDays(offsetToNextMonday == 0 ? 7 : offsetToNextMonday);

            while (nextMonday <= lastMonday)
            {
                weeks.Add(nextMonday);
                nextMonday = nextMonday.AddDays(7);
            }

            // load lesson plans for semester (cached for later usage)
            _LessonPlans = _lessonPlanBLL.GetAllBySemesterId(selectedSemesterId) ?? new List<LessonPlanDTO>();

            // Build _weekItems (store Name and Date) and bind to cbWeek
            _weekItems.Clear();
            int index = 1;
            foreach (var weekStart in weeks)
            {
                var weekEnd = weekStart.AddDays(6);
                if (weekEnd > end) weekEnd = end;
                string label = $"Tuần {index} ({weekStart:dd/MM} - {weekEnd:dd/MM})";

                _weekItems.Add(new CbItemDate
                {
                    Name = label,
                    Date = weekStart
                });

                index++;
            }

            if (cbWeek == null) return;

            _suppressComboEvents = true;
            try
            {
                cbWeek.DataSource = null;
                cbWeek.DisplayMember = nameof(CbItemDate.Name);
                cbWeek.ValueMember = nameof(CbItemDate.Date);
                cbWeek.DataSource = _weekItems;

                if (cbWeek.Items.Count > 0)
                    cbWeek.SelectedIndex = 0;
            }
            finally
            {
                _suppressComboEvents = false;
            }
        }
        /// <summary>
        /// Load data for School combo: display Name, store Id.
        /// Adds "Chọn trường học" as first item and "Thêm mới" as last item (Id = -1).
        /// </summary>
        private void LoadDataForComboboxSchool()
        {
            _suppressComboEvents = true;
            try
            {
                var schools = _schoolBLL.GetAllSchools()
                    .Select(s => new CbItem { Id = s.Id, Name = s.Name })
                    .ToList();

                schools.Insert(0, new CbItem { Id = 0, Name = "Chọn trường học" });
                schools.Add(new CbItem { Id = -1, Name = "Thêm mới" });

                cbSchool.DisplayMember = "Name";
                cbSchool.ValueMember = "Id";
                cbSchool.DataSource = schools;
                cbSchool.SelectedIndex = 0;
            }
            finally
            {
                _suppressComboEvents = false;
            }
        }

        /// <summary>
        /// Load data for semester combo: display Name, store Id.
        /// Adds "Chọn học kỳ" as first item and "Thêm mới" as last item (Id = -1).
        /// </summary>
        private void LoadDataForComboboxSemester()
        {
            _suppressComboEvents = true;
            try
            {
                // Get selected school id from cbSchool (0 means "Chọn trường học")
                int selectedSchoolId = GetComboIntValue(cbSchool);

                List<SemesterDTO> semesters = new List<SemesterDTO>();

                if (selectedSchoolId > 0)
                {
                    semesters = _semesterBLL.GetAllBySchoolId(selectedSchoolId) ?? new List<SemesterDTO>();
                }
                else
                {
                    // no school selected -> keep list empty (only default items will show)
                    semesters = new List<SemesterDTO>();
                }

                var semestersData = semesters
                    .Select(s => new CbItem { Id = s.Id, Name = s.Name })
                    .ToList();

                // ensure default first item
                semestersData.Insert(0, new CbItem { Id = 0, Name = "Chọn học kỳ" });
                // add "Thêm mới" sentinel at end
                semestersData.Add(new CbItem { Id = -1, Name = "Thêm mới" });

                cbSemester.DisplayMember = "Name";
                cbSemester.ValueMember = "Id";
                cbSemester.DataSource = semestersData;
                cbSemester.SelectedIndex = 0;
            }
            finally
            {
                _suppressComboEvents = false;
            }
        }

        /// <summary>
        /// Event handler for cbSchool selection changed
        /// Opens FormAddSchool if "Thêm mới" is selected (Id = -1)
        /// </summary>
        private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressComboEvents) return;
            if (cbSchool.SelectedValue == null) return;

            int id = Convert.ToInt32(cbSchool.SelectedValue);
            if (id == 0)
            {
                cbSemester.DataSource = null;
                cbWeek.DataSource = null;
                return;
            }
            if (id == -1)
            {
                // Open FormAddSchool
                using (var f = new FormAddSchool())
                {
                    f.StartPosition = FormStartPosition.CenterParent;
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        // Reload school list after adding new school
                        LoadDataForComboboxSchool();
                    }
                    else
                    {
                        // User cancelled, reset to first item
                        LoadDataForComboboxSchool();
                    }
                }
                return;
            }

            cbWeek.DataSource = null;
            LoadDataForComboboxSemester();
        }

        /// <summary>
        /// Event handler for cbSemester selection changed
        /// Opens FormAddSemester if "Thêm mới" is selected (Id = -1)
        /// </summary>
        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressComboEvents) return;
            if (cbSemester.SelectedValue == null) return;

            int id = Convert.ToInt32(cbSemester.SelectedValue);
            if (id == -1)
            {
                // Open FormAddSemester
                using (var f = new FormAddSemester())
                {
                    f.StartPosition = FormStartPosition.CenterParent;
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        // Reload semester list after adding new semester
                        LoadDataForComboboxSemester();
                    }
                    else
                    {
                        // User cancelled, reset to first item
                        LoadDataForComboboxSemester();
                    }
                }
                return;
            }

            LoadWeeksForSemester(id);
        }

        /// <summary>
        /// Helper method to get ComboBox integer value safely
        /// </summary>
        private int GetComboIntValue(Guna.UI2.WinForms.Guna2ComboBox comboBox)
        {
            if (comboBox.SelectedValue == null)
                return 0;

            return Convert.ToInt32(comboBox.SelectedValue);
        }

        private void AddControlToListLabel()
        {
            try
            {
                _labelsNameCourse = new List<Label>()
                {
                    lbCourseNameMondayM,
                    lbCourseNameMondayA,
                    lbCourseNameTuesdayM,
                    lbCourseNameTuesdayA,
                    lbCourseNameWednesdayM,
                    lbCourseNameWednesdayA,
                    lbCourseNameThursdayM,
                    lbCourseNameThursdayA,
                    lbCourseNameFridayM,
                    lbCourseNameFridayA,
                    lbCourseNameSaturdayM,
                    lbCourseNameSaturdayA,
                    lbCourseNameSundayM,
                    lbCourseNameSundayA
                };

                _labelsClass = new List<Label>()
                {
                    lbClassMondayM,
                    lbClassMondayA,
                    lbClassTuesdayM,
                    lbClassTuesdayA,
                    lbClassWednesdayM,
                    lbClassWednesdayA,
                    lbClassThursdayM,
                    lbClassThursdayA,
                    lbClassFridayM,
                    lbClassFridayA,
                    lbClassSaturdayM,
                    lbClassSaturdayA,
                    lbClassSundayM,
                    lbClassSundayA
                };

                _labelsTime = new List<Label>()
                {
                    lbTimeMondayM,
                    lbTimeMondayA,
                    lbTimeTuesdayM,
                    lbTimeTuesdayA,
                    lbTimeWednesdayM,
                    lbTimeWednesdayA,
                    lbTimeThursdayM,
                    lbTimeThursdayA,
                    lbTimeFridayM,
                    lbTimeFridayA,
                    lbTimeSaturdayM,
                    lbTimeSaturdayA,
                    lbTimeSundayM,
                    lbTimeSundayA  // Fixed: was lbRoomSundayA in original
                };

                _labelsRoom = new List<Label>()
                {
                    lbRoomMondayM,
                    lbRoomMondayA,
                    lbRoomTuesdayM,
                    lbRoomTuesdayA,
                    lbRoomWednesdayM,
                    lbRoomWednesdayA,
                    lbRoomThursdayM,
                    lbRoomThursdayA,
                    lbRoomFridayM,
                    lbRoomFridayA,
                    lbRoomSaturdayM,
                    lbRoomSaturdayA,
                    lbRoomSundayM,
                    lbRoomSundayA
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void cbWeek_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_suppressComboEvents) return;

            try
            {
                // update label showing current week text (tries to find lbWeek or lblWeekTitle)
                string weekText = cbWeek.Text;
                var foundLabel = this.Controls.Find("lbWeek", true).FirstOrDefault() as Label
                                 ?? this.Controls.Find("lblWeekTitle", true).FirstOrDefault() as Label;
                if (foundLabel != null)
                    foundLabel.Text = weekText;

                // obtain selected Date from cbWeek selected value
                DateTime? weekStart = null;
                if (cbWeek.SelectedValue is DateTime dt)
                {
                    weekStart = dt.Date;
                }
                else if (cbWeek.SelectedItem is CbItemDate item)
                {
                    weekStart = item.Date.Date;
                }
                else if (cbWeek.SelectedValue != null)
                {
                    // attempt convert
                    if (DateTime.TryParse(cbWeek.SelectedValue.ToString(), out var parsed))
                        weekStart = parsed.Date;
                }

                if (!weekStart.HasValue)
                    return;

                UpdateVisibleFlseToflpSchedule();
                _LessonPlans = _lessonPlanBLL.GetAllBySemesterAndWeek(Convert.ToInt32(cbSemester.SelectedValue), weekStart ?? new DateTime());
                foreach (LessonPlanDTO lessonPlanItem in _LessonPlans)
                {
                    _lessonSchedules = _lessonScheduleBLL.GetByLessonPlanId(lessonPlanItem.Id);
                    if (lessonPlanItem == null || _lessonSchedules == null)
                        continue;
                    foreach (LessonScheduleDTO lessonScheduleItem in _lessonSchedules)
                    {
                        // Load data from BLL
                        CourseDTO course = _courseBLL.GetCourseById(lessonPlanItem.CourseId);
                        ClassDTO classDto = _classBLL.GetClassById(lessonScheduleItem.ClassId);
                        RoomDTO room = _roomBL.GetById(lessonScheduleItem.RoomId);

                        // Format time string
                        string timeText = lessonScheduleItem.StartTime.ToString(@"hh\:mm") + " - " + lessonScheduleItem.EndTime.ToString(@"hh\:mm");

                        switch (lessonScheduleItem.DayOfWeek)
                        {
                            case 2: // Monday
                                if (lessonScheduleItem.Session.ToUpper() == "A")
                                {
                                    flpScheduleMondayA.Visible = true;
                                    lbCourseNameMondayA.Text = course?.FullName ?? "";
                                    lbClassMondayA.Text = classDto?.Name ?? "";
                                    lbTimeMondayA.Text = timeText;
                                    lbRoomMondayA.Text = room?.Name ?? "";
                                }
                                else if (lessonScheduleItem.Session.ToUpper() == "M")
                                {
                                    flpScheduleMondayM.Visible = true;
                                    lbCourseNameMondayM.Text = course?.FullName ?? "";
                                    lbClassMondayM.Text = classDto?.Name ?? "";
                                    lbTimeMondayM.Text = timeText;
                                    lbRoomMondayM.Text = room?.Name ?? "";
                                }
                                break;

                            case 3: // Tuesday
                                if (lessonScheduleItem.Session.ToUpper() == "A")
                                {
                                    flpScheduleTuesdayA.Visible = true;
                                    lbCourseNameTuesdayA.Text = course?.FullName ?? "";
                                    lbClassTuesdayA.Text = classDto?.Name ?? "";
                                    lbTimeTuesdayA.Text = timeText;
                                    lbRoomTuesdayA.Text = room?.Name ?? "";
                                }
                                else if (lessonScheduleItem.Session.ToUpper() == "M")
                                {
                                    flpScheduleTuesdayM.Visible = true;
                                    lbCourseNameTuesdayM.Text = course?.FullName ?? "";
                                    lbClassTuesdayM.Text = classDto?.Name ?? "";
                                    lbTimeTuesdayM.Text = timeText;
                                    lbRoomTuesdayM.Text = room?.Name ?? "";
                                }
                                break;

                            case 4: // Wednesday
                                if (lessonScheduleItem.Session.ToUpper() == "A")
                                {
                                    flpScheduleWednesdayA.Visible = true;
                                    lbCourseNameWednesdayA.Text = course?.FullName ?? "";
                                    lbClassWednesdayA.Text = classDto?.Name ?? "";
                                    lbTimeWednesdayA.Text = timeText;
                                    lbRoomWednesdayA.Text = room?.Name ?? "";
                                }
                                else if (lessonScheduleItem.Session.ToUpper() == "M")
                                {
                                    flpScheduleWednesdayM.Visible = true;
                                    lbCourseNameWednesdayM.Text = course?.FullName ?? "";
                                    lbClassWednesdayM.Text = classDto?.Name ?? "";
                                    lbTimeWednesdayM.Text = timeText;
                                    lbRoomWednesdayM.Text = room?.Name ?? "";
                                }
                                break;

                            case 5: // Thursday
                                if (lessonScheduleItem.Session.ToUpper() == "A")
                                {
                                    flpScheduleThursdayA.Visible = true;
                                    lbCourseNameThursdayA.Text = course?.FullName ?? "";
                                    lbClassThursdayA.Text = classDto?.Name ?? "";
                                    lbTimeThursdayA.Text = timeText;
                                    lbRoomThursdayA.Text = room?.Name ?? "";
                                }
                                else if (lessonScheduleItem.Session.ToUpper() == "M")
                                {
                                    flpScheduleThursdayM.Visible = true;
                                    lbCourseNameThursdayM.Text = course?.FullName ?? "";
                                    lbClassThursdayM.Text = classDto?.Name ?? "";
                                    lbTimeThursdayM.Text = timeText;
                                    lbRoomThursdayM.Text = room?.Name ?? "";
                                }
                                break;

                            case 6: // Friday
                                if (lessonScheduleItem.Session.ToUpper() == "A")
                                {
                                    flpScheduleFridayA.Visible = true;
                                    lbCourseNameFridayA.Text = course?.FullName ?? "";
                                    lbClassFridayA.Text = classDto?.Name ?? "";
                                    lbTimeFridayA.Text = timeText;
                                    lbRoomFridayA.Text = room?.Name ?? "";
                                }
                                else if (lessonScheduleItem.Session.ToUpper() == "M")
                                {
                                    flpScheduleFridayM.Visible = true;
                                    lbCourseNameFridayM.Text = course?.FullName ?? "";
                                    lbClassFridayM.Text = classDto?.Name ?? "";
                                    lbTimeFridayM.Text = timeText;
                                    lbRoomFridayM.Text = room?.Name ?? "";
                                }
                                break;

                            case 7: // Saturday
                                if (lessonScheduleItem.Session.ToUpper() == "A")
                                {
                                    flpScheduleSaturdayA.Visible = true;
                                    lbCourseNameSaturdayA.Text = course?.FullName ?? "";
                                    lbClassSaturdayA.Text = classDto?.Name ?? "";
                                    lbTimeSaturdayA.Text = timeText;
                                    lbRoomSaturdayA.Text = room?.Name ?? "";
                                }
                                else if (lessonScheduleItem.Session.ToUpper() == "M")
                                {
                                    flpScheduleSaturdayM.Visible = true;
                                    lbCourseNameSaturdayM.Text = course?.FullName ?? "";
                                    lbClassSaturdayM.Text = classDto?.Name ?? "";
                                    lbTimeSaturdayM.Text = timeText;
                                    lbRoomSaturdayM.Text = room?.Name ?? "";
                                }
                                break;

                            case 8: // Sunday
                                if (lessonScheduleItem.Session.ToUpper() == "A")
                                {
                                    flpScheduleSundayA.Visible = true;
                                    lbCourseNameSundayA.Text = course?.FullName ?? "";
                                    lbClassSundayA.Text = classDto?.Name ?? "";
                                    lbTimeSundayA.Text = timeText;
                                    lbRoomSundayA.Text = room?.Name ?? "";
                                }
                                else if (lessonScheduleItem.Session.ToUpper() == "M")
                                {
                                    flpScheduleSundayM.Visible = true;
                                    lbCourseNameSundayM.Text = course?.FullName ?? "";
                                    lbClassSundayM.Text = classDto?.Name ?? "";
                                    lbTimeSundayM.Text = timeText;
                                    lbRoomSundayM.Text = room?.Name ?? "";
                                }
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void UpdateVisibleFlseToflpSchedule()
        {
            flpScheduleMondayM.Visible = false;
            flpScheduleMondayA.Visible = false;

            flpScheduleTuesdayM.Visible = false;
            flpScheduleTuesdayA.Visible = false;

            flpScheduleWednesdayM.Visible = false;
            flpScheduleWednesdayA.Visible = false;

            flpScheduleThursdayM.Visible = false;
            flpScheduleThursdayA.Visible = false;

            flpScheduleFridayM.Visible = false;
            flpScheduleFridayA.Visible = false;

            flpScheduleSaturdayM.Visible = false;
            flpScheduleSaturdayA.Visible = false;

            flpScheduleSundayM.Visible = false;
            flpScheduleSundayA.Visible = false;
        }

        private void btnAddSchedule_Click(object sender, EventArgs e)
        {
            OpenUserControlAddSchedule?.Invoke(new UcAddSchedule());
        }
    }
}