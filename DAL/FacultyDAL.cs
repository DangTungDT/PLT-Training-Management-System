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

        /// <summary>
        /// Lấy tất cả khoa
        /// </summary>
        public List<FacultyDTO> GetAll()
        {
            return _context.Faculties
                .Select(f => new FacultyDTO
                {
                    Id = f.Id,
                    Name = f.Name,
                    SchoolId = f.SchoolId,
                    Description = f.Description
                })
                .ToList();
        }

        /// <summary>
        /// Lấy khoa theo ID
        /// </summary>
        public FacultyDTO GetById(int id)
        {
            try
            {
                var faculty = _context.Faculties.Find(id);
                if (faculty == null)
                    return null;

                return new FacultyDTO
                {
                    Id = faculty.Id,
                    Name = faculty.Name,
                    SchoolId = faculty.SchoolId,
                    Description = faculty.Description
                };
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Thêm khoa mới
        /// </summary>
        public bool AddFaculty(FacultyDTO faculty)
        {
            try
            {
                var newFaculty = new FacultyDTO
                {
                    Name = faculty.Name,
                    SchoolId = faculty.SchoolId,
                    Description = faculty.Description
                };

                _context.Faculties.Add(newFaculty);
                return _context.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Tìm khoa theo tên và trường học
        /// </summary>
        public FacultyDTO FindByNameAndSchool(string name, int schoolId)
        {
            try
            {
                var faculty = _context.Faculties
                    .FirstOrDefault(f => f.Name == name && f.SchoolId == schoolId);

                if (faculty == null)
                    return null;

                return new FacultyDTO
                {
                    Id = faculty.Id,
                    Name = faculty.Name,
                    SchoolId = faculty.SchoolId,
                    Description = faculty.Description
                };
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Cập nhật khoa
        /// </summary>
        public bool UpdateFaculty(FacultyDTO faculty)
        {
            try
            {
                var existingFaculty = _context.Faculties.Find(faculty.Id);

                if (existingFaculty == null)
                    return false;

                existingFaculty.Name = faculty.Name;
                existingFaculty.SchoolId = faculty.SchoolId;
                existingFaculty.Description = faculty.Description;

                return _context.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Xóa khoa
        /// </summary>
        public bool DeleteFaculty(int id)
        {
            try
            {
                var faculty = _context.Faculties.Find(id);

                if (faculty == null)
                    return false;

                _context.Faculties.Remove(faculty);
                return _context.SaveChanges() > 0;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Kiểm tra khoa có classes không
        /// </summary>
        public bool HasClasses(int facultyId)
        {
            try
            {
                return _context.Classes.Any(c => c.FacultyId == facultyId);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Đếm số lượng lớp trong khoa
        /// </summary>
        public int CountClasses(int facultyId)
        {
            try
            {
                return _context.Classes.Count(c => c.FacultyId == facultyId);
            }
            catch
            {
                return 0;
            }
        }

    }
}
