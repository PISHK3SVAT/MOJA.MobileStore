using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MOJA.MobileStore.Domain.Entities.Users.Customers
{
    public class Customer:Person
    {
        public List<CustomerAddress> Addresses { get; set; } = new();
        //public List<Order>? Orders { get; set; }
        //public List<Comment>? Comments { get; set; }
    }
    public class CustomerAddress
    {
        public long Id { get; set; }
        public Customer Owner { get; set; } = new Customer();
        public string Address { get; set; } = string.Empty;
        public StateOC State { get; set; } = new StateOC();
        public City City { get; set; } = new City();
        public short Plaque { get; set; }
        public short? Unit { get; set; }
        public string PostalCode { get; set; } = string.Empty;
    }
    public class City
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public StateOC State { get; set; } = new StateOC();
    }
    public class StateOC
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<City> Cities { get; set; } = new List<City>();
    }
}
