using DAL.databaseContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class LessonScheduleDAL
    {
        private readonly AppDBContext _context = new AppDBContext();
        public List<LessonScheduleDTO> GetAll()
        {
            try
            {
                return _context.LessonSchedules
                    .Select(ls => new LessonScheduleDTO
                    {
                        Id = ls.Id,
                        LessonPlanId = ls.LessonPlanId,
                        DayOfWeek = ls.DayOfWeek,
                        StartTime = ls.StartTime,
                        EndTime = ls.EndTime,
                        RoomId = ls.RoomId
                    })
                    .ToList();
            }
            catch
            {
                return new List<LessonScheduleDTO>();
            }
        }

        /// <summary>
        /// Lấy tất cả LessonSchedule theo LessonPlanId
        /// </summary>
        public List<LessonScheduleDTO> GetByLessonPlanId(int lessonPlanId)
        {
            try
            {
                return _context.LessonSchedules
                    .Where(ls => ls.LessonPlanId == lessonPlanId)
                    .ToList();
            }
            catch
            {
                return new List<LessonScheduleDTO>();
            }
        }

        /// <summary>
        /// Lấy tất cả LessonSchedule theo LessonPlanId và DayOfWeek (dayOfWeek: mapping as stored in DB)
        /// </summary>
        public List<LessonScheduleDTO> GetByLessonPlanIdAndDayOfWeek(int lessonPlanId, int dayOfWeek)
        {
            try
            {
                return _context.LessonSchedules
                    .Where(ls => ls.LessonPlanId == lessonPlanId && ls.DayOfWeek == dayOfWeek)
                    .Select(ls => new LessonScheduleDTO
                    {
                        Id = ls.Id,
                        LessonPlanId = ls.LessonPlanId,
                        DayOfWeek = ls.DayOfWeek,
                        StartTime = ls.StartTime,
                        EndTime = ls.EndTime,
                        RoomId = ls.RoomId
                    })
                    .ToList();
            }
            catch
            {
                return new List<LessonScheduleDTO>();
            }
        }
    }
}
