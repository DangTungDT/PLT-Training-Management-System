using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ClassExamDTO
    {
        public int Id { get; set; }
        
        public int ExamId { get; set; }
        public ExamDTO Exam { get; set; }

        public int ClassId { get; set; }
        public ClassDTO Class { get; set; }
    }
}
