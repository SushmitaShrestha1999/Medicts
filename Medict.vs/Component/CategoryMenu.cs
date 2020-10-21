using Medict.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Component
{


    public class CategoryMenu : ViewComponent
    {

        private readonly ICategoryService _categoryService;
        public CategoryMenu(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryService.GetList().OrderBy(p => p.Name);
            return View(categories);
        }
    }

}


