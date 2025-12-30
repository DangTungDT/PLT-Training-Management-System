using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClassDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FacultyId { get; set; }
        public FacultyDTO Faculty { get; set; }
        public string TeacherId { get; set; }
        public TeacherDTO Teacher { get; set; }

        public ICollection<CourseClassDTO> CourseClasses { get; set; }
        public ICollection<StudentDTO> Students { get; set; }
        public ICollection<TeacherClassDTO> TeacherClasses { get; set; }
        public ICollection<TeachingScheduleDTO> TeachingSchedules { get; set; }
        public ICollection<LessonPlanDTO> LessonPlans { get; set; }
        public ICollection<ClassExamDTO> ClassExams { get; set; }
    }
}
