using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SubmissionDTO
    {
        public int Id { get; set; }
        public int AssignmentId { get; set; }
        public AssignmentDTO Assignment { get; set; }
        public string StudentId { get; set; }
        public StudentDTO Student { get; set; }
        public string FileName { get; set; }
        public ICollection<SubmissionFileDTO> SubmissionFiles { get; set; }
    }
}
