using System;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SchoolBLL
    {
        private readonly SchoolDAL _schoolDAL;

        public SchoolBLL()
        {
            _schoolDAL = new SchoolDAL();
        }

        public int GetSchoolIdBySemesterId(int semesterId)
        {
            return _schoolDAL.GetSchoolIdBySemesterId(semesterId);
        }

        public List<SchoolDTO> GetAllSchools()
        {
            return _schoolDAL.GetAll();
        }

        public SchoolDTO GetSchoolById(int id)
        {
            return _schoolDAL.GetSchoolById(id);
        }

        /// <summary>
        /// Thêm trường học mới
        /// </summary>
        public bool AddSchool(SchoolDTO school)
        {
            if (school == null)
                throw new ArgumentNullException(nameof(school), "School không được null");

            if (string.IsNullOrWhiteSpace(school.Name))
                throw new ArgumentException("Tên trường không được để trống", nameof(school.Name));

            if (string.IsNullOrWhiteSpace(school.ShortName))
                throw new ArgumentException("Tên viết tắt không được để trống", nameof(school.ShortName));

            if (string.IsNullOrWhiteSpace(school.Address))
                throw new ArgumentException("Địa chỉ không được để trống", nameof(school.Address));

            return _schoolDAL.AddSchool(school);
        }

        /// <summary>
        /// Tìm trường học theo tên
        /// </summary>
        public SchoolDTO FindByName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên trường không được để trống", nameof(name));

            return _schoolDAL.FindByName(name);
        }

        /// <summary>
        /// Cập nhật trường học
        /// </summary>
        public bool UpdateSchool(SchoolDTO school)
        {
            if (school == null)
                throw new ArgumentNullException(nameof(school), "School không được null");

            if (school.Id <= 0)
                throw new ArgumentException("Id không hợp lệ", nameof(school.Id));

            if (string.IsNullOrWhiteSpace(school.Name))
                throw new ArgumentException("Tên trường không được để trống", nameof(school.Name));

            if (string.IsNullOrWhiteSpace(school.ShortName))
                throw new ArgumentException("Tên viết tắt không được để trống", nameof(school.ShortName));

            if (string.IsNullOrWhiteSpace(school.Address))
                throw new ArgumentException("Địa chỉ không được để trống", nameof(school.Address));

            return _schoolDAL.UpdateSchool(school);
        }
    }
}