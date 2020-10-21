using Medict.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Services
{
    public interface IBrandService
    {
        void AddBrand(Brand model);
        IEnumerable<Brand> GetList();
        Brand GetById(int id);
        void UpdateBrand(Brand model);
        void DeleteBrandById(int id);
    }
}
