using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SubmissionFileDTO
    {
        public int SubmissionId { get; set; }
        public SubmissionDTO Submission { get; set; }
        public int FileId { get; set; }
        public FilesDTO File { get; set; }
    }
}
