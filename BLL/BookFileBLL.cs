using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookFileBLL
    {
        public List<BookFileDTO> GetAllBookFiles()
        {
            BookFileDAL bookFileDAL = new BookFileDAL();
            return bookFileDAL.GetAllBookFiles();
        }
        public BookFileDTO GetBookFileByIdBook(int bookId)
        {
            BookFileDAL bookFileDAL = new BookFileDAL();
            return bookFileDAL.GetBookFileByIdBook(bookId);
        }
        public bool AddNewBookFile(BookFileDTO bookFile)
        {
            BookFileDAL bookFileDAL = new BookFileDAL();
            return bookFileDAL.AddNewBookFile(bookFile);
        }
    }
}
