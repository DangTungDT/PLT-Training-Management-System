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
    public class FacultyDAL
    {
        private readonly AppDBContext _context = new AppDBContext();

        //public FacultyDAL(AppDBContext context)
        //{
        //    _context = context;
        //}

        public List<FacultyDTO> GetAllBySchoolId(int schoolId)
        {
            return _context.Faculties
                .Where(f => f.SchoolId == schoolId)
                .Select(f => new FacultyDTO
                {
                    Id = f.Id,
                    Name = f.Name,
                    SchoolId = f.SchoolId,
                    Description = f.Description
                })
                .ToList();
        }

    }
}
