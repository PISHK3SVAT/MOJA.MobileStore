namespace MOJA.MobileStore.Application.Services.Carts
{
    public class CartItemDto
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string Model { get; set; } = string.Empty;
        public int Count { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    }
}
