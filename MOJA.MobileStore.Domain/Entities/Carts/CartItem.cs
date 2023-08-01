using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Domain.Base;
using MOJA.MobileStore.Domain.Entities.Products;

namespace MOJA.MobileStore.Domain.Entities.Carts
{
    public class CartItem:BaseEntity<long>
    {
        public long CartId { get; set; }
        public Cart Cart { get; set; } = new();
        public long ProductId { get; set; }
        public Product Product { get; set; } = new();
        public int Count { get; set; }
    }
}
