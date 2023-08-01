using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Domain.Base;
using MOJA.MobileStore.Domain.Entities.Users.Customers;

namespace MOJA.MobileStore.Domain.Entities.Carts
{
    public class Cart:BaseEntity<long>
    {
        public string CustomerId { get; set; } = string.Empty;
        public List<CartItem>? CartItems { get; set; }


        public void AddItem(long productId,int count)
        {
            if (!CartItems.Any(c=>c.ProductId==productId)) 
            {
                CartItems.Add(new CartItem
                {
                    ProductId= productId,
                    Count= count,
                });
                return;
            }
            var item=CartItems.FirstOrDefault(c=>c.ProductId== productId)!;
            item.Count+=count;
        }
    }
}
