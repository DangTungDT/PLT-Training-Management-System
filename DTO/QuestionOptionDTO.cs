using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuestionOptionDTO
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool IsCorrect { get; set; }
        public int? SortOrder { get; set; }
        public int QuestionId { get; set; }
        public QuestionDTO Question { get; set; }
    }
}
