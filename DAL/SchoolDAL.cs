using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SchoolDAL
    {
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
