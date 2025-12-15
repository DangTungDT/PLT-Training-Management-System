using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AssignmentDTO
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public bool IsOpen { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public CourseDTO Course { get; set; }
        public ICollection<SubmissionDTO> Submissions { get; set; }
    }
}
