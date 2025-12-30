using System;
using DTO;
using DAL.databaseContext;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuestionOptionDAL
    {
        AppDBContext _context = new AppDBContext();
        public List<QuestionOptionDTO> GetQuestionOptionByIdQuestion(int questionId)
        {
            try
            {
                List<QuestionOptionDTO> questionOptions = _context.QuestionOptions.Where(x=> x.QuestionId == questionId).ToList();
                return questionOptions;
            }
            catch
            {
                return null;
            }
        }
        public List<QuestionOptionDTO> GetAllQuestionOptionByQuestionId(int questionId)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.QuestionOptions
                        .Where(qo => qo.QuestionId == questionId)
                        .Select(qo => new QuestionOptionDTO
                        {
                            Id = qo.Id,
                            QuestionId = qo.QuestionId,
                            Content = qo.Content,
                            IsCorrect = qo.IsCorrect
                        })
                        .ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public bool InsertQuestionOption(QuestionOptionDTO questionOption)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    QuestionOptionDTO itemOld = context.QuestionOptions.FirstOrDefault(qo => qo.Id == questionOption.Id && qo.Content == questionOption.Content);
                    if(itemOld != null) return false;
                    context.QuestionOptions.Add(questionOption);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
