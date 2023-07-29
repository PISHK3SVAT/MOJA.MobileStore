using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Domain.Base;
using MOJA.MobileStore.Domain.Entities.Users.Customers;

namespace MOJA.MobileStore.Domain.Entities.Products
{
    public class Comment:BaseEntity<long>
    {
        public string? Title { get; set; }
        public string Body { get; set; } = string.Empty;
        public long CustomerId { get; set; }
        public Customer Customer { get; set; } = new Customer();
        public long ProductId { get; set; }
        public Product Product { get; set; } = new Product();
        public DateOnly Date { get; set; }
    }
}
