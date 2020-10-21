using Medict.Models;
using Medict.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Services
{
    public class BrandService : IBrandService
    {
        private readonly IRepositoryBase<Brand> _brandRepository;
        public BrandService(IRepositoryBase<Brand> brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public void AddBrand(Brand model)
        {
            try
            {
                model.CreatedDate = DateTime.Now;
                _brandRepository.Add(model);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void DeleteBrandById(int id)
        {
            var model = _brandRepository.GetById(id);
            _brandRepository.Delete(model);
           
        }

        public Brand GetById(int id)
        {
            var model = _brandRepository.GetById(id);
            return model;
        }

        public IEnumerable<Brand> GetList()
        {
            var model = _brandRepository.GetList();
            return model;
        }

        public void UpdateBrand(Brand model)
        {
            _brandRepository.Update(model);
        }
    }
}
