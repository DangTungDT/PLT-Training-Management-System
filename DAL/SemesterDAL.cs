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

        /// <summary>
        /// Thêm học kỳ mới
        /// </summary>
        public bool AddSemester(SemesterDTO semester)
        {
            try
            {
                var newSemester = new SemesterDTO
                {
                    Name = semester.Name,
                    Year = semester.Year,
                    StartDate = semester.StartDate,
                    EndDate = semester.EndDate,
                    SchoolId = semester.SchoolId
                };

                _context.Semesters.Add(newSemester);
                return _context.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Tìm học kỳ theo tên và năm
        /// </summary>
        public SemesterDTO FindByNameAndYear(string name, int year)
        {
            try
            {
                var semester = _context.Semesters
                    .FirstOrDefault(s => s.Name == name && s.Year == year);

                if (semester == null)
                    return null;

                return new SemesterDTO
                {
                    Id = semester.Id,
                    Name = semester.Name,
                    Year = semester.Year,
                    StartDate = semester.StartDate,
                    EndDate = semester.EndDate,
                    SchoolId = semester.SchoolId
                };
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Cập nhật học kỳ
        /// </summary>
        public bool UpdateSemester(SemesterDTO semester)
        {
            try
            {
                var existingSemester = _context.Semesters.Find(semester.Id);

                if (existingSemester == null)
                    return false;

                existingSemester.Name = semester.Name;
                existingSemester.Year = semester.Year;
                existingSemester.StartDate = semester.StartDate;
                existingSemester.EndDate = semester.EndDate;
                existingSemester.SchoolId = semester.SchoolId;

                return _context.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}