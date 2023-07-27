using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MOJA.MobileStore.Domain.Base;
using MOJA.MobileStore.Domain.Entities.Users;

namespace MOJA.MobileStore.Domain.Entities.Products
{
    //shadow propperty for question
    public class Answer : BaseEntity<long>
    {
        public string Body { get; set; } = "";

        //Both Admin and Customer can answer questions
        public long OwnerId { get; set; }
        public Person Owner { get; set; } = new Person();
    }
}
