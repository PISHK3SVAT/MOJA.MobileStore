namespace MOJA.MobileStore.Domain.Entities.Users.Customers
{
    public class CustomerAddress
    {
        public long Id { get; set; }
        public string CustomerId { get; set; } = string.Empty;
        public Customer Customer { get; set; } = new Customer();
        public string Address { get; set; } = string.Empty;
        public int StateId { get; set; }
        public StateOC State { get; set; } = new StateOC();
        public int CityId { get; set; }
        public City City { get; set; } = new City();
        public short Plaque { get; set; }
        public short? Unit { get; set; }
        public string PostalCode { get; set; } = string.Empty;
    }
}
