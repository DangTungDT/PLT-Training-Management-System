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
    public class SemesterDAL
    {
        private readonly AppDBContext _context = new AppDBContext();

        //public SemesterDAL(AppDBContext context)
        //{
        //    _context = context;
        //}

        public List<SemesterDTO> GetAllBySchoolId(int schoolId)
        {
            return _context.Semesters
                .Where(f => f.SchoolId == schoolId)
                .Select(f => new SemesterDTO
                {
                    Id = f.Id,
                    Name = f.Name,
                    SchoolId = f.SchoolId
                })
                .ToList();
        }

    }
}
