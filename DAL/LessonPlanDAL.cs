using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.databaseContext;
namespace DAL
{
    public class LessonPlanDAL
    {
        private readonly AppDBContext _context = new AppDBContext();

        public List<LessonPlanDTO> GetAllBySemesterAndWeek(int semesterId, DateTime dateInWeek)
        {
            try
            {
                // determine week boundaries (Monday..Sunday)
                int offsetToMonday = ((int)dateInWeek.DayOfWeek - (int)DayOfWeek.Monday + 7) % 7;
                DateTime weekStart = dateInWeek.Date.AddDays(-offsetToMonday);
                DateTime weekEnd = weekStart.AddDays(6);

                // join LessonPlans -> Courses to filter by Course.SemesterId,
                // and select lesson plans whose date range overlaps the week
                List<LessonPlanDTO> query = (from lp in _context.LessonPlans
                            join c in _context.Courses on lp.CourseId equals c.Id
                            where c.SemesterId == semesterId
                            && lp.StartDate.Value.Date <= weekEnd.Date
                            && lp.EndDate.Value.Date >= weekStart.Date
                                             select lp).ToList();

                return query;
            }
            catch
            {
                return new List<LessonPlanDTO>();
            }
        }

        /// <summary>
        /// Lấy tất cả LessonPlan theo SemesterId (qua Course.SemesterId)
        /// </summary>
        public List<LessonPlanDTO> GetAllBySemesterId(int semesterId)
        {
            try
            {
                // Join LessonPlans -> Courses to filter by Course.SemesterId so we don't rely on navigation props
                var query = from lp in _context.LessonPlans
                            join c in _context.Courses on lp.CourseId equals c.Id
                            where c.SemesterId == semesterId
                            select lp;

                return query.ToList();
            }
            catch
            {
                return new List<LessonPlanDTO>();
            }
        }
    }
}
