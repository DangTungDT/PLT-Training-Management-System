using DAL.databaseContext;
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
        public bool AddExam(ExamDTO newExam)
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    context.Exams.Add(newExam);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public ExamDTO GetExamByValue(string name, string type, int courseId, int semesterId, int year)
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    return context.Exams.FirstOrDefault(x => x.Name == name && x.Type == type && x.CourseId == courseId && x.SemesterId == semesterId && x.Year == year);

                }
            }
            catch
            {
                return null;
            }
        }
        public List<int> GetAllYearForExam()
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Exams
                        .Select(e => e.Year)
                        .Distinct()
                        .OrderBy(year => year)
                        .ToList();
                }
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<ExamOverviewDTO> GetAllExamsOverview()
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    return context.Exams
                        .Include(e => e.Course)
                            .ThenInclude(c => c.CourseClasses)
                                .ThenInclude(cc => cc.Class)
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
                            ClassName = string.Join(", ",
                                e.Course.CourseClasses
                                    .Select(cc => cc.Class.Name)
                                    .OrderBy(name => name)
                                    .Distinct()),
                            QuestionCount = context.Questions.Count(q => q.ExamId == e.Id)
                        })
                        .OrderBy(e => e.ExamId)
                        .ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public IEnumerable<ExamOverviewDTO> GetExamsOverviewByYear(int year)
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    return context.Exams
                        .Where(e => e.Year == year)

                        .Include(e => e.Course)
                            .ThenInclude(c => c.CourseClasses)
                                .ThenInclude(cc => cc.Class)

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

                            ClassName = string.Join(", ",
                                e.Course.CourseClasses
                                    .Select(cc => cc.Class.Name)
                                    .OrderBy(name => name)
                                    .Distinct()),

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


        public IEnumerable<ExamOverviewDTO> GetExamsOverviewFilter(int courseId, int schoolId, int year)
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    var query = context.Exams.AsQueryable();

                    if (year > 0)
                    {
                        query = query.Where(e => e.Year == year);
                    }

                    if (courseId > 0)
                    {
                        query = query.Where(e => e.CourseId == courseId);
                    }

                    if (schoolId > 0)
                    {
                        query = query.Where(e => e.Course.Semester.School.Id == schoolId);
                    }

                    return query
                        .Include(e => e.Course)
                            .ThenInclude(c => c.CourseClasses)
                                .ThenInclude(cc => cc.Class)
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

                            ClassName = string.Join(", ",
                                e.Course.CourseClasses
                                    .Select(cc => cc.Class.Name)
                                    .OrderBy(name => name)
                                    .Distinct()),

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
