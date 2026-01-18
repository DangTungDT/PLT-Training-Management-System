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
        AppDBContext _context = new AppDBContext();

        public bool UpdateExam(ExamDTO newExam)
        {
            try
            {
                ExamDTO oldExam = _context.Exams.FirstOrDefault(x => x.Id == newExam.Id);
                if (oldExam == null) return false;

                oldExam.Name = newExam.Name;
                oldExam.Type = newExam.Type;
                oldExam.Duration = newExam.Duration;
                oldExam.ExamInstruction = newExam.ExamInstruction;
                oldExam.Description = newExam.Description;
                oldExam.Year = newExam.Year;
                oldExam.Status = newExam.Status;
                oldExam.CourseId = newExam.CourseId;
                oldExam.SemesterId = newExam.SemesterId;
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public ExamDTO GetExamById(int idExamSelected)
        {
            try
            {
                ExamDTO examSelected = _context.Exams.FirstOrDefault(x => x.Id == idExamSelected);
                return examSelected;
            }
            catch
            {
                return null;
            }
        }

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

        /// <summary>
        /// Xóa exam và các bản ghi liên quan theo thứ tự:
        ///  - Exam_File (ExamFile) với ExamId = id
        ///  - ClassExam (ClassExams) với ExamId = id
        ///  - QuestionOption (QuestionOptions) của các Question có ExamId = id
        ///  - Question (Questions) có ExamId = id
        ///  - Exam (Exams) có Id = id
        /// Trả về true nếu xóa thành công, false nếu có lỗi hoặc không tìm thấy exam.
        /// </summary>
        public bool DeleteById(int id)
        {
            try
            {
                using (var context = new AppDBContext())
                {
                    using (var transaction = context.Database.BeginTransaction())
                    {
                        try
                        {
                            // find exam
                            var exam = context.Exams.FirstOrDefault(e => e.Id == id);
                            if (exam == null)
                                return false;

                            // 0) Delete Exam_File (ExamFile) entries referencing this exam
                            // use Set<ExamFileDTO>() in case DbSet property name differs
                            var examFiles = context.Set<ExamFileDTO>().Where(ef => ef.ExamId == id).ToList();
                            if (examFiles.Any())
                            {
                                context.Set<ExamFileDTO>().RemoveRange(examFiles);
                                context.SaveChanges();
                            }

                            // 1) Delete ClassExam entries referencing this exam
                            var classExams = context.Set<ClassExamDTO>().Where(ce => ce.ExamId == id).ToList();
                            if (classExams.Any())
                            {
                                context.Set<ClassExamDTO>().RemoveRange(classExams);
                                context.SaveChanges();
                            }

                            // 2) Delete QuestionOption entries for questions of this exam
                            var questions = context.Questions.Where(q => q.ExamId == id).ToList();
                            if (questions.Any())
                            {
                                var questionIds = questions.Select(q => q.Id).ToList();
                                var options = context.Set<QuestionOptionDTO>().Where(o => questionIds.Contains(o.QuestionId)).ToList();
                                if (options.Any())
                                {
                                    context.Set<QuestionOptionDTO>().RemoveRange(options);
                                    context.SaveChanges();
                                }

                                // 3) Delete Questions
                                context.Questions.RemoveRange(questions);
                                context.SaveChanges();
                            }

                            // 4) Finally delete exam
                            context.Exams.Remove(exam);
                            context.SaveChanges();

                            transaction.Commit();
                            return true;
                        }
                        catch
                        {
                            transaction.Rollback();
                            return false;
                        }
                    }
                }
            }
            catch
            {
                return false;
            }
        }
    }
}