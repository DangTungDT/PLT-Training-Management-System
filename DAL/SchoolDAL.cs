using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.databaseContext;

namespace DAL
{
    public class SchoolDAL
    {
        private AppDBContext _context = new AppDBContext();
        public int GetSchoolIdBySemesterId(int semesterId)
        {
            try
            {
                int schoolId = _context.Semesters.Where(x => x.Id == semesterId)
                                                 .Select(x=> x.SchoolId)
                                                 .FirstOrDefault() ?? 0;
                return schoolId;
            }
            catch
            {
                return 0;
            }
        }
        public List<SchoolDTO> GetAll()
        {
            using (var context = new databaseContext.AppDBContext())
            {
                return context.Schools
                    .ToList();
            }
        }

        public SchoolDTO GetSchoolById(int id)
        {
            using (var context = new databaseContext.AppDBContext())
            {
                return context.Schools
                    .Include(s => s.Semesters)
                    .FirstOrDefault(s => s.Id == id);
            }
        }
    }
}
