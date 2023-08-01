using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOJA.MobileStore.Application.Services.Carts
{
    public interface ICartService
    {
        CartDto GetOrCreateBasketForUser(string BuyerId);
        void AddItemToBasket(long basketId, long catalogItemId, int quantity = 1);
        bool RemoveItemFromBasket(long ItemId);
        bool SetQuantities(long itemId, int quantity);
        CartDto GetBasketForUser(string UserId);

        void TransferBasket(string anonymousId, string UserId);
    }
}
