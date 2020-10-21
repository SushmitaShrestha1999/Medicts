//using Medict.Models;
//using Medict.Services;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Medict.Controllers
//{
//    public class OrderController
//    {
//        private readonly IOrderService _orderService;
//        private readonly IProductService _productService;
//        private readonly ShoppingCart _shoppingCart;
//        private readonly Mapper _mapper;
//        private static UserManager<IdentityUser> _securityManager;


//        public OrderController(IOrderService orderService, IProductService productService, ShoppingCart shoppingCart, UserManager<IdentityUser> securityManager)
//        {
//            _orderService = orderService;
//            _shoppingCart = shoppingCart;
//            _securityManager = securityManager;
//            _productService = productService;
//            _mapper = new Mapper();
//        }

//        public IActionResult Checkout()
//        {
//            var items = _shoppingCart.GetCartItems();
//            _shoppingCart.ShoppingCartItems = items;
//            if (items.Count() == 0)
//            {
//                ModelState.AddModelError("", "Your cart is empty, add some items first");
//                return RedirectToAction("Index", "Home");
//            }
//            return View();
//        }

//        [HttpPost]
//        public async Task<IActionResult> Checkout(OrderIndexModel model)
//        {
//            var items = _shoppingCart.GetCartItems();
//            _shoppingCart.ShoppingCartItems = items;

//            if (items.Count() == 0)
//            {
//                ModelState.AddModelError("", "Your cart is empty, add some items first");
//                return RedirectToAction("Index", "Home");
//            }

//            if (ModelState.IsValid)
//            {
//                var userId = _securityManager.GetUserId(User);
//                var user = await _securityManager.FindByIdAsync(userId);

//                model.OrderTotal = items.Sum(item => item.Amount * item.Food.Price);
//                var order = _mapper.OrderIndexModelToOrder(model, user);

//                _orderService.CreateOrder(order);
//                _shoppingCart.ClearCart();
//                return RedirectToAction("CheckoutComplete");
//            }

//            return View(model);
//        }

//        public IActionResult CheckoutComplete()
//        {
//            ViewBag.CheckoutCompleteMessage = "Thanks for your order";
//            return View();
//        }
//    }

//}

