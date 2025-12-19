using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentScoreDTO
    {
        public int Id { get; set; }
        public string StudentId { get; set; }
        public StudentDTO Student { get; set; }
        public int CourseId { get; set; }
        public CourseDTO Course { get; set; }
        public decimal ScoreValue { get; set; }
        public string ScoreType { get; set; }
    }
}
