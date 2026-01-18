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
            _allFileIdOfExamSelected = _examFileBLL.GetAllFileByExamId(_examSelected.Id);
            LoadFileOfBook();
        }

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

        // --- START: File list / layout fixes ----------------------------------

        private void LoadFileOfBook()
        {
            flpFiles.Controls.Clear();
            _ListFileOfBookSelected = new List<FilesDTO>();

            // Ensure vertical stacking and no wrap
            flpFiles.FlowDirection = FlowDirection.TopDown;
            flpFiles.WrapContents = false;
            flpFiles.AutoScroll = true;

            // Subscribe layout event which fires when the internal layout changes
            flpFiles.Layout -= FlpFiles_Layout;
            flpFiles.Layout += FlpFiles_Layout;

            flpFiles.SuspendLayout();
            int positionForm = 1;
            foreach (int fileId in _allFileIdOfExamSelected)
            {
                FilesDTO file = _fileBLL.GetFileById(fileId);
                if (file == null) continue;

                _ListFileOfBookSelected.Add(file);
                ucFileOfBook ucFile = new ucFileOfBook(file, positionForm);

                // important: ensure the user control itself does not AutoSize to true
                ucFile.AutoSize = false;
                ucFile.Margin = new Padding(0, 0, 0, 8);
                ucFile.Dock = DockStyle.None; // FlowLayoutPanel will position items
                ucFile.DeleteFile += UcFileOfBook_ButtonDelete;
                ucFile.ActionReadFile += ReadFileOfBook;

                // Set an initial width; final width will be corrected in Layout event
                int initialWidth = GetFlpInnerWidth();
                ucFile.Width = Math.Max(0, initialWidth - ucFile.Margin.Left - ucFile.Margin.Right);

                flpFiles.Controls.Add(ucFile);
                positionForm++;
            }
            flpFiles.ResumeLayout();

            // Force a layout pass and adjust widths immediately
            flpFiles.PerformLayout();
            AdjustFileControlsWidth();
        }

        /// <summary>
        /// Tính chiều ngang khả dụng bên trong flpFiles (trừ padding và thanh cuộn dọc nếu có).
        /// </summary>
        private int GetFlpInnerWidth()
        {
            int w = flpFiles.ClientSize.Width - flpFiles.Padding.Left - flpFiles.Padding.Right;
            // Nếu scrollbar dọc hiển thị thì trừ bớt chiều rộng của nó
            if (flpFiles.VerticalScroll.Visible)
            {
                w -= SystemInformation.VerticalScrollBarWidth;
            }
            return Math.Max(0, w);
        }

        /// <summary>
        /// Thiết lập lại width cho tất cả control con trong flpFiles.
        /// Gọi khi layout thay đổi, khi thêm/xóa item, hoặc khi size container thay đổi.
        /// </summary>
        private void AdjustFileControlsWidth()
        {
            int targetWidth = GetFlpInnerWidth();
            foreach (Control control in flpFiles.Controls)
            {
                // trừ margin của control để tránh tràn
                int newW = Math.Max(0, targetWidth - control.Margin.Left - control.Margin.Right);
                if (control.Width != newW)
                    control.Width = newW;
            }
        }

        private void FlpFiles_Layout(object sender, LayoutEventArgs e)
        {
            // Mọi lần layout (kể cả khi scrollbar xuất hiện), cập nhật lại width
            AdjustFileControlsWidth();
        }

        private void FlpFiles_SizeChanged(object sender, EventArgs e)
        {
            // nếu vẫn dùng SizeChanged ở chỗ khác, chỉ gọi hàm điều chỉnh
            AdjustFileControlsWidth();
        }

        private void FlpFiles_ControlAdded(object sender, ControlEventArgs e)
        {
            // đảm bảo control mới nhận chiều rộng phù hợp
            if (e.Control != null)
            {
                int w = GetFlpInnerWidth() - e.Control.Margin.Left - e.Control.Margin.Right;
                e.Control.Width = Math.Max(0, w);
            }
        }

        // Khi xóa item: cập nhật lại chiều rộng (và label tổng số)
        private void UcFileOfBook_ButtonDelete(int e, int position)
        {
            try
            {
                if (!_examFileBLL.DeletedExamFile(_examSelected.Id, e))
                {
                    MessageBox.Show("Xóa tệp của sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (position - 1 >= 0 && position - 1 < flpFiles.Controls.Count)
                    flpFiles.Controls.RemoveAt(position - 1);

                // cập nhật lại số lượng hiển thị nếu lblTotalFiles chứa số nguyên
                if (int.TryParse(lblTotalFiles.Text.Split(' ')[0], out int current))
                {
                    var newCount = Math.Max(0, current - 1);
                    lblTotalFiles.Text = $"{newCount} tệp";
                }

                // điều chỉnh lại width sau khi xóa
                AdjustFileControlsWidth();
            }
            catch
            {
                MessageBox.Show("Xóa tệp của sách thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReadFileOfBook(int fileId)
        {
            OpenUserControlReadFile?.Invoke(fileId);
        }

        // --- END: File list / layout fixes ----------------------------------

        // rest of the file unchanged (load questions, button handlers etc.)
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
                // delete logic...
            }
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            if (_examSelected == null) return;

            try
            {
                string newStatus = _examSelected.Status == "Đang sử dụng" ? "Ngừng sử dụng" : "Đang sử dụng";
                _examSelected.Status = newStatus;

                if (_examBLL.UpdateExam(_examSelected))
                {
                    MessageBox.Show($"Cập nhật trạng thái thành '{newStatus}' thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadExamInfo();
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


        private void lblTabQuestion_Click(object sender, EventArgs e)
        {
            lblTabOverview.ForeColor = Color.Black;
            lblTabQuestion.ForeColor = Color.FromArgb(59, 130, 246);

            // Hiển thị tab câu hỏi
            flpQuestion.Visible = true;
            tlpValueExam.Visible = false;
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

            // Hiển thị tab tổng quan
            tlpValueExam.Visible = true;
            flpQuestion.Visible = false;
        }
    }
}