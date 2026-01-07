using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ExamFileDAL
    {
        public bool AddNewExamFile(ExamFileDTO examFile)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    ExamFileDTO itemCheck = context.Exam_Files.FirstOrDefault(x => x.ExamId == examFile.ExamId && x.FileId == examFile.FileId);
                    if (itemCheck != null) return false;
                    context.Exam_Files.Add(examFile);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public List<int> GetAllFileByExamId(int  examId)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Exam_Files.Where(bf => bf.ExamId == examId).Select(bf => bf.FileId).ToList();
                }
            }
            catch
            {
                return new List<int>();
            }
        }
        public bool DeletedExamFile(int examId, int fileId)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    var examFile = context.Exam_Files.FirstOrDefault(bf => bf.FileId == fileId && bf.FileId == fileId);
                    if (examFile == null) return false;
                    context.Exam_Files.Remove(examFile);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
