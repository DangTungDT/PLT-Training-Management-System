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
