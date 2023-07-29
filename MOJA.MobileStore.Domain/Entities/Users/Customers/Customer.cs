using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

using MOJA.MobileStore.Domain.Entities.Products;

namespace MOJA.MobileStore.Domain.Entities.Users.Customers
{
    public class Customer:Person
    {
        public List<CustomerAddress> Addresses { get; set; } = new();
        //public List<Order>? Orders { get; set; }
        public List<Comment>? Comments { get; set; }
        public List<Question>? Questions { get; set; }
    }
}
