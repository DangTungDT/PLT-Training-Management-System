using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.databaseContext;
namespace DAL
{
    public class QuestionDAL
    {
        AppDBContext _dbContext = new AppDBContext();

        public QuestionDTO FindQuestionByValue(QuestionDTO questionDTO)
        {
            try
            {
                QuestionDTO question = _dbContext.Questions.FirstOrDefault(x=> x.Type ==  questionDTO.Type && x.Content == questionDTO.Content && x.ExamId == questionDTO.ExamId);
                if (question == null) return null;
                return question;
            }
            catch
            {
                return null;
            }
        }
        public bool AddQuestion(QuestionDTO newQuestion)
        {
            try
            {
                _dbContext.Questions.Add(newQuestion);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public QuestionDTO GetQuestionByExamIdAndContent(int examId, string contentQuestion)
        {
            try
            {
               return _dbContext.Questions.FirstOrDefault(x=> x.ExamId == examId && x.Content == contentQuestion);
            }
            catch
            {
                return null;
            }
        }
        public List<QuestionDTO> GetAllQuestion()
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Questions.ToList();
                }
            }
            catch
            {
                return new List<QuestionDTO> ();
            }
        }
    }
}
