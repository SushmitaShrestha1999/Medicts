//using Medict.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Medict.Services
//{
//    public class OrderService : IOrderService
//    {
//        private readonly ApplicationContext _applicationContext;
//        private readonly ShoppingCart _shoppingCart;

//        public OrderService(ApplicationContext applicationContext, ShoppingCart shoppingCart)
//        {
//            _applicationContext = applicationContext;
//            _shoppingCart = shoppingCart;
//        }


//        public void CreateOrder(Order order)
//        {
//            order.OrderDate = DateTime.Now;

//            _applicationContext.Orders.Add(order);

//            var ShoppingCartItems = _shoppingCart.ShoppingCartItemId;

//            foreach (var shoppingCartItem in ShoppingCartItems)
//            {
//                var orderDetail = new OrderDetail()
//                {
//                    Amount = shoppingCartItem.Amount,
//                    ProductId = shoppingCartItem.Product.ProductId,
//                    OrderId = order.OrderId,
//                    Price = (shoppingCartItem.Product.Rate).ToString()
//                };

//                _applicationContext.OrderDetails.Add(orderDetail);
//            }

//            _applicationContext.SaveChanges();
//        }
//    }
//}

