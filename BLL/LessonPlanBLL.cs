using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
namespace BLL
{
    public class LessonPlanBLL
    {
        private LessonPlanDAL _dal = new LessonPlanDAL();

        public List<LessonPlanDTO> GetAllBySemesterAndWeek(int semesterId, DateTime dateInWeek)
        {
            return _dal.GetAllBySemesterAndWeek(semesterId, dateInWeek);
        }
        public List<LessonPlanDTO> GetAllBySemesterId(int semesterId)
        {
            return _dal.GetAllBySemesterId(semesterId);
        }
    }
}
