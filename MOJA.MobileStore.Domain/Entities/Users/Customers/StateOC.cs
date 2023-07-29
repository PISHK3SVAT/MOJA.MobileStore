namespace MOJA.MobileStore.Domain.Entities.Users.Customers
{
    public class StateOC
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public List<City> Cities { get; set; } = new List<City>();
        public List<CustomerAddress>? CustomerAddresses  { get; set; }
    }
}
