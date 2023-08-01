using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Application.Services.Products.UriComposer
{
    public class UriComposer
    {
        public static string ComposeImageUri(string src)
        {
            return "https://localhost:7051/" + src;
        }
    }
}
