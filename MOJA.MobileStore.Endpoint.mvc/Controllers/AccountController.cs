using Humanizer;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using MOJA.MobileStore.Domain.Entities.Users;
using MOJA.MobileStore.Endpoint.mvc.Models.Account;
using MOJA.MobileStore.Infrastructure.Services.Persons.Commands.CreatePerson;
using MOJA.MobileStore.Infrastructure.Services.Persons.Commands.SignOutPerson;
using MOJA.MobileStore.Infrastructure.Services.Persons.Queries.SignInPerson;

namespace MOJA.MobileStore.Endpoint.mvc.Controllers
{
    public class AccountController : Controller
    {
        private ICreateCustomerService _createPersonService;
        private ISignInPersonService _signInPersonService;
        private ISignOutPersonService _signOutPersonService;
        public AccountController(ICreateCustomerService createPersonService,
            ISignInPersonService signInPersonService,
            ISignOutPersonService signOutPersonService)
        {
            _createPersonService = createPersonService;
            _signInPersonService = signInPersonService;
            _signOutPersonService = signOutPersonService;
        }

        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCustomer(CreateCustomerViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            var dto = new CreateCustomerVMMapper().To(vm);
            var result =await _createPersonService.ExecuteAsync(dto);
            if (!result.IsSuccessed)
            {
                ModelState.AddModelError(string.Empty, result.Message);
                return View(vm);
            }
            await _signInPersonService.ExecuteAsync(new RequestSignInPersonDto
            {
                Email = vm.Email,
                IsPersistence = false,
                Password = vm.Password,
            });
            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult SignIn(string returnUrl="/")
        {
            return View(new SignInCustomerViewModel { ReturnUrl=returnUrl});
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInCustomerViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            var person = new SignInCustomerVMMapper().To(vm);
            var result = await _signInPersonService.ExecuteAsync(person);
            if (!result.IsSuccessed)
            {
                ModelState.AddModelError(string.Empty, result.Message);
                return View(vm);
            }
            return Redirect(vm.ReturnUrl);
        }
        [Authorize]
        public new async Task<IActionResult> SignOut()
        {
            await _signOutPersonService.ExecuteAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
