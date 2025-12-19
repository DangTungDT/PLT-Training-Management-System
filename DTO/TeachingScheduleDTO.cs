using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TeachingScheduleDTO
    {
        public int Id { get; set; }
        public DateTime ScheduleDate { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
        public string Note { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string TeacherId { get; set; }
        public TeacherDTO Teacher { get; set; }
        public int CourseId { get; set; }
        public CourseDTO Course { get; set; }
        public int? ClassId { get; set; }
        public ClassDTO Class { get; set; }
        public int? RoomId { get; set; }
        public RoomDTO Room { get; set; }
    }
}
