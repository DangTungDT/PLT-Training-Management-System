using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookBLL
    {
        private BookDAL _bookDAL;
        public BookBLL()
        {
            _bookDAL = new BookDAL();
        }
        public bool PlusASummaryForTheBook(string bookName)
        {
            return _bookDAL.PlusASummaryForTheBook(bookName);
        }

        public bool DeleteAllRelationsOfBookByBookName(string bookName)
        {
            return _bookDAL.DeleteAllRelationsOfBookByBookName(bookName);
        }
        public bool DeleteBookByName(string bookId)
        {
            return _bookDAL.DeleteBookByName(bookId);
        }

        public bool UpdateBook(BookDTO book)
        {
            return _bookDAL.UpdateBook(book);
        }
        public BookDTO GetBookByName(string bookName)
        {
            return _bookDAL.GetBookByName(bookName);
        }
        public bool AddNewBook(BookDTO book) 
        {             
            return _bookDAL.AddNewBook(book);
        }
        public List<string> GetAllTheLevelNameOfTheBooks()
        {
            return _bookDAL.GetAllTheLevelNameOfTheBooks();
        }
        public int GetQuantityOfAllBooks(DateTime? dateCreateBook, string difficultyLevels)
        {
            return _bookDAL.GetQuantityOfAllBooks(dateCreateBook, difficultyLevels);
        }
        public IEnumerable<BookDTO> GetBookforPage(DateTime? dateCreateBook, string difficultyLevels,int pageIndex, int pageSize)
        {
            return _bookDAL.GetBookforPage(dateCreateBook, difficultyLevels, pageIndex, pageSize);
        }

        public int GetIdbyBookName(string bookName)
        {
            return _bookDAL.GetIdbyBookName(bookName);
        }
    }
}
