﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using MOJA.Mobile.Admin.Endpoint.mvc.Models.Account;
using MOJA.MobileStore.Infrastructure.Services.Persons.Queries.SignInPerson;

namespace MOJA.Mobile.Admin.Endpoint.mvc.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private ISignInPersonService _signInPersonService;

        public AccountController(ISignInPersonService signInPersonService)
        {
            _signInPersonService = signInPersonService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [AllowAnonymous]
        [HttpGet]
        public IActionResult SignIn(string returnUrl = "/")
        {
            return View(new SignInAdminViewModel { ReturnUrl = returnUrl });
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInAdminViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }
            var admin = new SignInAdminVMMapper().To(vm);
            var result = await _signInPersonService.ExecuteAsync(admin);
            if (!result.IsSuccessed)
            {
                ModelState.AddModelError(string.Empty, result.Message);
                return View(vm);
            }
            return Redirect(vm.ReturnUrl);
        }
    }
}
