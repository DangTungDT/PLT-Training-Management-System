using DTO;
using BLL;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls.Question
{
    public partial class UcAddQuestion : UserControl
    {
        private QuestionDTO _newQuestion;
        private QuestionBLL _questionBLL = new QuestionBLL();
        private ExamBLL _examBLL = new ExamBLL();
        private ExamDTO _newExam = null;
        private QuestionOptionBLL _questionOptionBLL = new QuestionOptionBLL();
        private int _numberQuestionForExam = 0;
        private int _totalQuestionForExam = 0;
        public UcAddQuestion()
        {
            InitializeComponent();
        }

        public int GetNumberQuestion()
        {
            return _numberQuestionForExam;
        }
        public void SetNumberQuestion(int number)
        {
            _numberQuestionForExam = number;
            lbNumberQuestion.Text = "Câu " + number.ToString();
        }

        private QuestionDTO GetQuestion()
        {
            try
            {
                string examType = "";
                decimal examScore = 0;
                if (cbTypeQuestion.Text.ToLower() == "trắc nghiệm")
                {
                    examType = "MultipleChoice";
                }
                else
                {
                    examType = "Essay";
                }
                string examContent = txtContentQuestion.Text;
                try
                {
                    examScore = decimal.Parse(txtScoreQuestion.Text);
                }
                catch
                {
                    MessageBox.Show("Vui lòng nhập điểm câu hỏi hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }
                    QuestionDTO newQuestion = new QuestionDTO
                    {
                        Type = examType,
                        Content = examContent,
                        Score = examScore,
                        ExamId = _newExam.Id
                    };
                return newQuestion;
            }
            catch
            {
                return null;
            }
        }

        private QuestionDTO AddNewQuestion()
        {
            try
            {
                //Add new question to database
                QuestionDTO newQuestion = GetQuestion();
                if (newQuestion == null) return null;
                if (!_questionBLL.AddQuestion(newQuestion)) return null;

                //Find added question
                newQuestion = _questionBLL.FindQuestionByValue(newQuestion);
                if (newQuestion == null) return null;

                return newQuestion;
            }
            catch
            {
                return null;
            }
        }

        public bool AddQuestionBeforeAddAllQuestionOption(ExamDTO newExam)
        {
            try
            {
                _newExam = newExam;
                string checkedOption = GetCheckedOption();
                List<Guna2TextBox> controlInput = new List<Guna2TextBox>()
                {
                    txtOptionA,
                    txtOptionB,
                    txtOptionC,
                    txtOptionD
                };
                List<QuestionOptionDTO> newQuestionOption = new List<QuestionOptionDTO>();
                if (string.IsNullOrEmpty(checkedOption))
                {
                    MessageBox.Show("Vui lòng chọn câu đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                //Add new question to database
                ExamDTO examOfQuestion = _examBLL.GetExamByValue(_newExam.Name, _newExam.Type, _newExam.CourseId, _newExam.SemesterId, _newExam.Year);
                _newQuestion = AddNewQuestion();
                if (_newQuestion == null) return false;

                //Add all questionOption to database
                int sortOrder = 1;
                foreach (var option in controlInput)
                {
                    QuestionOptionDTO newOption = new QuestionOptionDTO()
                    {
                        Content = option.Text,
                        IsCorrect = false,
                        SortOrder = sortOrder,
                        QuestionId = _newQuestion.Id
                    };
                    newQuestionOption.Add(newOption);
                    sortOrder++;
                }
                switch (checkedOption.ToLower())
                {
                    case "a":
                        if (string.IsNullOrEmpty(newQuestionOption[0].Content))
                        {
                            MessageBox.Show("Vui lòng chọn câu trả lời đúng là câu có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        newQuestionOption[0].IsCorrect = true;
                        break;
                    case "b":
                        if (string.IsNullOrEmpty(newQuestionOption[1].Content))
                        {
                            MessageBox.Show("Vui lòng chọn câu trả lời đúng là câu có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        newQuestionOption[1].IsCorrect = true;
                        break;
                    case "c":
                        if (string.IsNullOrEmpty(newQuestionOption[2].Content))
                        {
                            MessageBox.Show("Vui lòng chọn câu trả lời đúng là câu có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        newQuestionOption[2].IsCorrect = true;
                        break;
                    case "d":
                        if (string.IsNullOrEmpty(newQuestionOption[3].Content))
                        {
                            MessageBox.Show("Vui lòng chọn câu trả lời đúng là câu có dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }
                        newQuestionOption[3].IsCorrect = true;
                        break;

                }
                foreach (QuestionOptionDTO item in newQuestionOption)
                {
                    if (!_questionOptionBLL.InsertQuestionOption(item)) return false;
                }
                newQuestionOption = _questionOptionBLL.GetAllQuestionOptionByQuestionId(_newQuestion.Id);
                if (newQuestionOption == null) return false;

                return true;
            }
            catch
            {
                return false;
            }
        }
        private string GetCheckedOption()
        {
            if(radA.Checked) return "A";
            if (radB.Checked) return "B";
            if(radC.Checked) return "C";
            if(radD.Checked) return "D";
            return "";
        }
        public double GetScoreQuestion()
        {
            try
            {
                return Convert.ToDouble(txtScoreQuestion.Text);
            }
            catch
            {
                return 0;
            }
        }
    }
}
