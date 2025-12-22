using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CourseDAL
    {
        public List<CourseDTO> GetAll()
        {
            using (var context = new databaseContext.AppDBContext())
            {
                return context.Courses
                    .Include(c => c.Category)
                    .Include(c => c.Semester)
                        .ThenInclude(s => s.School)
                    .ToList();
            }
        }

        public CourseDTO GetById(int id)
        {
            using (var context = new databaseContext.AppDBContext())
            {
                return context.Courses
                    .Include(c => c.Category)
                    .Include(c => c.Semester)
                        .ThenInclude(s => s.School)
                    .FirstOrDefault(c => c.Id == id);
            }
        }
    }
}
