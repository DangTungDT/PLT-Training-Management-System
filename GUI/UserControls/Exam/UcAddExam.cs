using BLL;
using DTO;
using GUI.Helpers;
using GUI.UserControls.Question;
using Guna;
using Guna.UI2.WinForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private ClassExamBLL _classExamBLL = new ClassExamBLL();
        private FileBLL _fileBLL = new FileBLL();
        private ExamFileBLL _examFileBLL = new ExamFileBLL();

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
        private void LoadClassToCheckedListBox(int facultyId)
        {
            try
            {
                //Clear item for control 
                clbClass.DataSource = null;
                clbClass.Items.Clear();

                //Get new value
                List<ClassDTO> classes = _classBLL.GetAllByFacultyId(facultyId);
                clbClass.DisplayMember = "Name";

                foreach (ClassDTO itemClass in classes)
                {
                    clbClass.Items.Add(itemClass, false);
                }

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
                cbSemester.SelectedIndex = 1;
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

        private void GetTotalNumberOfMultipleQuestion()
        {
            int totalMultipleQuestion = 0;
            foreach (UcAddQuestion ucAddQuestion in flpQuestion.Controls)
            {
                totalMultipleQuestion = totalMultipleQuestion + ucAddQuestion.GetTypeMultipleQuestion();
            }
            lbTotalOptionsQuestion.Text = totalMultipleQuestion.ToString();
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
                    crbStage4.FillColor = Color.FromArgb(226, 230, 233);
                    crbStage4.ForeColor = Color.FromArgb(104, 116, 135);

                    lbStage1.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage2.ForeColor = Color.FromArgb(104, 116, 135);
                    lbStage3.ForeColor = Color.FromArgb(104, 116, 135);
                    lbStage4.ForeColor = Color.FromArgb(104, 116, 135);

                    pnInputExam1.Visible = true;
                    pnInputExam2.Visible = false;
                    pnInputExam3.Visible = false;
                    pnInputFileExam.Visible = false;
                    _stageAddExam = 1;
                    break;
                case 2:
                    crbStage1.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage1.ForeColor = Color.White;
                    crbStage2.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage2.ForeColor = Color.White;
                    crbStage3.FillColor = Color.FromArgb(226, 230, 233);
                    crbStage3.ForeColor = Color.FromArgb(104, 116, 135);
                    crbStage4.FillColor = Color.FromArgb(226, 230, 233);
                    crbStage4.ForeColor = Color.FromArgb(104, 116, 135);

                    lbStage1.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage2.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage3.ForeColor = Color.FromArgb(104, 116, 135);
                    lbStage4.ForeColor = Color.FromArgb(104, 116, 135);

                    pnInputExam2.Visible = true;
                    pnInputExam1.Visible = false;
                    pnInputExam3.Visible = false;
                    pnInputFileExam.Visible = false;

                    if (_flagImportQuestion == false)
                    {
                        LoadUserControlAddQuestion();
                        _flagImportQuestion = true;
                    }
                    _stageAddExam = 2;
                    break;
                case 3:
                    crbStage1.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage1.ForeColor = Color.White;
                    crbStage2.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage2.ForeColor = Color.White;
                    crbStage3.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage3.ForeColor = Color.White;
                    crbStage4.FillColor = Color.FromArgb(226, 230, 233);
                    crbStage4.ForeColor = Color.FromArgb(104, 116, 135);

                    lbStage1.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage2.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage3.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage4.ForeColor = Color.FromArgb(104, 116, 135);

                    pnInputFileExam.Visible = true;
                    pnInputExam3.Visible = false;
                    pnInputExam2.Visible = false;
                    pnInputExam1.Visible = false;
                    _stageAddExam = 3;
                    LoadPreviewExamForStage4();
                    GetTotalNumberOfMultipleQuestion();
                    break;
                case 4:
                    crbStage1.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage1.ForeColor = Color.White;
                    crbStage2.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage2.ForeColor = Color.White;
                    crbStage3.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage3.ForeColor = Color.White;
                    crbStage4.FillColor = Color.FromArgb(94, 148, 255);
                    crbStage4.ForeColor = Color.White;

                    lbStage1.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage2.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage3.ForeColor = Color.FromArgb(94, 148, 255);
                    lbStage4.ForeColor = Color.FromArgb(94, 148, 255);

                    pnInputExam3.Visible = true;
                    pnInputExam2.Visible = false;
                    pnInputExam1.Visible = false;
                    pnInputFileExam.Visible = false;
                    _stageAddExam = 4;
                    LoadPreviewExamForStage4();
                    GetTotalNumberOfMultipleQuestion();
                    break;
            }
        }

        private void UcAddExam_Load(object sender, EventArgs e)
        {
            cbExamType.SelectedIndex = 0;
            cbTimeType.SelectedIndex = 0;
            RegisterTextBoxEvents();
            LoadStage(1);
            LoadSchoolToCombobox();

        }

        private void pnUploadFile_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.None;
                return;
            }

            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length == 1 &&
                Path.GetExtension(files[0]).Equals(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "PDF files (*.pdf)|*.pdf",
                Multiselect = false,
                Title = "Chọn file PDF"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                HandleSelectedFile(ofd.FileName);
            }
        }
        private void HandleSelectedFile(string filePath)
        {
            if (!Path.GetExtension(filePath)
                .Equals(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("File không hợp lệ. Vui lòng chọn file PDF.",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            FileInfo file = new FileInfo(filePath);

            if (file.Length > 500 * 1024 * 1024)
            {
                MessageBox.Show("File vượt quá 500MB",
                                "Lỗi",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            string nameFile = file.Name;
            string capacityFile = (file.Length / (1024.0 * 1024.0)).ToString("F2") + " MB";

            string guiRootPath = Path.GetFullPath(
                Path.Combine(Application.StartupPath, @"..\..\..\")
            );
            string filesFolderPath = Path.Combine(guiRootPath, "Files");
            string destFilePath = Path.Combine(filesFolderPath, file.Name);
            dgvFileBook.Rows.Add(nameFile, destFilePath, capacityFile);
            SaveFileToProject(filePath);
        }


        private void SaveFileToProject(string filePath)
        {

            FileInfo file = new FileInfo(filePath);
            string guiRootPath = Path.GetFullPath(
                Path.Combine(Application.StartupPath, @"..\..\..\")
            );

            string filesFolderPath = Path.Combine(guiRootPath, "Files");

            if (!Directory.Exists(filesFolderPath))
            {
                Directory.CreateDirectory(filesFolderPath);
            }
            string destFilePath = Path.Combine(filesFolderPath, file.Name);

            try
            {
                if (System.IO.File.Exists(destFilePath))
                    System.IO.File.Delete(destFilePath);

                System.IO.File.Copy(file.FullName, destFilePath);
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    "Không thể ghi đè file. Hãy chắc chắn file không đang được mở.\n\n" + ex.Message,
                    "Lỗi",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void pnUploadFile_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (files.Length == 0) return;

            string filePath = files[0];

            if (!Path.GetExtension(filePath)
                .Equals(".pdf", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Chỉ cho phép tải lên file PDF",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            HandleSelectedFile(filePath);
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
        private void LoadPreviewExamForStage4()
        {
            string classNameSelected = "";
            try
            {
                foreach (var item in clbClass.CheckedItems)
                {
                    if (item is ClassDTO cls)
                    {
                        if (classNameSelected == "")
                        {
                            classNameSelected = cls.Name;
                        }
                        else
                        {
                            classNameSelected = classNameSelected + ", " + cls.Name;
                        }
                    }
                }
            }
            catch
            {
                classNameSelected = "";
            }
            lbNameExam.Text = txtExamName.Text;
            lbSubject.Text = cbSubject.Text;
            lbClass.Text = classNameSelected;
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
                    // Try thêm file, nếu thất bại thì chỉ thông báo nhưng vẫn thành công
                    if (!AddBookFile())
                    {
                        MessageBox.Show("Thêm File cho đề thi thất bại!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    MessageBox.Show("Thêm đề thi thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    BackToUcExam?.Invoke();
                    return;
                }
                else
                {
                    MessageBox.Show("Thêm đề thi thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool AddBookFile()
        {
            foreach (DataGridViewRow row in dgvFileBook.Rows)
            {
                string fileName = row.Cells[0].Value?.ToString();
                string filePath = row.Cells[1].Value?.ToString();
                int fileSize = 0;
                var match = Regex.Match(row.Cells[2].Value?.ToString(), @"([\d\.]+)\s*MB");

                if (match.Success)
                {
                    double sizeTypeDouble = double.Parse(match.Groups[1].Value) * (1024.0 * 1024.0);
                    fileSize = Convert.ToInt32(sizeTypeDouble);
                }


                if (string.IsNullOrEmpty(fileName))
                {
                    continue;
                }
                string guiRootPath = Path.GetFullPath(
                                        Path.Combine(Application.StartupPath, @"..\..\..\")
                                        );
                string filesFolderPath = Path.Combine(guiRootPath, "Files");
                string destFilePath = Path.Combine(filesFolderPath, fileName);
                FilesDTO filePDF = new FilesDTO
                {
                    FileName = fileName,
                    FilePath = destFilePath,
                    FileType = "pdf",
                    FileSize = fileSize,
                    CreatedAt = DateTime.Now
                };
                if (!_fileBLL.AddNewFile(filePDF))
                {
                    //return false;
                }
                int newFileId = _fileBLL.GetFileByFileName(fileName).Id;
                ExamFileDTO examFileDTO = new ExamFileDTO
                {
                    ExamId = _newExam.Id,
                    FileId = newFileId
                };
                if (examFileDTO.ExamId > 0 && _examFileBLL.AddNewExamFile(examFileDTO) == false) return false;
            }
            return true;
        }
        private bool AddExam()
        {
            try
            {
                //Get value 
                ExamDTO newExam = GetExam();
                if (newExam == null) return false;

                //Add exam
                if (!_examBLL.AddExam(newExam))
                {
                    MessageBox.Show("Thêm đề thi thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // Lấy exam vừa thêm
                newExam = _examBLL.GetExamByValue(newExam.Name, newExam.Type, newExam.CourseId, newExam.SemesterId, newExam.Year);
                _newExam = newExam;

                if (newExam == null)
                {
                    MessageBox.Show("Đề thi không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                // TRY thêm questions - nếu thất bại thì bỏ qua, không thông báo
                try
                {
                    List<QuestionAndOption> listQuestion = GetAllQuestionAndOption();

                    // Nếu có questions thì mới thêm
                    if (listQuestion != null && listQuestion.Count > 0)
                    {
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
                                continue; // Bỏ qua câu hỏi này, tiếp tục câu tiếp theo
                            }

                            newQuestion = _questionBLL.GetQuestionByExamIdAndContent(newExam.Id, newQuestion.Content);

                            if (newQuestion == null)
                            {
                                continue; // Bỏ qua câu hỏi này
                            }

                            foreach (QuestionOptionDTO optionInQuestion in itemQuestion.Options)
                            {
                                if (string.IsNullOrEmpty(optionInQuestion.Content) && optionInQuestion.IsCorrect == false)
                                    continue;

                                optionInQuestion.QuestionId = newQuestion.Id;
                                _questionOptionBLL.InsertQuestionOption(optionInQuestion); // Không kiểm tra kết quả
                            }
                        }
                    }
                }
                catch
                {
                    // Bỏ qua lỗi khi thêm questions, không thông báo
                }

                // Thêm Class-Exam
                int classId = 0;
                foreach (var item in clbClass.CheckedItems)
                {
                    classId = 0;
                    if (item is ClassDTO cls)
                    {
                        if (int.TryParse(cls.Id.ToString(), out classId))
                        {
                            _classExamBLL.AddClassExam(classId, _newExam.Id); // Không kiểm tra kết quả
                        }
                    }
                }

                return true;
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

            //// Tổng số câu hỏi
            //if (!int.TryParse(txtTotalQuestion.Text, out int totalQuestion) || totalQuestion <= 0)
            //    return ShowError(txtTotalQuestion, "Tổng số câu hỏi phải là số nguyên > 0.");

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
            if (clbClass.CheckedItems.Count == 0)
                return ShowError(clbClass, "Vui lòng chọn lớp.");

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
                    cbSubject
                };
                foreach (Guna2ComboBox control in controlCombobox)
                {
                    control.DataSource = null;
                    control.Items.Clear();
                    control.Text = string.Empty;
                    control.SelectedIndex = -1;
                }

                clbClass.DataSource = null;
                clbClass.Items.Clear();

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
                clbClass.DataSource = null;
                clbClass.Items.Clear();
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
                LoadClassToCheckedListBox(idFaculty);
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
            Guna2TextBox tb = sender as Guna2TextBox;
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
            Guna2TextBox tb = sender as Guna2TextBox;
            if (tb == null || string.IsNullOrEmpty(tb.Text))
                return;

            string digitsOnly = new string(tb.Text.Where(char.IsDigit).ToArray());

            if (tb.Text != digitsOnly)
            {
                tb.Text = digitsOnly;
                tb.SelectionStart = tb.Text.Length;
            }
        }

        private void cbSubject_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;

                txtExamName.Focus();
            }
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            LoadStage(1);
        }

        private void crbStage2_Click(object sender, EventArgs e)
        {
            LoadStage(2);
        }

        private void crbStage3_Click(object sender, EventArgs e)
        {
            LoadStage(3);
        }
        private void crbStage4_Click(object sender, EventArgs e)
        {
            LoadStage(4);
        }
    }
}
