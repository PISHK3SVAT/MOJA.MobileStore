using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Domain.Entities.Products.Features
{
    public abstract class BaseProductFeatureEntity<TKey> where TKey : struct
    {
        public TKey Id { get; set; }
        public string Title { get; set; } = "";
        public List<Product>? Products { get; set; }
    }
}
