using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class FacultyDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int SchoolId { get; set; }
        public SchoolDTO School { get; set; }
        public string Description { get; set; }

        public ICollection<StudentDTO> Students { get; set; }
        public ICollection<TeacherDTO> Teachers { get; set; }
        public ICollection<ClassDTO> Classes { get; set; }
        public ICollection<ResearchTopicDTO> ResearchTopics { get; set; }
    }
}
