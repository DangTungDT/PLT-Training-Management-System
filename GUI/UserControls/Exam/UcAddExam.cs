using BLL;
using DTO;
using GUI.UserControls.Question;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna;
using Guna.UI2.WinForms;
using GUI.Helpers;

namespace GUI.UserControls.Exam
{
    public partial class UcAddExam : UserControl
    {
        private int _stageAddExam = 1;
        private bool _flagImportQuestion = false;
        private int _totalOptionsQuestion = 0;
        private double _totalScoreQuestion = 0;
        private ExamDTO _newExam;
        private int _totalQuestion = 1;
        private List<QuestionAndOption> _allQuestionAndOption;

        private ExamBLL _examBLL = new ExamBLL();
        private CourseBLL _courseBLl = new CourseBLL();
        private SchoolBLL _schoolBLL = new SchoolBLL();
        private SemesterBLL _semesterBLL = new SemesterBLL();
        private ClassBLL _classBLL = new ClassBLL();
        private FacultyBLL _facultyBLL = new FacultyBLL();
        private QuestionBLL _questionBLL = new QuestionBLL();
        private QuestionOptionBLL _questionOptionBLL = new QuestionOptionBLL();
        public Action BackToUcExam;
        public UcAddExam()
        {
            InitializeComponent();
            _stageAddExam = 1;
        }

