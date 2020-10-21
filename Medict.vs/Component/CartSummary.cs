using Medict.Models;
using Medict.Viewmodels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Component
{
    public class CartSummary : ViewComponent
    {

        private readonly ShoppingCart _shoppingCart;
        public CartSummary(ShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
           // var items = _shoppingCart.GetCartItems();
            var items = new List<ShoppingCartItem>() { new ShoppingCartItem(), new ShoppingCartItem() };

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetCartTotal()
            };
            return View(shoppingCartViewModel);
        }
    }
}
