using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class LessonScheduleBLL
    {
        private LessonScheduleDAL _dal = new LessonScheduleDAL();
        public List<LessonScheduleDTO> GetAll()
        {
            return _dal.GetAll();
        }

        public List<LessonScheduleDTO> GetByLessonPlanId(int lessonPlanId)
        {
            return _dal.GetByLessonPlanId(lessonPlanId);
        }

        public List<LessonScheduleDTO> GetByLessonPlanIdAndDayOfWeek(int lessonPlanId, int dayOfWeek)
        {
            return _dal.GetByLessonPlanIdAndDayOfWeek(lessonPlanId, dayOfWeek);
        }
    }
}
