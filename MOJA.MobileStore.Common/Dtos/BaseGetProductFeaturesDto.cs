using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Common.Dtos
{
    public abstract class BaseGetProductFeaturesDto
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
    }
}
