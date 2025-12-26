using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuestionBLL
    {
        private QuestionDAL _questionDAL = new QuestionDAL();

        public bool AddQuestion(QuestionDTO newQuestion)
        {
            return _questionDAL.AddQuestion(newQuestion);
        }
        public QuestionDTO FindQuestionByValue(QuestionDTO questionDTO)
        {
            return _questionDAL.FindQuestionByValue(questionDTO);
        }
        public QuestionDTO GetQuestionByExamIdAndContent(int examId, string contentQuestion)
        {
            return _questionDAL.GetQuestionByExamIdAndContent(examId, contentQuestion);
        }
    }
}
