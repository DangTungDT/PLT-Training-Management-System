using DTO;
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

namespace GUI.UserControls.File
{
    public partial class ucserTest2 : UserControl
    {
        List<QuestionDTO> _questionInport = new List<QuestionDTO>();
        List<QuestionOptionDTO> _questionOptionInport = new List<QuestionOptionDTO>();
        public ucserTest2()
        {
            InitializeComponent();
        }

        private void LoadQuestionDefault()
        {
            UcAddQuestion ucAddQuestion = new UcAddQuestion();
            ucAddQuestion.Dock = DockStyle.Fill;
            flpQuestion.Controls.Clear();
            flpQuestion.Controls.Add(ucAddQuestion);
        }
    }
}
