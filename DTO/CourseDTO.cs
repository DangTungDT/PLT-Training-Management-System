using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CourseDTO
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ShortName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public CategoryDTO Category { get; set; }
        public int SemesterId { get; set; }
        public SemesterDTO Semester { get; set; }

        public ICollection<CourseClassDTO> CourseClasses { get; set; }
        public ICollection<AssignmentDTO> Assignments { get; set; }
        public ICollection<TeachingScheduleDTO> TeachingSchedules { get; set; }
        public ICollection<LessonPlanDTO> LessonPlans { get; set; }
        public ICollection<ExamDTO> Exams { get; set; }
        public ICollection<StudentScoreDTO> StudentScores { get; set; }
    }
}
