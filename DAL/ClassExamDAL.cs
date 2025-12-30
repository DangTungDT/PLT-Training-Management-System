using System;
using DTO;
using DAL.databaseContext;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ClassExamDAL
    {
        AppDBContext _context = new AppDBContext();

        public bool AddClassExam(int classId, int examId)
        {
            try
            {
                ClassExamDTO ExistenceCheck = _context.ClassExams.Where(x => x.ClassId == classId && x.ExamId == examId).FirstOrDefault();
                if (ExistenceCheck != null) return true;
                ClassExamDTO newClassExam = new ClassExamDTO
                {
                    ClassId = classId,
                    ExamId = examId
                };
                _context.ClassExams.Add(newClassExam);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<int> GetIdClassByIdExam(int examId)
        {
            try
            {
                List<int> idClasses = _context.ClassExams.Where(x => x.ExamId == examId).Select(x => x.ClassId).ToList();
                return idClasses;
            }
            catch
            {
                return null;
            }
        }
    }
}
