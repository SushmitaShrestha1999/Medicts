using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Medict.Models;
using Medict.Services;

namespace Medict.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly ApplicationContext _applicationContext;

        public HomeController(ILogger<HomeController> logger, ApplicationContext applicationContext, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
            _applicationContext = applicationContext;
        }

        public IActionResult Index()
        {
            var model = _productService.GetList();
          return View(model);
          //  return View();

          
        }
        public IActionResult List()
        {
            var model = _productService.GetList();
            return View(model);
            //  return View();


        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Search(string searchString)
        {
            ViewData["CurrentFilter"] = searchString;

            var products = from s in _applicationContext.Products
                           select s;
            if (!String.IsNullOrEmpty(searchString))
            {
                products = products.Where(s => s.Name.Contains(searchString)
                                       );
            }

            return View(products);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
