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
        private BookFileDAL _bookFileDAL = new BookFileDAL();

        public bool DeleteBookFile(int bookId, int fileId)
        {
            return _bookFileDAL.DeleteBookFile(bookId, fileId);
        }

        public List<int> GetAllFileIdByIdBook(int bookId)
        {
            return _bookFileDAL.GetAllFileIdByIdBook(bookId);
        }
        public List<BookFileDTO> GetAllBookFiles()
        {
            return _bookFileDAL.GetAllBookFiles();
        }
        public BookFileDTO GetBookFileByIdBook(int bookId)
        {
            return _bookFileDAL.GetBookFileByIdBook(bookId);
        }
        public bool AddNewBookFile(BookFileDTO bookFile)
        {
            return _bookFileDAL.AddNewBookFile(bookFile);
        }
        public List<BookFileDTO> GetAllBookFileByIdBook(int bookId)
        {
            return _bookFileDAL.GetAllBookFileByIdBook(bookId);
        }
    }
}
