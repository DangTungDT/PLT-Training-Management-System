using System;
using DAL;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ExamFileBLL
    {
        private ExamFileDAL _dal = new ExamFileDAL();
        public List<int> GetAllFileByExamId(int examId)
        {
            return _dal.GetAllFileByExamId(examId);
        }
        public bool DeletedExamFile(int examId, int fileId)
        {
            return _dal.DeletedExamFile(examId, fileId);
        }
        public bool AddNewExamFile(ExamFileDTO examFile)
        {
            return _dal.AddNewExamFile(examFile);
        }
    }
}
