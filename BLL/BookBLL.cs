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
        public IEnumerable<BookDTO> GetBookforPage(int pageIndex, int pageSize)
        {
            return _bookDAL.GetBookforPage(pageIndex, pageSize);
        }
        public IEnumerable<BookDTO> GetAll()
        {
            return _bookDAL.GetAll();
        }
    }
}
