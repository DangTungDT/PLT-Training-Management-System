using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExamOverviewDTO
    {
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public string CourseName { get; set; }
        public string SchoolName { get; set; }
        public string ClassName { get; set; }
        public string ExamType { get; set; }
        public int Duration { get; set; }
        public int QuestionCount { get; set; }
        public string Status { get; set; }
    }
}
