using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClassExamBLL
    {
        private ClassExamDAL _dal = new ClassExamDAL();

        public List<int> GetIdClassByIdExam(int examId)
        {
            return _dal.GetIdClassByIdExam(examId);
        }
        public bool AddClassExam(int classId, int examId)
        {
            return _dal.AddClassExam(classId, examId);
        }
    }
}
