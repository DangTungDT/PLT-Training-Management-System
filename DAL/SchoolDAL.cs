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
                                                 .Select(x => x.SchoolId)
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

        /// <summary>
        /// Thêm trường học mới
        /// </summary>
        public bool AddSchool(SchoolDTO school)
        {
            try
            {
                var newSchool = new SchoolDTO
                {
                    Name = school.Name,
                    ShortName = school.ShortName,
                    Address = school.Address,
                    Email = school.Email,
                    Phone = school.Phone,
                    IsActive = school.IsActive
                };

                _context.Schools.Add(newSchool);
                return _context.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Tìm trường học theo tên
        /// </summary>
        public SchoolDTO FindByName(string name)
        {
            try
            {
                var school = _context.Schools
                    .FirstOrDefault(s => s.Name == name);

                if (school == null)
                    return null;

                return new SchoolDTO
                {
                    Id = school.Id,
                    Name = school.Name,
                    ShortName = school.ShortName,
                    Address = school.Address,
                    Email = school.Email,
                    Phone = school.Phone,
                    IsActive = school.IsActive
                };
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Cập nhật trường học
        /// </summary>
        public bool UpdateSchool(SchoolDTO school)
        {
            try
            {
                var existingSchool = _context.Schools.Find(school.Id);

                if (existingSchool == null)
                    return false;

                existingSchool.Name = school.Name;
                existingSchool.ShortName = school.ShortName;
                existingSchool.Address = school.Address;
                existingSchool.Email = school.Email;
                existingSchool.Phone = school.Phone;
                existingSchool.IsActive = school.IsActive;

                return _context.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }
    }
}