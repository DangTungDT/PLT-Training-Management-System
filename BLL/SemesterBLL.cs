using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SemesterBLL
    {
        private readonly SemesterDAL _semesterDAL = new SemesterDAL();

        public List<SemesterDTO> GetAllBySchoolId(int schoolId)
        {
            if (schoolId <= 0)
                throw new ArgumentException("School id không được bé hơn 1", nameof(schoolId));

            return _semesterDAL.GetAllBySchoolId(schoolId);
        }


    }
}
