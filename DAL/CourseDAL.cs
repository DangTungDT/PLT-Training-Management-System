using DTO;
using DAL.databaseContext;
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
        private readonly AppDBContext _context = new AppDBContext();

        //public CourseDAL(YourDbContext context)
        //{
        //    _context = context;
        //}

        public List<CourseDTO> GetAllBySemesterId(int semesterId)
        {
            return _context.Courses
                .Where(c => c.SemesterId == semesterId)
                .Select(c => new CourseDTO
                {
                    Id = c.Id,
                    FullName = c.FullName,
                    ShortName = c.ShortName,
                    StartDate = c.StartDate,
                    EndDate = c.EndDate,
                    Description = c.Description,
                    CategoryId = c.CategoryId,
                    SemesterId = c.SemesterId
                })
                .ToList();
        }

        public List<CourseDTO> GetAll()
        {
            using (var context = new databaseContext.AppDBContext())
            {
                return context.Courses
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
