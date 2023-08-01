namespace MOJA.MobileStore.Application.Services.Carts
{
    public class CartDto
    {
        public long Id { get; set; }
        public string CustomerId { get; set; } = string.Empty;
        public List<CartItemDto> CartItems { get; set; } = new();
    }
}
