using DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookDAL
    {
        public int GetQuantityBookByDifficultyLevel(string difficultyLevel)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Books
                        .Include(b => b.Category)
                        .Include(b => b.BookFiles)
                        .Where(b => b.DifficultyLevel == difficultyLevel)
                        .ToList().Count();
                }
            }
            catch
            {
                return 0;
            }
        }
        public IEnumerable<BookDTO> GetBooksByDifficultyLevel(string difficultyLevel, int pageIndex, int pageSize)
        {
            try
            {
                using(var context = new databaseContext.AppDBContext())
                {
                    return context.Books
                        .Include(b => b.Category)
                        .Include(b => b.BookFiles)
                        .Where(b => b.DifficultyLevel == difficultyLevel)
                        .OrderBy(c => c.Id)
                        .Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
                }
            }
            catch
            {
                return null;
            }
        }
        public List<string> GetAllTheLevelNameOfTheBooks()
        {
            try
            {
                using(var context = new databaseContext.AppDBContext())
                {
                    return context.Books
                        .Select(b => b.DifficultyLevel)
                        .Distinct()
                        .ToList();
                }
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<BookDTO> GetBookforPage(int pageIndex, int pageSize)
        {
            try
            {
                using(var context = new databaseContext.AppDBContext())
                {
                    return context.Books
                        .Include(b => b.Category)
                        .Include(b => b.BookFiles)
                                .OrderBy(c => c.Id)
                                .Skip((pageIndex - 1) * pageSize)
                                .Take(pageSize).ToList();
                }
            }
            catch
            {
                return null;
            }
        }

        public int GetQuantityOfAllBooks()
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Books
                        .Include(b => b.Category)
                        .Include(b => b.BookFiles)
                        .ToList().Count();
                }
            }
            catch
            {
                return 0;
            }
        }
        public IEnumerable<BookDTO> GetAll()
        {
            try
            {
                using(var context = new databaseContext.AppDBContext())
                {
                    return context.Books
                        .Include(b => b.Category)
                        .Include(b => b.BookFiles)
                        .ToList();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
