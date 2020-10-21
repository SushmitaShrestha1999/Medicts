using Medict.Models;
using Medict.Repository;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Services
{
    public class ProductService :IProductService
    {
        private readonly IRepositoryBase<Product> _productRepository;
        private readonly ApplicationContext _context;
       // private readonly IWebHostEnvironment _hostEnvironment;

        public ProductService(IRepositoryBase<Product> productRepository, ApplicationContext context)
        {
            _productRepository = productRepository;
            _context = context;
            //_hostEnvironment = hostEnvironment;

        }

        public object Products => throw new NotImplementedException();

        public void AddProduct(Product model)
        {

            try
            {
                
                _productRepository.Add(model);
            }

            catch (Exception ex)
            {
                throw;
            }
           
        }

        public void DeleteProductById(int id)
        {
            var model = _productRepository.GetById(id);
            _productRepository.Delete(model);
        }

        public Product GetById(int id)
        {
            var model = _productRepository.GetById(id);
            return model;
        }

        public IEnumerable<Product> GetList()
        {

            //var result = from product in _context.Products join cat in _context.Categories
            //             on product.CategoryId equals cat.CategoryId select Medict.Viewmodels.ProductCategoryViewModel;

                var model = _productRepository.GetList();
            return model;
        }

        public void UpdateProduct(Product model)
        {
            _productRepository.Update(model);
            
        }

      
    }
}

       

