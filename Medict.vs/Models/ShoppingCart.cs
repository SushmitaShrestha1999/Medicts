using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Models
{
    public class ShoppingCart
    {
        private readonly ApplicationContext _applicationContext;
        public ShoppingCart(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }


        public string ShoppingCartId { get; set; }
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }

        public static ShoppingCart GetCart(IServiceProvider services)
        {
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<ApplicationContext>();
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            session.SetString("CartId", cartId);
            return new ShoppingCart(context) { ShoppingCartId = cartId };
        }


        public void AddToCart(Product product, int amount)
        {
            var shoppingCartItem =
                      _applicationContext.ShoppingCartItems.SingleOrDefault(
                         s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new ShoppingCartItem
                {
                    ShoppingCartId = ShoppingCartId,
                    Product = product,
                    Amount = 1
                };

                _applicationContext.ShoppingCartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Amount++;
            }
            _applicationContext.SaveChanges();
        }

        public int RemoveFromCart(Product product)
        {
            var ShoppingCartItem =
                     _applicationContext.ShoppingCartItems.SingleOrDefault(
                        s => s.Product.ProductId == product.ProductId && s.ShoppingCartId == ShoppingCartId);

            var localAmount = 0;

            if (ShoppingCartItem != null)
            {
                if (ShoppingCartItem.Amount > 1)
                {
                    ShoppingCartItem.Amount--;
                    localAmount = ShoppingCartItem.Amount;
                }
                else
                {
                    _applicationContext.ShoppingCartItems.Remove(ShoppingCartItem);
                }
            }

            _applicationContext.SaveChanges();

            return localAmount;
        }

        public List<ShoppingCartItem> GetCartItems()
        {
            return ShoppingCartItems ??
                   (ShoppingCartItems =
                       _applicationContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                           .Include(s => s.Product)
                           .ToList());
        }

        public void ClearCart()
        {
            var cartItems = _applicationContext
                .ShoppingCartItems
                .Where(cart => cart.ShoppingCartId == ShoppingCartId);

            _applicationContext.ShoppingCartItems.RemoveRange(cartItems);

            _applicationContext.SaveChanges();
        }

        public decimal GetCartTotal()
        {
            var ShoppingCartTotal = _applicationContext.ShoppingCartItems.Where(c => c.ShoppingCartId == ShoppingCartId)
                .Select(c => c.Product.Price * c.Amount).Sum();
            return (decimal)ShoppingCartTotal;
        }
    }
}
