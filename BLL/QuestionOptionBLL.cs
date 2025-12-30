using System;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuestionOptionBLL
    {
        public QuestionOptionDAL _questionOptionDAL = new QuestionOptionDAL();

        public List<QuestionOptionDTO> GetQuestionOptionByIdQuestion(int questionId)
        {
            return _questionOptionDAL.GetQuestionOptionByIdQuestion(questionId);
        }
        public bool InsertQuestionOption(QuestionOptionDTO questionOption)
        {
            return _questionOptionDAL.InsertQuestionOption(questionOption);
        }

        public List<QuestionOptionDTO> GetAllQuestionOptionByQuestionId(int questionId)
        {
            return _questionOptionDAL.GetAllQuestionOptionByQuestionId(questionId);
        }
    }
}
