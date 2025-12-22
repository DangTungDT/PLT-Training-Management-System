using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CourseBLL
    {
        private readonly CourseDAL _courseDAL;

        public CourseBLL()
        {
            _courseDAL = new CourseDAL();
        }

        public List<CourseDTO> GetAllCourses()
        {
            return _courseDAL.GetAll();
        }

        public CourseDTO GetCourseById(int id)
        {
            return _courseDAL.GetById(id);
        }
    }
}
