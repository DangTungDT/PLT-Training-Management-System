using BLL;
using DTO;
using GUI.UserControls.Book;
using GUI.UserControls.Question;
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
    public partial class UcReadExam : UserControl
    {
        private ExamDTO _examSelected;
        private ExamBLL _examBLL = new ExamBLL();
        private CourseBLL _courseBLL = new CourseBLL();
        private SchoolBLL _schoolBLL = new SchoolBLL();
        private ClassBLL _classBLL = new ClassBLL();
        private QuestionBLL _questionBLL = new QuestionBLL();
        private ClassExamBLL _classExamBLL = new ClassExamBLL();
        private FileBLL _fileBLL = new FileBLL();
        private ExamFileBLL _examFileBLL = new ExamFileBLL();

        private bool _flagLoadFile = false;
        private List<int> _allFileIdOfExamSelected;
        private List<FilesDTO> _ListFileOfBookSelected;
        public Action BackToExamList;
        public event Action<int> OpenUserControlEditExam;
        public event Action<int> OpenUserControlReadFile;

        private bool _flagLoadQuestion = false;
        public UcReadExam(int examId)
        {
            InitializeComponent();
            _examSelected = _examBLL.GetExamById(examId);
        }

        private void UcReadExam_Load(object sender, EventArgs e)
        {
            if (_examSelected == null)
            {
                MessageBox.Show("Không tìm thấy đề thi đã chọn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadExamInfo();
            LoadExamStatistics();
            LoadExamDetails();
            //LoadQuestions();
            UpdatePublishButton();
            //SetupButtonEvents();
            //LoadUserControlAddQuestion();
            _allFileIdOfExamSelected = _examFileBLL.GetAllFileByExamId(_examSelected.Id);
        }

        //private void SetupButtonEvents()
        //{
        //    btnBack.Click += btnBack_Click;
        //    btnEdit.Click += btnEdit_Click;
        //    btnDelete.Click += btnDelete_Click;
        //    btnPublish.Click += btnPublish_Click;
        //}

        private void LoadExamInfo()
        {
            try
            {
                // Load thông tin cơ bản của exam
                lblExamName.Text = _examSelected.Name;
                lblExamMeta.Text = $"ID: {_examSelected.Id}  •  Năm tạo: {_examSelected.Year}";

                // Load trạng thái
                label22.Text = _examSelected.Status;
                label22.BackColor = GetStatusColor(_examSelected.Status);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load thông tin exam: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Color GetStatusColor(string status)
        {
            switch (status?.ToLower())
            {
                case "đang sử dụng":
                    return Color.FromArgb(34, 197, 94); // Green
                case "ngừng sử dụng":
                    return Color.FromArgb(239, 68, 68); // Red
                default:
                    return Color.FromArgb(245, 158, 11); // Orange
            }
        }

        private void LoadExamStatistics()
        {
            try
            {
                // Load tổng số câu hỏi
                List<QuestionDTO> questions = _questionBLL.GetQuestionByIdExam(_examSelected.Id);
                int totalQuestions = questions?.Count ?? 0;
                lbTotalQuestion.Text = totalQuestions.ToString();

                // Load tổng điểm
                decimal totalScore = questions?.Sum(q => q.Score) ?? 0;
                lbTotalSocre.Text = totalScore.ToString("F1");

                // Load thời gian
                lbTime.Text = _examSelected.Duration.ToString();

                // Load số lượt thi (có thể lấy từ bảng ExamAttempt nếu có)
                // Tạm thời set mặc định
                lbLuocThi.Text = "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load thống kê: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadExamDetails()
        {
            try
            {
                // Load môn học
                CourseDTO course = _courseBLL.GetCourseById(_examSelected.CourseId);
                lbSubject.Text = course?.FullName ?? "N/A";

                // Load trường
                int schoolId = _schoolBLL.GetSchoolIdBySemesterId(_examSelected.SemesterId);
                SchoolDTO school = _schoolBLL.GetSchoolById(schoolId);
                lbSchool.Text = school?.Name ?? "N/A";

                // Load loại đề thi
                lbTypeExam.Text = _examSelected.Type ?? "N/A";

                // Load lớp học
                List<int> classIds = _classExamBLL.GetIdClassByIdExam(_examSelected.Id);
                string classNames = "";
                if (classIds != null && classIds.Count > 0)
                {
                    foreach (int classId in classIds)
                    {
                        ClassDTO cls = _classBLL.GetClassById(classId);
                        if (cls != null)
                        {
                            classNames += (classNames == "" ? "" : ", ") + cls.Name;
                        }
                    }
                }
                lbClass.Text = string.IsNullOrEmpty(classNames) ? "N/A" : classNames;

                // Load mô tả và hướng dẫn
                label16.Text = _examSelected.Description ?? "Không có mô tả";
                label8.Text = _examSelected.ExamInstruction ?? "Không có hướng dẫn";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi load chi tiết: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadUserControlAddQuestion()
        {
            List<QuestionDTO> questions = _questionBLL.GetQuestionByIdExam(_examSelected.Id);

            foreach (QuestionDTO question in questions)
            {
                UcAddQuestion ucAddQuestion;
                ucAddQuestion = new UcAddQuestion(question);
                ucAddQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                int width = flpQuestion.ClientSize.Width - 60;
                ucAddQuestion.Size = new Size(width, ucAddQuestion.Size.Height);
                ucAddQuestion.SetNumberQuestion(flpQuestion.Controls.Count + 1);
                flpQuestion.Controls.Add(ucAddQuestion);
            }
        }
        private void LoadFileOfBook()
        {
            flpFiles.Controls.Clear();
            _ListFileOfBookSelected = new List<FilesDTO>();

            int positionForm = 1;
            foreach (int fileId in _allFileIdOfExamSelected)
            {
                FilesDTO file = _fileBLL.GetFileById(fileId);
                if (file == null) continue;

                _ListFileOfBookSelected.Add(file);

                ucFileOfBook ucFile = new ucFileOfBook(file, positionForm);

                ucFile.Margin = new Padding(0, 0, 0, 8);
                ucFile.Dock = DockStyle.Top;

                ucFile.DeleteFile += UcFileOfBook_ButtonDelete;
                ucFile.ActionReadFile += ReadFileOfBook;
                flpFiles.Controls.Add(ucFile);

                positionForm++;
            }
        }
        private void ReadFileOfBook(int fileId)
        {
            OpenUserControlReadFile?.Invoke(fileId);
        }
        private void UcFileOfBook_ButtonDelete(int e, int position)
        {
            try
            {
                if (!_examFileBLL.DeletedExamFile(_examSelected.Id, e))
                {
                    MessageBox.Show("Xóa tệp của sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                flpFiles.Controls.RemoveAt(position - 1);
                lblTotalFiles.Text = (int.Parse(lblTotalFiles.Text) - 1).ToString();
            }
            catch
            {
                MessageBox.Show("Xóa tệp của sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //private void LoadQuestions()
        //{
        //    try
        //    {
        //        flpQuestion.Controls.Clear();

        //        List<QuestionDTO> questions = _questionBLL.GetQuestionByIdExam(_examSelected.Id);

        //        if (questions == null || questions.Count == 0)
        //        {
        //            Label noQuestionLabel = new Label
        //            {
        //                Text = "Chưa có câu hỏi nào",
        //                AutoSize = true,
        //                ForeColor = Color.Gray,
        //                Font = new Font("Segoe UI", 12F)
        //            };
        //            flpQuestion.Controls.Add(noQuestionLabel);
        //            return;
        //        }

        //        int questionNumber = 1;
        //        foreach (QuestionDTO question in questions)
        //        {
        //            // Tạo panel cho mỗi câu hỏi
        //            Panel questionPanel = CreateQuestionPanel(question, questionNumber);
        //            flpQuestion.Controls.Add(questionPanel);
        //            questionNumber++;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Lỗi khi load câu hỏi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //private Panel CreateQuestionPanel(QuestionDTO question, int questionNumber)
        //{
        //    Panel panel = new Panel
        //    {
        //        Width = flpQuestion.ClientSize.Width - 60,
        //        AutoSize = true,
        //        BackColor = Color.White,
        //        Margin = new Padding(0, 0, 0, 15),
        //        Padding = new Padding(20)
        //    };

        //    // Header câu hỏi
        //    Label lblQuestionHeader = new Label
        //    {
        //        Text = $"Câu hỏi {questionNumber} ({question.Type}) - {question.Score} điểm",
        //        Font = new Font("Segoe UI", 11F, FontStyle.Bold),
        //        AutoSize = true,
        //        ForeColor = Color.FromArgb(60, 131, 246),
        //        Dock = DockStyle.Top
        //    };
        //    panel.Controls.Add(lblQuestionHeader);

        //    // Nội dung câu hỏi
        //    Label lblQuestionContent = new Label
        //    {
        //        Text = question.Content,
        //        Font = new Font("Segoe UI", 10F),
        //        AutoSize = true,
        //        MaximumSize = new Size(panel.Width - 40, 0),
        //        Padding = new Padding(0, 10, 0, 10),
        //        Dock = DockStyle.Top
        //    };
        //    panel.Controls.Add(lblQuestionContent);

        //    // Load các options
        //    List<QuestionOptionDTO> options = _questionOptionBLL.GetQuestionOptionByIdQuestion(question.Id);
        //    if (options != null && options.Count > 0)
        //    {
        //        FlowLayoutPanel optionsPanel = new FlowLayoutPanel
        //        {
        //            FlowDirection = FlowDirection.TopDown,
        //            AutoSize = true,
        //            WrapContents = false,
        //            Dock = DockStyle.Top,
        //            Padding = new Padding(20, 0, 0, 0)
        //        };

        //        char optionLetter = 'A';
        //        foreach (QuestionOptionDTO option in options)
        //        {
        //            Label lblOption = new Label
        //            {
        //                Text = $"{optionLetter}. {option.Content}",
        //                Font = new Font("Segoe UI", 9F, option.IsCorrect ? FontStyle.Bold : FontStyle.Regular),
        //                ForeColor = option.IsCorrect ? Color.FromArgb(34, 197, 94) : Color.Black,
        //                AutoSize = true,
        //                MaximumSize = new Size(panel.Width - 80, 0),
        //                Padding = new Padding(0, 5, 0, 5)
        //            };
        //            optionsPanel.Controls.Add(lblOption);
        //            optionLetter++;
        //        }

        //        panel.Controls.Add(optionsPanel);
        //    }

        //    return panel;
        //}

        private void btnBack_Click(object sender, EventArgs e)
        {
            BackToExamList?.Invoke();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_examSelected != null)
            {
                OpenUserControlEditExam?.Invoke(_examSelected.Id);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_examSelected == null) return;

            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa đề thi '{_examSelected.Name}'?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                //try
                //{
                //    if (_examBLL.DeleteExam(_examSelected.Id))
                //    {
                //        MessageBox.Show("Xóa đề thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //        BackToExamList?.Invoke();
                //    }
                //    else
                //    {
                //        MessageBox.Show("Xóa đề thi thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show($"Lỗi khi xóa đề thi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (_examSelected == null) return;

            try
            {
                // Toggle trạng thái
                string newStatus = _examSelected.Status == "Đang sử dụng" ? "Ngừng sử dụng" : "Đang sử dụng";
                _examSelected.Status = newStatus;

                if (_examBLL.UpdateExam(_examSelected))
                {
                    MessageBox.Show($"Cập nhật trạng thái thành '{newStatus}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadExamInfo(); // Reload để cập nhật UI
                    UpdatePublishButton();
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật trạng thái: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdatePublishButton()
        {
            if (_examSelected.Status == "Đang sử dụng")
            {
                btnPublish.Text = "Ngừng xuất bản";
                btnPublish.FillColor = Color.FromArgb(239, 68, 68); // Red
            }
            else
            {
                btnPublish.Text = "Xuất bản";
                btnPublish.FillColor = Color.FromArgb(34, 197, 94); // Green
            }
        }

        private void lblTabQuestion_Click(object sender, EventArgs e)
        {
            lblTabOverview.ForeColor = Color.Black;
            lblTabFile.ForeColor = Color.Black;
            lblTabQuestion.ForeColor = Color.FromArgb(59, 130, 246);

            // Hiển thị tab câu hỏi
            tlpTabContent.Visible = false;
            flpQuestion.Visible = true;
            pnlRightFill.Visible = false;
            if (!_flagLoadQuestion)
            {
                LoadUserControlAddQuestion();
                _flagLoadQuestion = true;
            }
        }

        private void lblTabOverview_Click(object sender, EventArgs e)
        {
            lblTabOverview.ForeColor = Color.FromArgb(59, 130, 246);
            lblTabQuestion.ForeColor = Color.Black;
            lblTabFile.ForeColor = Color.Black;

            // Hiển thị tab tổng quan
            tlpTabContent.Visible = true;
            flpQuestion.Visible = false;
            pnlRightFill.Visible = false;
        }

        private void lblTabFile_Click(object sender, EventArgs e)
        {
            lblTabOverview.ForeColor = Color.Black;
            lblTabQuestion.ForeColor = Color.Black;
            lblTabFile.ForeColor = Color.FromArgb(59, 130, 246);

            // Hiển thị tab câu hỏi
            tlpTabContent.Visible = false;
            flpQuestion.Visible = false;
            pnlRightFill.Visible = true;
            if (!_flagLoadFile)
            {
                LoadFileOfBook();
                _flagLoadFile = true;
            }
        }
    }
}