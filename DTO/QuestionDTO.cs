using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuestionDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }
        public decimal Score { get; set; }
        public int ExamId { get; set; }
        public ExamDTO Exam { get; set; }
        public ICollection<QuestionOptionDTO> QuestionOptions { get; set; }
    }
}
