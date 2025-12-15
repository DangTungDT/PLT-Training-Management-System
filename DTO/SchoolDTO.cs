using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SchoolDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsActive { get; set; }

        public ICollection<FacultyDTO> Faculties { get; set; }
        public ICollection<SemesterDTO> Semesters { get; set; }
        public ICollection<TeacherSchoolDTO> TeacherSchools { get; set; }
    }
}
