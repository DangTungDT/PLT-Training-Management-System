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
