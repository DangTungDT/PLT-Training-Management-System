using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class FacultyBLL
    {
        private readonly FacultyDAL _facultyDAL = new FacultyDAL();

        public List<FacultyDTO> GetAllBySchoolId(int schoolId)
        {
            if (schoolId <= 0)
                throw new ArgumentException("School id không được bé hơn 1", nameof(schoolId));

            return _facultyDAL.GetAllBySchoolId(schoolId);
        }


        /// <summary>
        /// Thêm khoa mới
        /// </summary>
        public bool AddFaculty(FacultyDTO faculty)
        {
            try
            {
                // Validate
                if (faculty == null)
                {
                    throw new ArgumentNullException(nameof(faculty), "Thông tin khoa không được để trống!");
                }

                if (string.IsNullOrWhiteSpace(faculty.Name))
                {
                    throw new ArgumentException("Tên khoa không được để trống!");
                }

                if (faculty.SchoolId <= 0)
                {
                    throw new ArgumentException("School ID không hợp lệ!");
                }

                // Kiểm tra tên khoa có ít nhất 3 ký tự
                if (faculty.Name.Trim().Length < 3)
                {
                    throw new ArgumentException("Tên khoa phải có ít nhất 3 ký tự!");
                }

                return _facultyDAL.AddFaculty(faculty);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi thêm khoa: {ex.Message}");
            }
        }

        /// <summary>
        /// Tìm khoa theo tên và trường học
        /// </summary>
        public FacultyDTO FindByNameAndSchool(string name, int schoolId)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    throw new ArgumentException("Tên khoa không được để trống!");
                }

                if (schoolId <= 0)
                {
                    throw new ArgumentException("School ID không hợp lệ!");
                }

                return _facultyDAL.FindByNameAndSchool(name, schoolId);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tìm khoa: {ex.Message}");
            }
        }

        /// <summary>
        /// Lấy khoa theo ID
        /// </summary>
        public FacultyDTO GetById(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Faculty ID không hợp lệ!");
                }

                return _facultyDAL.GetById(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy thông tin khoa: {ex.Message}");
            }
        }

        /// <summary>
        /// Cập nhật khoa
        /// </summary>
        public bool UpdateFaculty(FacultyDTO faculty)
        {
            try
            {
                // Validate
                if (faculty == null)
                {
                    throw new ArgumentNullException(nameof(faculty), "Thông tin khoa không được để trống!");
                }

                if (faculty.Id <= 0)
                {
                    throw new ArgumentException("Faculty ID không hợp lệ!");
                }

                if (string.IsNullOrWhiteSpace(faculty.Name))
                {
                    throw new ArgumentException("Tên khoa không được để trống!");
                }

                if (faculty.SchoolId <= 0)
                {
                    throw new ArgumentException("School ID không hợp lệ!");
                }

                return _facultyDAL.UpdateFaculty(faculty);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi cập nhật khoa: {ex.Message}");
            }
        }

        /// <summary>
        /// Xóa khoa
        /// </summary>
        public bool DeleteFaculty(int id)
        {
            try
            {
                if (id <= 0)
                {
                    throw new ArgumentException("Faculty ID không hợp lệ!");
                }

                return _facultyDAL.DeleteFaculty(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi xóa khoa: {ex.Message}");
            }
        }

        /// <summary>
        /// Kiểm tra khoa có tồn tại không
        /// </summary>
        public bool Exists(int id)
        {
            try
            {
                if (id <= 0)
                {
                    return false;
                }

                var faculty = _facultyDAL.GetById(id);
                return faculty != null;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy tất cả khoa
        /// </summary>
        public List<FacultyDTO> GetAll()
        {
            try
            {
                return _facultyDAL.GetAll();
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi lấy danh sách tất cả khoa: {ex.Message}");
            }
        }
    }
}
