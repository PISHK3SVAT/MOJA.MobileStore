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
        public long CustomerId { get; set; }
        public List<CartItem>? CartItems { get; set; }
    }
}
