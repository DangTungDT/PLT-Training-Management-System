using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FacultyBLL
    {
        private readonly FacultyDAL _facultyDAL = new FacultyDAL();

        public List<FacultyDTO> GetAllBySchoolId(int schoolId)
        {
            if (schoolId <= 0)
                throw new ArgumentException("School id không được bé hơn 1", nameof(schoolId));

            return _facultyDAL.GetAllBySchoolId(schoolId);
        }


    }
}
