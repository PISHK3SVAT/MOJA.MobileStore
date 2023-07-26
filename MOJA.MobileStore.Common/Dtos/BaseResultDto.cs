using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Common.Dtos
{
    public class BaseResultDto
    {
        public BaseResultDto(bool isSuccessed, string message)
        {
            IsSuccessed = isSuccessed;
            Message = message;
        }

        public bool IsSuccessed { get; set; }
        public string Message { get; set; }
    }
}
