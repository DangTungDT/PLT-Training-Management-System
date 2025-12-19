using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TeacherClassDTO
    {
        public int ClassId { get; set; }
        public ClassDTO Class { get; set; }
        public string TeacherId { get; set; }
        public TeacherDTO Teacher { get; set; }
    }
}
