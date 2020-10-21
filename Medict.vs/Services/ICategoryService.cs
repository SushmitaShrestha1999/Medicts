using Medict.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Services
{
    public interface ICategoryService
    {
        void AddCategory(Category model);
        IEnumerable<Category> GetList();
        Category GetById(int id);
        void UpdateCategory(Category model);
        void DeleteCategory(int id);

    }
}
