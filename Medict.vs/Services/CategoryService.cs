using Medict.Models;
using Medict.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Medict.Services
{
    public class CategoryService:ICategoryService
    {
        private readonly IRepositoryBase<Category> _categoryRepository;
        public CategoryService(IRepositoryBase<Category> categoryRepository)


        {
            _categoryRepository = categoryRepository;
        }

        public void AddCategory(Category model)
        {
            try
            {
                _categoryRepository.Add(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteCategory(int id)
        {
            var model = _categoryRepository.GetById(id);
            _categoryRepository.Delete(model);

        }


        public Category GetById(int id)
        {
            var model = _categoryRepository.GetById(id);
            return model;
        }

        public IEnumerable<Category> GetList()
        {
            var model = _categoryRepository.GetList();
            return model;
        }

        public void UpdateCategory(Category model)
        {
            
            _categoryRepository.Update(model);

        }
    }
}
