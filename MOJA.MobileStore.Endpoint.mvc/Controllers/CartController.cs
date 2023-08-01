using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using MOJA.MobileStore.Application.Services.Carts;
using MOJA.MobileStore.Domain.Entities.Users;

namespace MOJA.MobileStore.Endpoint.mvc.Controllers
{
    [Authorize]
    public class CartController : Controller
    {
        private readonly ICartService _cartService;
        private readonly UserManager<Person> _userManager;
        private readonly SignInManager<Person> _signInManager;
        private string? userId;
        public CartController(ICartService cartService, UserManager<Person> userManager,
            SignInManager<Person> signInManager)
        {
            _cartService = cartService;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var data = GetOrSetBasket();
            return View(data);
        }


        [AllowAnonymous]
        [HttpPost]
        public IActionResult Index(long productId, int count = 1)
        {
            var cart = GetOrSetBasket();
            _cartService.AddItemToBasket(cart.Id, productId, count);
            return RedirectToAction(nameof(Index));
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult RemoveItemFromCartt(long ItemId)
        {
            _cartService.RemoveItemFromBasket(ItemId);
            return RedirectToAction(nameof(Index));
        }

        private CartDto GetOrSetBasket()
        {
            if (_signInManager.IsSignedIn(User))
            {
                userId = Utilities.ClaimUtility.GetUserId(User);
                return _cartService.GetOrCreateBasketForUser(userId);
            }
            else
            {
                SetCookiesForBasket();
                return _cartService.GetOrCreateBasketForUser(userId);
            }
        }
        private void SetCookiesForBasket()
        {
            string carttCookieName = "CartId";
            if (Request.Cookies.ContainsKey(carttCookieName))
            {
                userId = Request.Cookies[carttCookieName];
            }
            if (userId != null) return;
            userId = Guid.NewGuid().ToString();
            var cookieOptions = new CookieOptions { IsEssential = true };
            cookieOptions.Expires = DateTime.Today.AddYears(2);
            Response.Cookies.Append(carttCookieName, userId, cookieOptions);


        }
    }
}
