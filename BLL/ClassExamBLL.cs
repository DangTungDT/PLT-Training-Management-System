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


        public bool DeleteClassExam(int classId, int examId)
        {
            return _dal.DeleteClassExam(classId, examId);
        }
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
