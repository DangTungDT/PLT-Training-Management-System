using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LessonPlanDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public string Objective { get; set; }
        public string Material { get; set; }
        public int CourseId { get; set; }
        public CourseDTO Course { get; set; }
        public int StudentClassId { get; set; }
        public ClassDTO Class { get; set; }
        public int RoomId { get; set; }
        public RoomDTO Room { get; set; }
        public ICollection<LessonActivityDTO> LessonActivities { get; set; }
        public ICollection<LessonScheduleDTO> LessonSchedules { get; set; }
    }
}
