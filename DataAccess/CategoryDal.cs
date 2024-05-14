using Entities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class CategoryDal : ICategoryDal
    {

        List<Category> _categoryList;

        public CategoryDal()
        {
            _categoryList = new List<Category>();
            _categoryList.Add(new Category { CategoryId = 1,CategoryName = "Teknoloji"});
            _categoryList.Add(new Category { CategoryId = 2, CategoryName = "Mutfak" });
        }

        public List<Category> GetCategories()
        {
            return _categoryList;
        }

        public void AddCategory(Category category)
        {
            _categoryList.Add(category);
        }

    }
}
