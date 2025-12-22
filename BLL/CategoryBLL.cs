using System;
using DTO;
using DAL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoryBLL
    {
        public List<CategoryDTO> GetAllCategories()
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            return categoryDAL.GetAllCategories();
        }
        public CategoryDTO GetCategoryById(int categoryId)
        {
            CategoryDAL categoryDAL = new CategoryDAL();
            return categoryDAL.GetCategoryById(categoryId);
        }
    }
}
