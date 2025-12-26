using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CourseClassDTO
    {
        public int CourseId { get; set; }
        public CourseDTO Course { get; set; }

        public int ClassId { get; set; }
        public ClassDTO Class { get; set; }
    }
}
