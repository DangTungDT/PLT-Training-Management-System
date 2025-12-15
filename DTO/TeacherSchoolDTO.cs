using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TeacherSchoolDTO
    {
        public int SchoolId { get; set; }
        public SchoolDTO School { get; set; }
        public string TeacherId { get; set; }
        public TeacherDTO Teacher { get; set; }
    }
}
