using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FilesDTO
    {
        public int Id { get; set; }
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string FileType { get; set; }
        public int? FileSize { get; set; }
        public DateTime CreatedAt { get; set; }
        public ICollection<BookFileDTO> BookFiles { get; set; }
        public ICollection<ExamFileDTO> ExamFiles { get; set; }
        public ICollection<SubmissionFileDTO> SubmissionFiles { get; set; }
        public ICollection<ResearchTopicFileDTO> ResearchTopicFiles { get; set; }
    }
}
