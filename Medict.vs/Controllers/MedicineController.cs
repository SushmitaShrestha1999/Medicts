using Medict.Models;
using Medict.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Controllers
{
    public class MedicineController:Controller
    {
        private readonly IMedicineService _medicineService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        public MedicineController(IMedicineService medicineService, ICategoryService categoryService, IBrandService brandService)
        {
            _medicineService = medicineService;
            _categoryService = categoryService;
            _brandService = brandService;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Medicine model)
        {
            _medicineService.AddMedicine(model);
            TempData["message"] = "Successfully created product";
            return RedirectToAction("Index","Medicine");
        }

        public IActionResult Index()
        {
            var model = _medicineService.GetList();
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var model = _medicineService.GetById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Medicine model)
        {
            _medicineService.UpdateMedicine(model);
            TempData["message"] = "Successfully updated medicine";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            _medicineService.DeleteMedicineById(id);
            TempData["message"] = "Successfully deleted medicine";
            return RedirectToAction("Index");

        }
    }
}
