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
        public bool AddNewBookFile(BookFileDTO bookFile)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
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
