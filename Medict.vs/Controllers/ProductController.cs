using Medict.Models;
using Medict.Repository;
using Medict.Services;
using Medict.Viewmodels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Hosting.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Medict.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IBrandService _brandService;
        private readonly IWebHostEnvironment _hostEnvironment;
        private readonly ApplicationContext _applicationContext;


        public ProductController(IProductService productService, ApplicationContext applicationContext, ICategoryService categoryService, IBrandService brandService, IWebHostEnvironment hostEnvironment)
        {
            _productService = productService;
            _categoryService = categoryService;
            _brandService = brandService;
            _hostEnvironment = hostEnvironment;
            _applicationContext = applicationContext;

        }


        public IActionResult Create()
        {
            ViewBag.CategoryList = _categoryService.GetList();
            ViewBag.BrandList = _brandService.GetList();
            Product model = new Product();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Product model)
        {
            if (ModelState.IsValid)
            {
                var files = HttpContext.Request.Form.Files;
                if (files != null)
                {
                    foreach (var image in files)
                    {
                        if (image != null && image.Length > 0)
                        {
                            var file = image;
                            //There is an error here
                            var uploads = Path.Combine(_hostEnvironment.WebRootPath, "images//ProductImages");
                            if (file.Length > 0)
                            {
                                var fileName = Guid.NewGuid().ToString().Replace("-", "") + Path.GetExtension(file.FileName);
                                using (var fileStream = new FileStream(Path.Combine(uploads, fileName), FileMode.Create))
                                {
                                    await file.CopyToAsync(fileStream);
                                    model.Image = "~/images/ProductImages/" + fileName;
                                }
                            }
                        }
                    }
                }
                _productService.AddProduct(model);
                TempData["message"] = "Successfully created product";
                return RedirectToAction("Index");
            }
            {
                var errors = ModelState.Values.SelectMany(v => v.Errors);
            }
            return View(model);


        }

        //public IActionResult Search(string searchString)
        //{
        //    ViewData["CurrentFilter"] = searchString;

        //    var products = from s in _applicationContext.Products
        //                   select s;
        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        products = products.Where(s => s.Name.Contains(searchString)
        //                               );
        //    }

        //    return View(products);
        //}

        public IActionResult Index()
        {
           
          
            var model = _productService.GetList();
            
            return View(model);
        }
        public IActionResult Edit(int id)
        {
            var model = _productService.GetById(id);
            return View(model);
        }


        public IActionResult Details()
        { 

           var model = _productService.GetList();
            
           return View(model);
            }
            [HttpPost]
            public IActionResult Edit(Product model)
            {
                _productService.UpdateProduct(model);
                TempData["message"] = "Successfully updated product";
                return RedirectToAction("Index");
            }

            public IActionResult Delete(int id)
            {
                _productService.DeleteProductById(id);
                TempData["message"] = "Successfully deleted product";
                return RedirectToAction("Index");

            }

            private string UploadedFile(ProductViewModel model)
            {
                string uniqueFileName = null;

                if (model.Image != null)
                {
                    string uploadsFolder = Path.Combine(_hostEnvironment.WebRootPath, "images");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    using (var fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Image.CopyTo(fileStream);
                    }
                }
                return uniqueFileName;
            }
        }
    }


