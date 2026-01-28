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

namespace GUI.UserControls.Exam
{
    public partial class UcExam : UserControl
    {
        private ExamBLL _examBLL = new ExamBLL();
        private SchoolBLL _schoolBLL = new SchoolBLL();
        private CourseBLL _courseBLL = new CourseBLL();
        private SemesterBLL _semesterBLL = new SemesterBLL();

        public Action OpenAddExam;

        public event Action<int> OpenUserControlEditExam;
        public event Action<int> OpenUserControlReadExam;

        // suppress combo events while programmatically setting DataSource/SelectedIndex
        private bool _suppressComboEvents = false;

        // helper item used as DataSource element for combos (shows Name, stores Id)
        private class CbItem
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }

        public UcExam()
        {
            InitializeComponent();
        }

        private void LoadImageForColumnDataGirdViewBook()
        {
            colEdit.Width = 60;
            colView.Width = 60;
            colDelete.Width = 60;

            colEdit.ImageLayout = DataGridViewImageCellLayout.Normal;
            colView.ImageLayout = DataGridViewImageCellLayout.Normal;
            colDelete.ImageLayout = DataGridViewImageCellLayout.Normal;

            colEdit.Image = Properties.Resources.edit_32;
            colView.Image = Properties.Resources.view_32;
            colDelete.Image = Properties.Resources.delete_32;
        }

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

        private void LoadDataForComboboxCourse()
        {
            _suppressComboEvents = true;
            try
            {
                int idSemester = GetComboIntValue(cbSemester);
                var courses = _courseBLL.GetAllBySemesterId(idSemester)
                    .Select(c => new CbItem { Id = c.Id, Name = c.FullName })
                    .ToList();

                courses.Insert(0, new CbItem { Id = 0, Name = "Chọn khóa học" });
                courses.Add(new CbItem { Id = -1, Name = "Thêm mới" });

                cbCourse.DisplayMember = "Name";
                cbCourse.ValueMember = "Id";
                cbCourse.DataSource = courses;
                cbCourse.SelectedIndex = 0;
            }
            finally
            {
                _suppressComboEvents = false;
            }
        }

        /// <summary>
        /// Load data for semester combo: display Name, store Id.
        /// Adds "Chọn học kỳ" as first item and "Thêm mới" as last item (Id = -1).
        /// NOTE: Adjust data source call to get semesters available in your project (by school or global).
        /// </summary>
        private void LoadDataForComboboxSemester()
        {
            _suppressComboEvents = true;
            try
            {
                int idSchool = GetComboIntValue(cbSchool);
                var semesters = _semesterBLL.GetAllBySchoolId(idSchool) ?? new List<SemesterDTO>();

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


        private void UcExam_Load(object sender, EventArgs e)
        {
            LoadImageForColumnDataGirdViewBook();
            LoadDataForComboboxSchool();
            LoadExamDataToDGV();
        }

        private int GetComboIntValue(ComboBox comboBox)
        {
            if (comboBox.SelectedValue == null)
                return 0;

            return Convert.ToInt32(comboBox.SelectedValue);
        }

        private void LoadExamDataToDGV()
        {
            try
            {
                int schoolId = GetComboIntValue(cbCourse);
                int courseId = GetComboIntValue(cbSchool);
                int semesterId = GetComboIntValue(cbSemester);
                var exams = _examBLL.GetExamsOverviewFilter(courseId, schoolId, semesterId);
                dgvExams.Rows.Clear();
                foreach (ExamOverviewDTO exam in exams)
                {
                    dgvExams.Rows.Add
                        (exam.ExamId, exam.ExamName, exam.CourseName, exam.SchoolName, exam.ClassName, exam.ExamType, exam.Duration, exam.QuestionCount, exam.Status, null, null, null);
                }
                lbTotalExam.Text = $"Tổng số đề thi: {exams.Count()}";
            }catch(Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu đề thi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_suppressComboEvents) return;
                if (cbSchool.SelectedValue == null) return;

                int id = Convert.ToInt32(cbSchool.SelectedValue);
                if (id == -1)
                {
                    using (var f = new FormAddSchool())
                    {
                        f.StartPosition = FormStartPosition.CenterParent;
                        f.ShowDialog();
                    }
                    LoadDataForComboboxSchool();
                    return;
                }
                if (id != 0)
                {
                    LoadDataForComboboxSemester();
                }
                else
                {
                    cbSemester.DataSource = null;
                    cbCourse.DataSource = null;
                }
                    LoadExamDataToDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu trường học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (_suppressComboEvents) return;
                if (cbCourse.SelectedValue == null) return;

                int id = Convert.ToInt32(cbCourse.SelectedValue);
                if (id == -1)
                {
                    // FormAddSubject is the form for adding a subject (course)
                    using (var f = new FormAddSubject())
                    {
                        f.StartPosition = FormStartPosition.CenterParent;
                        f.ShowDialog();
                    }
                    LoadDataForComboboxCourse();
                    return;
                }

                LoadExamDataToDGV();
            }catch(Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu khóa học: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cbCourse.DataSource = null;
                if (_suppressComboEvents) return;
                if (cbSemester.SelectedValue == null) return;

                int id = Convert.ToInt32(cbSemester.SelectedValue);
                if (id == -1)
                {
                    using (var f = new FormAddSemester())
                    {
                        f.StartPosition = FormStartPosition.CenterParent;
                        f.ShowDialog();
                    }
                    LoadDataForComboboxSemester();
                    return;
                }

                if (id != 0)
                {
                    LoadDataForComboboxCourse();
                }
                else
                {
                    cbCourse.DataSource = null;
                }
                    LoadExamDataToDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu học kỳ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            OpenAddExam?.Invoke();
        }

        private void dgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            // Lấy id exam an toàn
            object rawId = dgvExams.Rows[e.RowIndex].Cells[0].Value;
            if (rawId == null || !int.TryParse(rawId.ToString(), out int idExamSelected))
                return;

            string nameOfColumn = dgvExams.Columns[e.ColumnIndex].Name;

            if (nameOfColumn == "colEdit")
            {
                OpenUserControlEditExam?.Invoke(idExamSelected);
            }
            else if (nameOfColumn == "colDelete")
            {
                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa đề thi?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool deleted = _examBLL.DeleteById(idExamSelected);
                        if (deleted)
                        {
                            MessageBox.Show("Xóa đề thi thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            // Reload lại dữ liệu trong DataGridView
                            LoadExamDataToDGV();
                        }
                        else
                        {
                            MessageBox.Show("Xóa đề thi thất bại. Có thể đề thi không tồn tại hoặc đã có lỗi.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Lỗi khi xóa đề thi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (nameOfColumn == "colView")
            {
                OpenUserControlReadExam?.Invoke(idExamSelected);
            }
        }
    }
}