using Medict.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Services
{
    public interface IProductService
    {
        object Products { get; }

        void AddProduct(Product model);
        IEnumerable<Product> GetList();
        Product GetById(int id);
        void UpdateProduct(Product model);
        void DeleteProductById(int id);
       
    }
}
