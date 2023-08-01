using Microsoft.EntityFrameworkCore;

using MOJA.MobileStore.Application.Interfaces.Contexts;
using MOJA.MobileStore.Application.Services.Products.UriComposer;
using MOJA.MobileStore.Domain.Entities.Carts;

namespace MOJA.MobileStore.Application.Services.Carts
{
    public class CartService : ICartService
    {
        private readonly IAppDbContext db;

        public CartService(IAppDbContext db)
        {
            this.db = db;
        }

        public void AddItemToBasket(long carttId, long productId, int count = 1)
        {
            var cart = db.Carts.FirstOrDefault(p => p.Id == carttId);
            if (cart == null)
            {
                //throw new Exception("");
                return;
            }
            var product = db.Products.Find(productId);
            cart.AddItem(productId, count);
            db.SaveChanges();
        }

        public CartDto GetBasketForUser(string customerId)
        {
            var cart = db.Carts
                .Include(c => c.CartItems!)
                .ThenInclude(ci => ci.Product)
                .ThenInclude(p => p.Images)
                .FirstOrDefault(c => c.CustomerId == customerId);

            return (cart == null) ? null : new CartDto
            {
                Id = cart!.Id,
                CustomerId = cart!.CustomerId,
                CartItems = cart!.CartItems
                    .Select(c => new CartItemDto
                    {
                        ProductId = c.ProductId,
                        Id = c.Id,
                        Model = c.Product.Model,
                        Count = c.Count,
                        ImageUrl = UriComposer.ComposeImageUri(c?.Product?
                            .Images?.FirstOrDefault()?.PhotoPath ?? ""),
                    })
                    .ToList()!,
            };
        }

        public CartDto GetOrCreateBasketForUser(string customerId)
        {
            var cart = db.Carts.FirstOrDefault(c => c.CustomerId == customerId);
            if (cart == null)
            {
                //return create
            }
            return GetBasketForUser(customerId);
        }

        public bool RemoveItemFromBasket(long ItemId)
        {
            var item = db.CartItems.FirstOrDefault(c => c.Id == ItemId);
            if (item == null)
                return false;
            db.CartItems.Remove(item);
            db.SaveChanges();
            return true;
        }

        public bool SetQuantities(long itemId, int quantity)
        {
            return true;
        }
        private CartDto CreateCarttForUser(string customerId)
        {
            var cart = new Cart
            {
                CustomerId = customerId,
            };
            db.Carts.Add(cart);
            db.SaveChanges();
            return new CartDto
            {
                CustomerId = cart.CustomerId,
                Id = cart.Id,
            };
        }
        public void TransferBasket(string anonymousId, string customerId)
        {
            var anonymousCart = db.Carts
                .Include(p => p.CartItems)
                .FirstOrDefault(p => p.CustomerId == anonymousId);
            if (anonymousCart == null) return;
            var customerCart = db.Carts.FirstOrDefault(c => c.CustomerId == customerId);
            if (customerCart == null)
            {
                customerCart = new Cart
                {
                    CustomerId = customerId,
                };
                db.Carts.Add(customerCart);
            }
            foreach (var item in anonymousCart!.CartItems!)
            {
                customerCart.AddItem(item.ProductId, item.Count);
            }

            db.Carts.Remove(anonymousCart);
            db.SaveChanges();
        }
    }
}
