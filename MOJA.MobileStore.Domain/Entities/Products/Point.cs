using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Domain.Base;

namespace MOJA.MobileStore.Domain.Entities.Products
{
    public class Point:BaseEntity<long>
    {
        public long NumberOfparticipants { get; set; }
        public float AvgScore { get; set; }
        //public long ProductId { get; set; }
        public Product Product { get; set; } = new();
    }
}
