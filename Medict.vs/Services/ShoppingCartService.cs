//using Medict.Models;
//using Medict.Repository;
//using Microsoft.AspNetCore.Http;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.Extensions.DependencyInjection;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace Medict.Services
//{
//    public class ShoppingCartService
//    {
//        private readonly IRepositoryBase<ShoppingCart> _shoppingCartRepository;
//        private readonly ApplicationContext _applicationContext;
//        private ShoppingCartService(ApplicationContext applicationContext, IRepositoryBase<ShoppingCart> shoppingCartRepository)
//        {
//            _applicationContext = applicationContext;
//            _shoppingCartRepository = shoppingCartRepository;
//        }

//        public ShoppingCartService(ApplicationContext app)
//        {
//        }

//        public string ShoppingCartId { get; set; }

//        public List<ShoppingCart> ShoppingCarts { get; set; }

//        public static ShoppingCart GetCart(IServiceProvider services)
//        {
//            ISession session = services.GetRequiredService<IHttpContextAccessor>()?
//                .HttpContext.Session;

//            var context = services.GetService<ApplicationContext>();
//            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();

//            session.SetString("CartId", cartId);

//            return new ShoppingCart(context) { ShoppingCartId = cartId };
//        }

//        public void AddToCart(Product product, int amount)
//        {
//            var CartItem =
//                      _applicationContext.shoppingCarts.SingleOrDefault(
//                         s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

//            if (CartItem == null)
//            {
//                CartItem = new ShoppingCart
//                {
//                    ShoppingCartId = ShoppingCartId,
//                    Product = product,
//                    Amount = 1
//                };

//                _applicationContext.shoppingCarts.Add(CartItem);
//            }
//            else
//            {
//                CartItem.Amount++;
//            }
//            _applicationContext.SaveChanges();
//        }

//        public int RemoveFromCart(Product product)
//        {
//            var CartItem =
//                     _applicationContext.shoppingCarts.SingleOrDefault(
//                        s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

//            var localAmount = 0;

//            if (CartItem != null)
//            {
//                if (CartItem.Amount > 1)
//                {
//                    CartItem.Amount--;
//                    localAmount = CartItem.Amount;
//                }
//                else
//                {
//                    _applicationContext.shoppingCarts.Remove(CartItem);
//                }
//            }

//            _applicationContext.SaveChanges();

//            return localAmount;
//        }

//        public List<ShoppingCart> GetCartItems()
//        {
//            return ShoppingCarts ??
//                   (ShoppingCarts =
//                       _applicationContext.shoppingCarts.Where(c => c.ShoppingCartId == ShoppingCartId)
//                           .Include(s => s.Product)
//                           .ToList());
//        }

//        public void ClearCart()
//        {
//            var cartItems = _applicationContext
//                .shoppingCarts
//                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

//            _applicationContext.shoppingCarts.RemoveRange(cartItems);

//            _applicationContext.SaveChanges();
//        }

//        public decimal GetCartTotal()
//        {
//            var ShoppingCartTotal = _applicationContext.shoppingCarts.Where(c => c.ShoppingCartId == ShoppingCartId)
//                .Select(c => c.Product.Price * c.Amount).Sum();
//            return (decimal)ShoppingCartTotal;
//        }
//    }
//}
    