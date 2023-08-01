using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Domain.Base;
using MOJA.MobileStore.Domain.Entities.Users.Customers;

namespace MOJA.MobileStore.Domain.Entities.Products
{
    public class Question : BaseEntity<long>
    {
        public string Body { get; set; } = string.Empty;
        public string CustomerId { get; set; } = string.Empty;
        public Customer Customer { get; set; } = new();
        public long ProductId { get; set; }
        public Product Product { get; set; } = new();
        public List<Answer>? Answers { get; set; }
    }
}
