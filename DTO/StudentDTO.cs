using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentDTO
    {
        public string Id { get; set; }
        public int ClassId { get; set; }
        public ClassDTO Class { get; set; }
        public int FacultyId { get; set; }
        public FacultyDTO Faculty { get; set; }
        public int PersonId { get; set; }
        public PersonDTO Person { get; set; }
        public ICollection<SubmissionDTO> Submissions { get; set; }
        public ICollection<StudentScoreDTO> StudentScores { get; set; }
    }
}
