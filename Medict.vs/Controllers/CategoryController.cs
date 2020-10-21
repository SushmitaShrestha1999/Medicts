using Medict.Models;
using Medict.Repository;
using Medict.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Controllers
{
    public class CategoryController :Controller
    {
        private readonly ICategoryService _categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Create()
        {
            return View();
        }
         [HttpPost]
         public IActionResult Create(Category model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    model.CreatedDate = DateTime.Now;
                    _categoryService.AddCategory(model);
                    TempData["message"] = "Successfully created category";
                }
                else
                {
                    return View();
                }
            }
            catch(Exception ex)
            {
                throw;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Index()
        {
           var model= _categoryService.GetList();
            return View(model);
        }
       
        public IActionResult Edit(int id)
        {
            var model = _categoryService.GetById(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Edit(Category model)
        {
            _categoryService.UpdateCategory(model);
            TempData["message"] = "Successfully updated";
            return RedirectToAction("Index");
           
        }

        public IActionResult Delete(int id)
        {

            _categoryService.DeleteCategory(id);
            TempData["message"] = "Successfully Deleted";
            return RedirectToAction("Index");
        }
    }
}
