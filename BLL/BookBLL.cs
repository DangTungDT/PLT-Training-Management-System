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

        public int GetQuantityBookByDifficultyLevel(string difficultyLevel)
        {
            return _bookDAL.GetQuantityBookByDifficultyLevel(difficultyLevel);
        }
        public List<string> GetAllTheLevelNameOfTheBooks()
        {
            return _bookDAL.GetAllTheLevelNameOfTheBooks();
        }
        public int GetQuantityOfAllBooks(DateTime? dateCreateBook, string difficultyLevels)
        {
            return _bookDAL.GetQuantityOfAllBooks(dateCreateBook, difficultyLevels);
        }
        public IEnumerable<BookDTO> GetBooksByDifficultyLevel(string difficultyLevel, int pageIndex, int pageSize)
        {
            return _bookDAL.GetBooksByDifficultyLevel(difficultyLevel, pageIndex, pageSize);
        }
        public IEnumerable<BookDTO> GetBookforPage(DateTime? dateCreateBook, string difficultyLevels,int pageIndex, int pageSize)
        {
            return _bookDAL.GetBookforPage(dateCreateBook, difficultyLevels, pageIndex, pageSize);
        }
        public IEnumerable<BookDTO> GetAll()
        {
            return _bookDAL.GetAll();
        }
    }
}
