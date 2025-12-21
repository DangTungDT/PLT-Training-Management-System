using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookFileDAL
    {

        public bool DeleteBookFile(int bookId, int fileId)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    var bookFile = context.Book_Files.FirstOrDefault(bf=> bf.FileId == fileId &&  bf.BookId == bookId);
                    if (bookFile == null) return false;
                    context.Book_Files.Remove(bookFile);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public List<BookFileDTO> GetAllBookFiles()
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Book_Files.ToList();
                }
            }
            catch
            {
                return new List<BookFileDTO>();
            }
        }
        public BookFileDTO GetBookFileByIdBook(int bookId)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Book_Files.FirstOrDefault(bf => bf.BookId == bookId);
                }
            }
            catch
            {
                return null;
            }
        }
        public List<BookFileDTO> GetAllBookFileByIdBook(int bookId)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Book_Files.Where(bf => bf.BookId == bookId).ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public List<int> GetAllFileIdByIdBook(int bookId)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Book_Files.Where(bf => bf.BookId == bookId).Select(bf => bf.FileId).ToList();
                }
            }
            catch
            {
                return new List<int>();
            }
        }
        public bool AddNewBookFile(BookFileDTO bookFile)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    var existing = context.Book_Files.FirstOrDefault(bf => bf.BookId == bookFile.BookId && bf.FileId == bookFile.FileId);
                    if (existing != null) return false;
                    context.Book_Files.Add(bookFile);
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
