using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExamBLL
    {
        private ExamDAL _examDAL = new ExamDAL();

        public ExamDTO GetExamById(int idExamSelected)
        {
            return _examDAL.GetExamById(idExamSelected);
        }
        public bool AddExam(ExamDTO newExam)
        {
            return _examDAL.AddExam(newExam);
        }
        public ExamDTO GetExamByValue(string name, string type, int courseId, int semesterId, int year)
        {
            return _examDAL.GetExamByValue(name, type, courseId, semesterId, year);
        }
        public IEnumerable<ExamOverviewDTO> GetExamsOverviewFilter(int courseId, int schoolId, int year)
        {
            return _examDAL.GetExamsOverviewFilter(courseId, schoolId, year);
        }
        public List<int> GetAllYearForExam()
        {
            return _examDAL.GetAllYearForExam();
        }
        public IEnumerable<ExamOverviewDTO> GetAllExamsOverview()
        {
            return _examDAL.GetAllExamsOverview();
        }
    }
}
