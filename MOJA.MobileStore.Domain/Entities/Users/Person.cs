using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Identity;

namespace MOJA.MobileStore.Domain.Entities.Users
{
    public class Person : IdentityUser
    {
        public string Name { get; set; } = "";
        public string Family { get; set; } = "";
        public string? NationalCode { get; set; }
        public string? ProfilePhotoPath { get; set; }
    }
}
