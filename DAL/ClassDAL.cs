using DAL.databaseContext;
using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClassDAL
    {
        private readonly AppDBContext _context = new AppDBContext();

        //public ClassDAL(YourDbContext context)
        //{
        //    _context = context;
        //}

        public List<ClassDTO> GetAllByFacultyId(int facultyId)
        {
            return _context.Classes
                .Where(c => c.FacultyId == facultyId)
                .Select(c => new ClassDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    FacultyId = c.FacultyId,
                    TeacherId = c.TeacherId
                })
                .ToList();
        }


        public List<ClassDTO> SearchClassesByFacultyIds(List<int> facultyIds)
        {
            return _context.Classes
                .Where(c => facultyIds.Contains(c.FacultyId))
                .Select(c => new ClassDTO
                {
                    Id = c.Id,
                    Name = c.Name,
                    FacultyId = c.FacultyId,
                    TeacherId = c.TeacherId
                })
                .ToList();
        }

    }
}
