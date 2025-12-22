using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExamDAL
    {
        public IEnumerable<ExamOverviewDTO> GetAllExamsOverview()
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Exams
                        .Include(e => e.Course)
                            .ThenInclude(c => c.Semester)
                                .ThenInclude(s => s.School)
                        .Select(e => new ExamOverviewDTO
                        {
                            ExamId = e.Id,
                            ExamName = e.Name,
                            CourseName = e.Course.FullName,
                            SchoolName = e.Course.Semester.School.Name,
                            ExamType = e.Type,
                            Duration = e.Duration,
                            Status = e.Status,
                            QuestionCount = context.Questions.Count(q => q.ExamId == e.Id)
                        })
                        .OrderBy(e => e.ExamId)
                        .ToList();
                }
            }
            catch
            {
                return null;
            }
        }

    }
}