        private void LoadCourseToCombobox(int semesterId)
        {
            try
            {
                var courses = _courseBLl.GetAllBySemesterId(semesterId);
                cbSubject.DisplayMember = "FullName";
                cbSubject.ValueMember = "Id";
                cbSubject.DataSource = courses;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LoadSchoolToCombobox()
        {
            try
            {
                var schools = _schoolBLL.GetAllSchools();
                cbSchool.DisplayMember = "Name";
                cbSchool.ValueMember = "Id";
                cbSchool.DataSource = schools.ToList();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void LoadFacultyToCombobox(int schoolId)
        {
            try
            {
                var facultyes = _facultyBLL.GetAllBySchoolId(schoolId);
                cbFaculty.DisplayMember = "Name";
                cbFaculty.ValueMember = "Id";
                cbFaculty.DataSource = facultyes.ToList();

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LoadClassToCombobox(int facultyId)
        {
            try
            {
                var classes = _classBLL.GetAllByFacultyId(facultyId);
                cbClass.DisplayMember = "Name";
                cbClass.ValueMember = "Id";
                cbClass.DataSource = classes;

            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void LoadSemesterToCombobox(int schoolId)
        {
            try
            {
                var semesters = _semesterBLL.GetAllBySchoolId(schoolId);

                cbSemester.DataSource = null;
                cbSemester.DisplayMember = "Name";
                cbSemester.ValueMember = "Id";
                cbSemester.DataSource = semesters;
                cbSemester.SelectedIndex = -1;
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public bool GetAllQuestionForExam()
        {
            List<QuestionAndOption> allQuestionAndOption = new List<QuestionAndOption>();
            foreach (Control controlItem in flpQuestion.Controls)
            {
                if (controlItem is UcAddQuestion uc)
                {
                    QuestionAndOption newQuestion = uc.GetQuestionAndAllOptionQuestion();
                    if (newQuestion == null)
                    {
                        int numberQuestion = uc.GetNumberQuestion();
                        MessageBox.Show($"Thêm câu hỏi {numberQuestion} thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                    else
                    {
                        allQuestionAndOption.Add(newQuestion);
                    }
                }
            }

            _allQuestionAndOption = allQuestionAndOption;
            return true;
        }


        public ExamDTO GetExam()
        {
            try
            {
                if (!ValidateExamControls())
                {
                    return null;
                }

                _newExam = GetNewExamValue();
                if (_newExam == null) return null;
                return _newExam;
            }
            catch
            {
                return null;
            }
        }
        public List<QuestionAndOption> GetAllQuestionAndOption()
        {
            try
            {
                if (!GetAllQuestionForExam())
                {
                    return null;
                }
                return _allQuestionAndOption;
            }
            catch
            {
                return null;
            }
        }
        public ExamDTO GetNewExamValue()
        {
            try
            {
                int examduration = 0;
                int courseIdforNewExam = 0;
                int semesterIdforNewExam = 0;
                int yearforNewExam = 0;
                string statusForNewExam = "Đang sử dụng";
                if (!int.TryParse(txtExamTime.Text, out examduration))
                {
                    MessageBox.Show("Nhập đúng thời gian kiểm tra hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                if (cbTimeType.Text.ToLower() == "giờ")
                {
                    examduration = examduration * 60;
                }

                if (!int.TryParse(cbSubject.SelectedValue.ToString(), out courseIdforNewExam))
                {
                    MessageBox.Show("Có lỗi sảy ra trong quá trình lấy id khóa học (Subject)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                if (!int.TryParse(cbSemester.SelectedValue.ToString(), out semesterIdforNewExam) || cbSemester.Items.Count == 0)
                {
                    MessageBox.Show("Có lỗi sảy ra trong quá trình lấy id học kỳ (Semester)!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }

                yearforNewExam = DateTime.Now.Year;
                ExamDTO newExam = new ExamDTO()
                {
                    Name = txtExamName.Text,
                    Type = cbExamType.Text,
                    Duration = examduration,
                    ExamInstruction = txtExamInstruction.Text,
                    Description = txtDescription.Text,
                    CourseId = courseIdforNewExam,
                    SemesterId = semesterIdforNewExam,
                    Year = yearforNewExam,
                    Status = statusForNewExam
                };
                return newExam;
            }
            catch
            {
                return null;
            }
        }
        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            LoadStage(1);
        }

        private void LoadUserControlAddQuestion()
        {
            int.TryParse(txtTotalQuestion.Text, out _totalQuestion);
            if (_totalQuestion == 0) _totalQuestion = 1;
            for (int i = 0; i < _totalQuestion; i++)
            {
                UcAddQuestion ucAddQuestion;
                if (_newExam == null) _newExam = GetNewExamValue();
                ucAddQuestion = new UcAddQuestion();
                ucAddQuestion.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                int width = flpQuestion.ClientSize.Width - 60;
                ucAddQuestion.Size = new Size(width, ucAddQuestion.Size.Height);
                ucAddQuestion.SetNumberQuestion(flpQuestion.Controls.Count + 1);
                flpQuestion.Controls.Add(ucAddQuestion);
            }
        }

        private void LoadStage(int stageIndex)
        {
            switch (stageIndex)
            {
                case 1:
                    crbStage1.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage1.ForeColor = Color.White;
                    crbStage2.FillColor = Color.FromArgb(226, 230, 233);
                    crbStage2.ForeColor = Color.FromArgb(104, 116, 135);
                    crbStage3.FillColor = Color.FromArgb(226, 230, 233);
                    crbStage3.ForeColor = Color.FromArgb(104, 116, 135);

                    lbStage1.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage2.ForeColor = Color.FromArgb(104, 116, 135);
                    lbStage3.ForeColor = Color.FromArgb(104, 116, 135);

                    pnInputExam1.Visible = true;
                    pnInputExam2.Visible = false;
                    pnInputExam3.Visible = false;
                    break;
                case 2:
                    crbStage1.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage1.ForeColor = Color.White;
                    crbStage2.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage2.ForeColor = Color.White;
                    crbStage3.FillColor = Color.FromArgb(226, 230, 233);
                    crbStage3.ForeColor = Color.FromArgb(104, 116, 135);

                    lbStage1.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage2.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage3.ForeColor = Color.FromArgb(104, 116, 135);

                    pnInputExam2.Visible = true;
                    pnInputExam1.Visible = false;
                    pnInputExam3.Visible = false;

                    if (_flagImportQuestion == false)
                    {
                        LoadUserControlAddQuestion();
                        _flagImportQuestion = true;
                    }
                    break;
                case 3:
                    crbStage1.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage1.ForeColor = Color.White;
                    crbStage2.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage2.ForeColor = Color.White;
                    crbStage3.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage3.ForeColor = Color.White;

                    lbStage1.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage2.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage3.ForeColor = Color.FromArgb(94, 148, 255);

                    pnInputExam3.Visible = true;
                    pnInputExam2.Visible = false;
                    pnInputExam1.Visible = false;
                    LoadPreviewExamForStage3();
                    break;
                default:
                    break;
            }
        }

        private void crbStage2_Click(object sender, EventArgs e)
        {
            LoadStage(2);
        }

        private void crbStage3_Click(object sender, EventArgs e)
        {
            LoadStage(3);
        }

        private void UcAddExam_Load(object sender, EventArgs e)
        {
            cbExamType.SelectedIndex = 0;
            cbTimeType.SelectedIndex = 0;
            RegisterTextBoxEvents();
            LoadStage(1);
            LoadSchoolToCombobox();

        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            LoadUserControlAddQuestion();
        }

        private void btnNextStage_Click(object sender, EventArgs e)
        {
            if (_stageAddExam < 3)
            {
                _stageAddExam++;
                LoadStage(_stageAddExam);
            }
        }

        private void btnBackStage_Click(object sender, EventArgs e)
        {
            if (_stageAddExam > 1)
            {
                _stageAddExam--;
                LoadStage(_stageAddExam);
            }
        }
        private void LoadPreviewExamForStage3()
        {
            lbNameExam.Text = txtExamName.Text;
            lbSubject.Text = cbSubject.Text;
            lbClass.Text = cbClass.Text;
            lbSchool.Text = cbSchool.Text;
            lbTypeExam.Text = cbExamType.Text;
            lbTimeExam.Text = txtExamTime.Text;
            lbTotalQuestion.Text = flpQuestion.Controls.Count.ToString();
            lbTotalQuestion2.Text = flpQuestion.Controls.Count.ToString();
            lbTotalScore.Text = GetTotalScoreQuestion().ToString();
            lbTotalOptionsQuestion.Text = _totalOptionsQuestion.ToString();
        }
        private void btnSaveExam_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddExam())
                {
                    MessageBox.Show("Thêm đề thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BackToUcExam?.Invoke();
                    return;
                }
                return;
            }
            catch
            {
                return;
            }
            
        }

        private bool AddExam()
        {
            try
            {
                //Get value 
                ExamDTO newExam = GetExam();
                if (newExam == null)
                {
                    MessageBox.Show("Lấy thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                List<QuestionAndOption> listQuestion = GetAllQuestionAndOption();
                if (listQuestion == null)
                {
                    MessageBox.Show("Lấy danh sách câu hỏi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                //Add exam
                if (!_examBLL.AddExam(newExam))
                {
                    MessageBox.Show("Thêm đề thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else
                {
                    //Add question
                    newExam = _examBLL.GetExamByValue(newExam.Name, newExam.Type, newExam.CourseId, newExam.SemesterId, newExam.Year);
                    if (newExam == null)
                    {
                        MessageBox.Show("Đề thi không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    foreach (QuestionAndOption itemQuestion in listQuestion)
                    {
                        QuestionDTO newQuestion = new QuestionDTO
                        {
                            Type = itemQuestion.TypeQuestion,
                            Content = itemQuestion.ContentQuetion,
                            Score = itemQuestion.ScoreQuetion,
                            ExamId = newExam.Id
                        };
                        if (!_questionBLL.AddQuestion(newQuestion))
                        {
                            MessageBox.Show("Thêm câu hỏi cho đề thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        newQuestion = _questionBLL.GetQuestionByExamIdAndContent(newExam.Id, newQuestion.Content);
                        if (newQuestion == null)
                        {
                            MessageBox.Show("Câu hỏi không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                        foreach (QuestionOptionDTO optionInQuestion in itemQuestion.Options)
                        {
                            optionInQuestion.QuestionId = newQuestion.Id;
                            if (!_questionOptionBLL.InsertQuestionOption(optionInQuestion))
                            {
                                MessageBox.Show("Thêm lựa chọn cho câu hỏi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                    return true;

                }

                
            }
            catch
            {
                return false;
            }
        }

        private double GetTotalScoreQuestion()
        {
            double totalScore = 0;
            foreach (UcAddQuestion ucAddQuestion in flpQuestion.Controls)
            {
                totalScore += ucAddQuestion.GetScoreQuestion();
            }
            _totalScoreQuestion = totalScore;
            return totalScore;
        }

        private void btnPreviousPage_Click(object sender, EventArgs e)
        {
            BackToUcExam?.Invoke();
        }

        private bool ContainsSpecialCharacter(string input)
        {
            return !Regex.IsMatch(input, @"^[\p{L}0-9\s]+$");
        }

        private bool IsValidExamName(string text)
        {
            return Regex.IsMatch(text, @"^[\p{L}0-9\s]+$");
        }
        private bool ValidateExamControls()
        {
            // Tên bài thi
            if (string.IsNullOrWhiteSpace(txtExamName.Text))
                return ShowError(txtExamName, "Tên bài thi không được để trống.");

            if (ContainsSpecialCharacter(txtExamName.Text))
                return ShowError(txtExamName, "Tên bài thi không được chứa ký tự đặc biệt.");

            // Môn học
            if (cbSubject.SelectedValue == null || cbSubject.SelectedIndex == -1)
                return ShowError(cbSubject, "Vui lòng chọn môn học.");

            // Hướng dẫn thi
            if (!string.IsNullOrWhiteSpace(txtExamInstruction.Text) &&
                ContainsSpecialCharacter(txtExamInstruction.Text))
                return ShowError(txtExamInstruction, "Hướng dẫn thi không được chứa ký tự đặc biệt.");

            // Mô tả
            if (!string.IsNullOrWhiteSpace(txtDescription.Text) &&
                ContainsSpecialCharacter(txtDescription.Text))
                return ShowError(txtDescription, "Mô tả không được chứa ký tự đặc biệt.");

            // Tổng số câu hỏi
            if (!int.TryParse(txtTotalQuestion.Text, out int totalQuestion) || totalQuestion <= 0)
                return ShowError(txtTotalQuestion, "Tổng số câu hỏi phải là số nguyên > 0.");

            // Học kỳ
            if (cbSemester.SelectedValue == null || cbSemester.SelectedIndex == -1)
                return ShowError(cbSemester, "Vui lòng chọn học kỳ.");

            // Thời gian
            if (string.IsNullOrWhiteSpace(txtExamTime.Text))
                return ShowError(txtExamTime, "Thời gian làm bài không được để trống.");

            if (!int.TryParse(txtExamTime.Text, out int examTime) || examTime <= 0)
                return ShowError(txtExamTime, "Thời gian làm bài phải là số nguyên > 0.");

            // Trường
            if (cbSchool.SelectedValue == null || cbSchool.SelectedIndex == -1)
                return ShowError(cbSchool, "Vui lòng chọn trường.");

            // Loại bài thi
            if (string.IsNullOrWhiteSpace(cbExamType.Text))
                return ShowError(cbExamType, "Vui lòng chọn loại bài thi.");

            // Lớp
            if (cbClass.SelectedValue == null || cbClass.SelectedIndex == -1)
                return ShowError(cbClass, "Vui lòng chọn lớp.");

            return true;
        }
        private bool ShowError(Control control, string message)
        {
            MessageBox.Show(message, "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            control.Focus();
            return false;
        }

        private void txtExamTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
        private void cbSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSchool.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                List<Control> controlCombobox = new List<Control>
                {
                    cbSemester,
                    cbFaculty,
                    cbClass,
                    cbSubject
                };
                foreach (ComboBox control in controlCombobox)
                {
                    control.DataSource = null;
                    control.Items.Clear();
                    control.Text = string.Empty;
                    control.SelectedIndex = -1;
                }

                int idSchoolSelected = -1;
                if (!int.TryParse(cbSchool.SelectedValue.ToString(), out idSchoolSelected))
                {
                    MessageBox.Show(
                        "Lấy dữ liệu trường học thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                LoadSemesterToCombobox(idSchoolSelected);
                LoadFacultyToCombobox(idSchoolSelected);
            }
            catch
            {
                MessageBox.Show(
                        "Lấy dữ liệu trường học thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
        }

        private void cbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFaculty.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                cbClass.DataSource = null;
                cbClass.Items.Clear();
                cbClass.Text = string.Empty;
                cbClass.SelectedIndex = -1;
                int idFaculty = -1;
                if (!int.TryParse(cbFaculty.SelectedValue.ToString(), out idFaculty))
                {
                    MessageBox.Show(
                        "Lấy dữ liệu khoa thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                LoadClassToCombobox(idFaculty);
            }
            catch
            {
                MessageBox.Show(
                        "Lấy dữ liệu khoa thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
        }

        private void cbSemester_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbSemester.SelectedIndex == -1)
            {
                return;
            }
            try
            {
                cbSubject.DataSource = null;
                cbSubject.Items.Clear();
                cbSubject.Text = string.Empty;
                cbSubject.SelectedIndex = -1;
                int semesterId = -1;
                if (!int.TryParse(cbSemester.SelectedValue.ToString(), out semesterId))
                {
                    MessageBox.Show(
                        "Lấy dữ liệu trường học thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                LoadCourseToCombobox(semesterId);
            }
            catch
            {
                MessageBox.Show(
                        "Lấy dữ liệu học kỳ thất bại!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                return;
            }
        }


        private void TextBox_BlockSpecialChar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void TextBox_BlockSpecialChar_Paste_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.V)
            {
                string clipboardText = Clipboard.GetText();

                if (ContainsSpecialCharacter(clipboardText))
                {
                    MessageBox.Show(
                        "Không được dán ký tự đặc biệt!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    e.SuppressKeyPress = true;
                }
            }
        }
        private void TextBox_BlockSpecialChar_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == null || string.IsNullOrEmpty(tb.Text)) return;

            if (ContainsSpecialCharacter(tb.Text))
            {
                MessageBox.Show(
                    "Nội dung không được chứa ký tự đặc biệt!",
                    "Thông báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                tb.Text = Regex.Replace(tb.Text, @"[^\p{L}0-9\s]", "");
                tb.SelectionStart = tb.Text.Length;
            }
        }

        private void RegisterTextBoxEvents()
        {
            Guna2TextBox[] textBoxes =
                                {
                            txtExamName,
                            txtExamInstruction,
                            txtDescription
                        };

            foreach (var tb in textBoxes)
            {
                tb.KeyPress += TextBox_BlockSpecialChar_KeyPress;
                tb.KeyDown += TextBox_BlockSpecialChar_Paste_KeyDown;
                tb.TextChanged += TextBox_BlockSpecialChar_TextChanged;
            }
        }

        private void NumericTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
                return;

            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void NumericTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            Guna2TextBox tb = sender as Guna2TextBox;
            if (e.Control && e.KeyCode == Keys.V)
            {
                if (Clipboard.ContainsText())
                {
                    string text = Clipboard.GetText();
                    if (!text.All(char.IsDigit))
                    {
                        MessageBox.Show(
                            "Chỉ được nhập số.",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        tb.Text = string.Empty;
                        tb.Focus();
                        e.SuppressKeyPress = true;
                    }
                }
            }
        }

        private void NumericTextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb == null || string.IsNullOrEmpty(tb.Text))
                return;

            string digitsOnly = new string(tb.Text.Where(char.IsDigit).ToArray());

            if (tb.Text != digitsOnly)
            {
                tb.Text = digitsOnly;
                tb.SelectionStart = tb.Text.Length;
            }
        }

    }
}
