using BLL;
using DTO;
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
        public Action OpenAddExam;

        public event Action<int> OpenUserControlEditExam;
        public event Action<int> OpenUserControlReadExam;
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
        private void LoadDataForComboboxYear()
        {
            var years = _examBLL.GetAllYearForExam()
                .Distinct()
                .OrderByDescending(y => y)
                .Select(y => new
                {
                    Id = y,
                    Name = y.ToString()
                })
                .ToList();

            years.Insert(0, new
            {
                Id = 0,
                Name = "Chọn năm"
            });
            cbYearCourse.DisplayMember = "Name";
            cbYearCourse.ValueMember = "Id";
            cbYearCourse.DataSource = years;
            cbYearCourse.SelectedIndex = 0;
        }

        private void LoadDataForComboboxCourse()
        {
            var courses = _courseBLL.GetAllCourses().ToList();

            courses.Insert(0, new CourseDTO
            {
                Id = 0,
                FullName = "Chọn khóa học"
            });
            cbCourse.DisplayMember = "FullName";
            cbCourse.ValueMember = "Id";
            cbCourse.DataSource = courses;
            cbCourse.SelectedIndex = 0;
        }
        private void LoadDataForComboboxSchool()
        {
            var schools = _schoolBLL.GetAllSchools().ToList();
            schools.Insert(0, new SchoolDTO
            {
                Id = 0,
                Name = "Chọn trường học"
            });
            cbSchool.DisplayMember = "Name";
            cbSchool.ValueMember = "Id";
            cbSchool.DataSource = schools;
            cbSchool.SelectedIndex = 0;
        }

        private void UcExam_Load(object sender, EventArgs e)
        {
            LoadImageForColumnDataGirdViewBook();
            LoadDataForComboboxSchool();
            LoadDataForComboboxCourse();
            LoadDataForComboboxYear();
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
            int schoolId = GetComboIntValue(cbSchool);
            int courseId = GetComboIntValue(cbCourse);
            int year = GetComboIntValue(cbYearCourse);
            var exams = _examBLL.GetExamsOverviewFilter(courseId, schoolId, year);
            dgvExams.Rows.Clear();
            foreach (ExamOverviewDTO exam in exams)
            {
                dgvExams.Rows.Add
                    (exam.ExamId, exam.ExamName, exam.CourseName, exam.SchoolName, exam.ClassName, exam.ExamType, exam.Duration, exam.QuestionCount, exam.Status, null, null, null);
            }
            lbTotalExam.Text = $"Tổng số đề thi: {exams.Count()}";
        }
        private void cbYearCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadExamDataToDGV();
        }

        private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadExamDataToDGV();
        }

        private void cbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadExamDataToDGV();
        }

        private void btnAddExam_Click(object sender, EventArgs e)
        {
            OpenAddExam?.Invoke();
        }

        private void dgvExams_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            int idExamSelected = 0;
            int.TryParse(dgvExams.Rows[rowIndex].Cells[0].Value.ToString(), out idExamSelected);
            string nameOfColumn = dgvExams.Columns[columnIndex].Name;
            DataGridViewRow row = dgvExams.Rows[e.RowIndex];
            if (nameOfColumn == "colEdit")
            {
                OpenUserControlEditExam?.Invoke(idExamSelected);
            }
            else if (nameOfColumn == "colDelete")
            {
                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa đề thi?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                }
            }
            else if (nameOfColumn == "colView")
            {
                OpenUserControlReadExam?.Invoke(idExamSelected);
            }
        }

        private void cbYearCourse_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LoadExamDataToDGV();
        }
    }
}
