using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TeacherDTO
    {
        public string Id { get; set; }
        public int PersonId { get; set; }
        public PersonDTO Person { get; set; }
        public int FacultyId { get; set; }
        public FacultyDTO Faculty { get; set; }

        public ICollection<TeacherSchoolDTO> TeacherSchools { get; set; }
        public ICollection<TeacherClassDTO> TeacherClasses { get; set; }
        public ICollection<ResearchTopicDTO> ResearchTopics { get; set; }
        public ICollection<TeachingScheduleDTO> TeachingSchedules { get; set; }
        public ICollection<ClassDTO> Classes { get; set; }
    }
}
