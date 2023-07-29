namespace MOJA.MobileStore.Domain.Entities.Users.Customers
{
    public class City
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public int StateOCId { get; set; }
        public StateOC State { get; set; } = new StateOC();
    }
}
