using System;
using DTO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CategoryDAL
    {
        public List<CategoryDTO> GetAllCategories()
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Categories.ToList();
                }
            }
            catch
            {
                return new List<CategoryDTO>();
            }
        }

        public CategoryDTO GetCategoryById(int categoryId)
        {
            try
            {
                using (var context = new databaseContext.AppDBContext())
                {
                    return context.Categories.FirstOrDefault(c => c.Id == categoryId);
                }
            }
            catch
            {
                return null;
            }
        }
    }
}