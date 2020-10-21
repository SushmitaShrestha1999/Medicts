using Medict.Models;
using Medict.Repository;
using Medict.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrandService _brandService;

        public BrandController(IBrandService brandService)
        {
            _brandService = brandService;
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Brand model)
        {
            try
            {
                model.CreatedDate = DateTime.Now;
                _brandService.AddBrand(model);
                TempData["message"] = "Successfully created brand";
            }
            catch(Exception ex)
            {
                throw;
            }
            return RedirectToAction("Index");

        }
        public IActionResult Index()
        {
            var model = _brandService.GetList();
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            var model = _brandService.GetById(id);
            return View(model);
        }
        [HttpPost]
       
        public IActionResult Edit(Brand model)
        {
            _brandService.UpdateBrand(model);
            TempData["message"] = "Successfully updated";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var model = _brandService.GetById(id);
            TempData["message"] = "Successfully deleted";
            return RedirectToAction("Index");
        }
    }
}
