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
using GUI.Helpers;

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

        public QuestionAndOption GetQuestionAndAllOptionQuestion()
        {
            try
            {
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
                    return null;
                }
                
                int sortOrder = 1;
                foreach (var option in controlInput)
                {
                    QuestionOptionDTO newOption = new QuestionOptionDTO()
                    {
                        Content = option.Text,
                        IsCorrect = false,
                        SortOrder = sortOrder
                    };
                    newQuestionOption.Add(newOption);
                    sortOrder++;
                }
                switch (checkedOption.ToLower())
                {
                    case "a":
                        if (string.IsNullOrEmpty(newQuestionOption[0].Content))
                        {
                            MessageBox.Show($"Vui lòng chọn câu trả lời đúng là câu có dữ liệu cho câu hỏi {_numberQuestionForExam}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                        newQuestionOption[0].IsCorrect = true;
                        break;
                    case "b":
                        if (string.IsNullOrEmpty(newQuestionOption[1].Content))
                        {
                            MessageBox.Show($"Vui lòng chọn câu trả lời đúng là câu có dữ liệu cho câu hỏi {_numberQuestionForExam}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                        newQuestionOption[1].IsCorrect = true;
                        break;
                    case "c":
                        if (string.IsNullOrEmpty(newQuestionOption[2].Content))
                        {
                            MessageBox.Show($"Vui lòng chọn câu trả lời đúng là câu có dữ liệu cho câu hỏi {_numberQuestionForExam}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                        newQuestionOption[2].IsCorrect = true;
                        break;
                    case "d":
                        if (string.IsNullOrEmpty(newQuestionOption[3].Content))
                        {
                            MessageBox.Show($"Vui lòng chọn câu trả lời đúng là câu có dữ liệu cho câu hỏi {_numberQuestionForExam}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return null;
                        }
                        newQuestionOption[3].IsCorrect = true;
                        break;

                }
                decimal scoreQuestion = 0;
                if(!decimal.TryParse(txtScoreQuestion.Text, out scoreQuestion))
                {
                    MessageBox.Show($"Vui lòng nhập số điểm hợp lệ cho câu hỏi {_numberQuestionForExam}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return null;
                }
                QuestionAndOption newQuestionAndOption = new QuestionAndOption
                {
                    TypeQuestion = cbTypeQuestion.Text,
                    ContentQuetion = txtContentQuestion.Text,
                    ScoreQuetion = scoreQuestion,
                    Options = newQuestionOption
                };
                return newQuestionAndOption;
            }
            catch
            {
                return null;
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
