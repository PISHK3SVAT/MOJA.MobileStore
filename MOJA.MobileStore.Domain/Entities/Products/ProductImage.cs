using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Domain.Entities.Products
{
    public class ProductImage
    {
        public long Id { get; set; }
        public string PhotoPath { get; set; } = string.Empty;
        public long ProductId { get; set; }
        public Product Product { get; set; } = new();
    }
}
