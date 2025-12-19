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

        public bool AddNewBook(BookDTO book)
        {
            try
            {
                using(var context = new databaseContext.AppDBContext())
                {
                    context.Books.Add(book);
                    context.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public int GetIdbyBookName(string bookName)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    var book = context.Books
                        .FirstOrDefault(b => b.Name == bookName);
                    if (book != null)
                    {
                        return book.Id;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
            catch
            {
                return -1;
            }
        }
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
        public IEnumerable<BookDTO> GetBookforPage(DateTime? dateCreateBook, string difficultyLevels, int pageIndex, int pageSize)
        {
            try
            {
                using(var context = new databaseContext.AppDBContext())
                {
                    if(dateCreateBook == null && difficultyLevels == "Tất cả")
                    {
                        return context.Books
                            .Include(b => b.Category)
                            .Include(b => b.BookFiles)
                                    .OrderBy(c => c.Id)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize).ToList();
                    }
                    else if(dateCreateBook != null && difficultyLevels == "Tất cả")
                    {
                        int yearCreateBook = dateCreateBook.Value.Year;
                        return context.Books
                            .Include(b => b.Category)
                            .Include(b => b.BookFiles)
                            .Where(b => b.PublishedYear == yearCreateBook)
                                    .OrderBy(c => c.Id)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize).ToList();
                    } else if(dateCreateBook == null && difficultyLevels != "Tất cả")
                    {
                        return context.Books
                            .Include(b => b.Category)
                            .Include(b => b.BookFiles)
                            .Where(b => b.DifficultyLevel == difficultyLevels)
                                    .OrderBy(c => c.Id)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize).ToList();
                    }
                    else
                    {
                        int yearCreateBook = dateCreateBook.Value.Year;
                        return context.Books
                            .Include(b => b.Category)
                            .Include(b => b.BookFiles)
                            .Where(b => b.PublishedYear == yearCreateBook
                                        && b.DifficultyLevel == difficultyLevels)
                                    .OrderBy(c => c.Id)
                                    .Skip((pageIndex - 1) * pageSize)
                                    .Take(pageSize).ToList();
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        public int GetQuantityOfAllBooks(DateTime? dateCreateBook, string difficultyLevels)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    if(dateCreateBook == null && difficultyLevels == "Tất cả")
                    {
                        return context.Books
                            .ToList().Count();
                    }
                    else if(dateCreateBook != null && difficultyLevels == "Tất cả")
                    {
                        int yearCreateBook = dateCreateBook.Value.Year;
                        return context.Books
                            .Where(b => b.PublishedYear == yearCreateBook)
                            .ToList().Count();
                    }
                    else if(dateCreateBook == null && difficultyLevels != "Tất cả")
                    {
                        return context.Books
                            .Where(b => b.DifficultyLevel == difficultyLevels)
                            .ToList().Count();
                    }
                    else
                    {
                        int yearCreateBook = dateCreateBook.Value.Year;
                        return context.Books
                            .Where(b => b.PublishedYear == yearCreateBook
                                        && b.DifficultyLevel == difficultyLevels)
                            .ToList().Count();
                    }
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
