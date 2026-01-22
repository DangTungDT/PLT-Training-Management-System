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
    public class CbItemDate
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
    }
    public partial class UcSchedule : UserControl
    {
        List<Label> _labelsNameCourse;
        List<Label> _labelsClass;
        List<Label> _labelsTime;
        List<Label> _labelsRoom;
        private readonly LessonPlanBLL _lessonPlanBLL = new LessonPlanBLL();
        private List<LessonPlanDTO> _LessonPlans = new List<LessonPlanDTO>();

        private SchoolBLL _schoolBLL = new SchoolBLL();
        private SemesterBLL _semesterBLL = new SemesterBLL();

        private List<CbItemDate> _weekItems = new List<CbItemDate>();
        // suppress combo events while programmatically setting DataSource/SelectedIndex
        private bool _suppressComboEvents = false;
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

            cbWeek.Items.Clear();
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
            try
            {

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
    }
}