using Medict.Helpers;
using Medict.Models;
using Medict.Services;
using Medict.Viewmodels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;

namespace Medict.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IProductService _productService;
       
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(IProductService productService, ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
            _productService = productService;
        }  

        public ViewResult Index()
        {
            var items = _shoppingCart.GetCartItems();
           // _shoppingCart.ShoppingCartItems = items;
          //  _shoppingCart.GetShoppingCartItems();

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetCartTotal()
            };
            return View(shoppingCartViewModel);
        }



        public IActionResult AddToShoppingCart(int productid)
        {
            //  var selectedProduct = _productService.Products.FirstOrDefault(p => p.ProductId == productId);
            var selectedProduct = _productService.GetById(productid);
            if (selectedProduct != null)
            {
                _shoppingCart.AddToCart(selectedProduct, 1);
            }
            return RedirectToAction("Index");
        }

        

    public IActionResult RemoveFromShoppingCart(int productid)
        {
            //var selectedProduct = _productService.Products.FirstOrDefault(p => p.ProductId == productId);
            var selectedProduct = _productService.GetById(productid);
            if (selectedProduct != null)
            {
                _shoppingCart.RemoveFromCart(selectedProduct);
            }
            return RedirectToAction("Index");
        }
       

    }
}






