using Medict.Models;
using Medict.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Services
{
    public class MedicineService : IMedicineService
    {
        private readonly IRepositoryBase<Medicine> _medicineRepository;
        private readonly ApplicationContext _context;
        // private readonly IWebHostEnvironment _hostEnvironment;

        public MedicineService(IRepositoryBase<Medicine> medicineRepository, ApplicationContext context)
        {
            _medicineRepository = medicineRepository;
            _context = context;
            //_hostEnvironment = hostEnvironment;

        }
        public void AddMedicine(Medicine model)
        {

            try
            {

                _medicineRepository.Add(model);
            }

            catch (Exception ex)
            {
                throw;
            }

        }

        public void DeleteMedicineById(int id)
        {
            var model = _medicineRepository.GetById(id);
            _medicineRepository.Delete(model);
        }

        public Medicine GetById(int id)
        {
            var model = _medicineRepository.GetById(id);
            return model;
        }

        public IEnumerable<Medicine> GetList()
        {

            //var result = from product in _context.Products join cat in _context.Categories
            //             on product.CategoryId equals cat.CategoryId select Medict.Viewmodels.ProductCategoryViewModel;

            var model = _medicineRepository.GetList();
            return model;
        }

        public void UpdateMedicine(Medicine model)
        {
            _medicineRepository.Update(model);

        }
    }
}
