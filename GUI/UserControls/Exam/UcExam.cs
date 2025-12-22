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
        private 
        public UcExam()
        {
            InitializeComponent();
        }

        private void UcExam_Load(object sender, EventArgs e)
        {
            LoadExamData();
        }
        private void LoadExamData()
        {
            var exams = _examBLL.GetAllExamsOverview();
            dgvExams.Rows.Clear();
            foreach (ExamOverviewDTO exam in exams)
            {
                dgvExams.Rows.Add
                    (exam.ExamId, exam.ExamName, exam.CourseName, exam.SchoolName, exam.ExamType, exam.Duration, exam.Status, exam.QuestionCount, null, null);
            }
        }
    }
}
