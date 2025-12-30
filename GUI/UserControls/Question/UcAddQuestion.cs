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
        private QuestionDTO _questionSelected = null;
        private QuestionBLL _questionBLL = new QuestionBLL();
        private ExamBLL _examBLL = new ExamBLL();
        private ExamDTO _newExam = null;
        private QuestionOptionBLL _questionOptionBLL = new QuestionOptionBLL();
        private int _numberQuestionForExam = 0;
        private int _totalQuestionForExam = 0;
        private List<QuestionOptionDTO> _listOption;
        public UcAddQuestion()
        {
            InitializeComponent();
        }

        public UcAddQuestion(QuestionDTO questionSlelected)
        {
            InitializeComponent();
            _questionSelected = questionSlelected;
        }


        private void UcAddQuestion_Load(object sender, EventArgs e)
        {
            try
            {
                if (_questionSelected == null)
                {
                    cbTypeQuestion.Text = "Trắc nghiệm";
                    LoadOptionForMultipleQuestion(true);
                }
                else
                {
                    List<QuestionOptionDTO> questionOptions = _questionOptionBLL.GetQuestionOptionByIdQuestion(_questionSelected.Id);
                    _listOption = questionOptions;
                    if (questionOptions.Count == 1)
                    {
                        cbTypeQuestion.Text = "Tự luận";
                        LoadOptionForMultipleQuestion(false);
                        txtResult.Text = questionOptions[0].Content;

                    }
                    else
                    {
                        cbTypeQuestion.Text = "Trắc nghiệm";
                        LoadOptionForMultipleQuestion(true);
                        foreach (QuestionOptionDTO option in questionOptions)
                        {
                            switch (option.SortOrder)
                            {
                                case 1:
                                    txtOptionA.Text = option.Content;
                                    if (option.IsCorrect)
                                    {
                                        radA.Checked = true;
                                    }
                                    break;
                                case 2:
                                    txtOptionB.Text = option.Content;
                                    if (option.IsCorrect)
                                    {
                                        radB.Checked = true;
                                    }
                                    break;
                                case 3:
                                    txtOptionC.Text = option.Content;
                                    if (option.IsCorrect)
                                    {
                                        radC.Checked = true;
                                    }
                                    break;
                                case 4:
                                    txtOptionD.Text = option.Content;
                                    if (option.IsCorrect)
                                    {
                                        radD.Checked = true;
                                    }
                                    break;
                            }
                        }
                    }
                    txtScoreQuestion.Text = _questionSelected.Score.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Load form thất bại do không có dữ liệu", "TLỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public int GetNumberQuestion()
        {
            return _numberQuestionForExam;
        }

        public int GetTypeMultipleQuestion()
        {
            if (cbTypeQuestion.Text.ToLower() == "trắc nghiệm")
            {
                return 1;
            }
            return 0;
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
                if(cbTypeQuestion.Text == "Trắc nghiệm")
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
                    if (!decimal.TryParse(txtScoreQuestion.Text, out scoreQuestion))
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
                else
                {
                    List<QuestionOptionDTO> optionForEesayQuestions =  new List<QuestionOptionDTO>
                    {
                        new QuestionOptionDTO{Content = txtResult.Text, IsCorrect = true, SortOrder = 1}
                    };
                    decimal scoreQuestion = 0;
                    if (!decimal.TryParse(txtScoreQuestion.Text, out scoreQuestion))
                    {
                        MessageBox.Show($"Vui lòng nhập số điểm hợp lệ cho câu hỏi {_numberQuestionForExam}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return null;
                    }
                    QuestionAndOption newQuestionAndOption = new QuestionAndOption
                    {
                        TypeQuestion = cbTypeQuestion.Text,
                        ContentQuetion = txtContentQuestion.Text,
                        ScoreQuetion = scoreQuestion,
                        Options = optionForEesayQuestions
                    };

                    return newQuestionAndOption;

                }
            }
            catch
            {
                return null;
            }
        }
        private string GetCheckedOption()
        {
            if (radA.Checked) return "A";
            if (radB.Checked) return "B";
            if (radC.Checked) return "C";
            if (radD.Checked) return "D";
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

        private void LoadOptionForMultipleQuestion(bool itIsMultipleQuestion)
        {
            if (!itIsMultipleQuestion)
            {
                label4.Visible = false;
                lbOptionMultipleQuestion.Visible = false;
                tlpOptionForMultipleQuestion.Visible = false;

                pnEesayQuestion.Visible = true;

            }
            else
            {
                label4.Visible = true;
                lbOptionMultipleQuestion.Visible = true;
                tlpOptionForMultipleQuestion.Visible = true;

                pnEesayQuestion.Visible = false;
            }
        }
        private void cbTypeQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbTypeQuestion.Text != "Trắc nghiệm")
            {
                LoadOptionForMultipleQuestion(false);
            }
            else
            {
                LoadOptionForMultipleQuestion(true);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
