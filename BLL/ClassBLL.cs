using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClassBLL
    {
        private readonly ClassDAL _ClassDAL = new ClassDAL();

        public ClassDTO GetClassById(int idClass)
        {
            return _ClassDAL.GetClassById(idClass);
        }
        public List<ClassDTO> GetAllByFacultyId(int facultyId)
        {
            if (facultyId <= 0)
                throw new ArgumentException("Faculty id không được bé hơn 1", nameof(facultyId));

            return _ClassDAL.GetAllByFacultyId(facultyId);
        }


        public List<ClassDTO> SearchClassesByFacultyIds(List<int> facultyIds)
        {
            if (facultyIds == null || facultyIds.Count == 0)
                return new List<ClassDTO>();

            return _ClassDAL.SearchClassesByFacultyIds(facultyIds);
        }

    }
}
