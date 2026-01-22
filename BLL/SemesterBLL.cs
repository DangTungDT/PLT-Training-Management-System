using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SemesterBLL
    {
        private readonly SemesterDAL _semesterDAL = new SemesterDAL();

        public SemesterDTO GetById(int id)
        {
            return _semesterDAL.GetById(id);
        }
        public List<SemesterDTO> GetAllBySchoolId(int schoolId)
        {
            if (schoolId <= 0)
                throw new ArgumentException("School id không được bé hơn 1", nameof(schoolId));

            return _semesterDAL.GetAllBySchoolId(schoolId);
        }

        /// <summary>
        /// Lấy tất cả học kỳ
        /// </summary>
        public List<SemesterDTO> GetAll()
        {
            return _semesterDAL.GetAll();
        }

        /// <summary>
        /// Thêm học kỳ mới
        /// </summary>
        public bool AddSemester(SemesterDTO semester)
        {
            if (semester == null)
                throw new ArgumentNullException(nameof(semester), "Semester không được null");

            if (string.IsNullOrWhiteSpace(semester.Name))
                throw new ArgumentException("Tên học kỳ không được để trống", nameof(semester.Name));

            if (semester.Year <= 0)
                throw new ArgumentException("Năm không hợp lệ", nameof(semester.Year));

            if (semester.SchoolId == null || semester.SchoolId <= 0)
                throw new ArgumentException("SchoolId không hợp lệ", nameof(semester.SchoolId));

            if (semester.StartDate.HasValue && semester.EndDate.HasValue)
            {
                if (semester.StartDate >= semester.EndDate)
                    throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
            }

            return _semesterDAL.AddSemester(semester);
        }

        /// <summary>
        /// Tìm học kỳ theo tên và năm
        /// </summary>
        public SemesterDTO FindByNameAndYear(string name, int year)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên học kỳ không được để trống", nameof(name));

            if (year <= 0)
                throw new ArgumentException("Năm không hợp lệ", nameof(year));

            return _semesterDAL.FindByNameAndYear(name, year);
        }

        /// <summary>
        /// Cập nhật học kỳ
        /// </summary>
        public bool UpdateSemester(SemesterDTO semester)
        {
            if (semester == null)
                throw new ArgumentNullException(nameof(semester), "Semester không được null");

            if (semester.Id <= 0)
                throw new ArgumentException("Id không hợp lệ", nameof(semester.Id));

            if (string.IsNullOrWhiteSpace(semester.Name))
                throw new ArgumentException("Tên học kỳ không được để trống", nameof(semester.Name));

            if (semester.Year <= 0)
                throw new ArgumentException("Năm không hợp lệ", nameof(semester.Year));

            if (semester.SchoolId == null || semester.SchoolId <= 0)
                throw new ArgumentException("SchoolId không hợp lệ", nameof(semester.SchoolId));

            if (semester.StartDate.HasValue && semester.EndDate.HasValue)
            {
                if (semester.StartDate >= semester.EndDate)
                    throw new ArgumentException("Ngày bắt đầu phải nhỏ hơn ngày kết thúc");
            }

            return _semesterDAL.UpdateSemester(semester);
        }
    }
}