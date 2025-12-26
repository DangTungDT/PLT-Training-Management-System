using System;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SchoolBLL
    {
        private readonly SchoolDAL _schoolDAL;

        public SchoolBLL()
        {
            _schoolDAL = new SchoolDAL();
        }

        public List<SchoolDTO> GetAllSchools()
        {
            return _schoolDAL.GetAll();
        }

        public SchoolDTO GetSchoolById(int id)
        {
            return _schoolDAL.GetSchoolById(id);
        }
    }
}
