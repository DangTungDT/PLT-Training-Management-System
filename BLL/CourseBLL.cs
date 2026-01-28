using DAL;
using DTO;
using System;
using System.Collections.Generic;

namespace BLL
{
    public class CourseBLL
    {
        private readonly CourseDAL _courseDAL;
        public CourseBLL()
        {
            _courseDAL = new CourseDAL();
        }

        public List<CourseDTO> GetAllCourses()
        {
            return _courseDAL.GetAll();
        }

        public CourseDTO GetCourseById(int id)
        {
            return _courseDAL.GetById(id);
        }

        public List<CourseDTO> GetAllBySemesterId(int semesterId)
        {
            if (semesterId <= 0)
                throw new ArgumentException("Semester id không được bé hơn 1", nameof(semesterId));

            return _courseDAL.GetAllBySemesterId(semesterId);
        }

        /// <summary>
        /// Thêm Course mới (validate cơ bản trước khi gọi DAL)
        /// </summary>
        public bool AddCourse(CourseDTO course)
        {
            if (course == null)
                throw new ArgumentNullException(nameof(course));

            if (string.IsNullOrWhiteSpace(course.FullName))
                throw new ArgumentException("FullName không được để trống", nameof(course.FullName));

            if (string.IsNullOrWhiteSpace(course.ShortName))
                throw new ArgumentException("ShortName không được để trống", nameof(course.ShortName));

            if (course.SemesterId <= 0)
                throw new ArgumentException("SemesterId không hợp lệ", nameof(course.SemesterId));

            // Nếu có StartDate và EndDate, kiểm tra khoảng hợp lệ
            if (course.StartDate.HasValue && course.EndDate.HasValue)
            {
                if (course.StartDate >= course.EndDate)
                    throw new ArgumentException("StartDate phải nhỏ hơn EndDate");
            }

            return _courseDAL.AddCourse(course);
        }
    }
}