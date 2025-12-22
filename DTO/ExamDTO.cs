using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExamDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public int Duration { get; set; }
        public string ExamInstruction { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public CourseDTO Course { get; set; }
        public int SemesterId { get; set; }
        public SemesterDTO Semester { get; set; }
        public int Year { get; set; }
        public string Status { get; set; }

        public ICollection<ExamFileDTO> ExamFiles { get; set; }
        public ICollection<QuestionDTO> Questions { get; set; }
    }
}
