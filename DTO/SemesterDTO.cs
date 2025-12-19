using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SemesterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? SchoolId { get; set; }
        public SchoolDTO School { get; set; }

        public ICollection<CourseDTO> Courses { get; set; }
        public ICollection<ExamDTO> Exams { get; set; }
    }
}
