using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExamFileDTO
    {
        public int ExamId { get; set; }
        public ExamDTO Exam { get; set; }
        public int FileId { get; set; }
        public FilesDTO File { get; set; }
    }
}
