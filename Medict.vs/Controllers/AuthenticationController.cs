using Medict.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Medict.Controllers
{
    public class AuthenticationController : Controller
    {
        private readonly UserManager<IdentityUser> _securityManager;
        private readonly SignInManager<IdentityUser> _loginManager;
   

        public AuthenticationController(UserManager<IdentityUser> secMgr, SignInManager<IdentityUser> loginManager, ILogger<AuthenticationController> logger)
        {
            _securityManager = secMgr;
            _loginManager = loginManager;
           

        }

        [HttpGet]
       
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]

        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = new IdentityUser() { UserName = model.UserName, Email = model.Email };
                var result = await _securityManager.CreateAsync(user, model.Password);

                if (result.Succeeded)
                {
                    return RedirectToAction("Login", "Authentication");
                }
            }
            return View(model);
        }


        public IActionResult Login(string returnUrl)
        {
            return View(new LoginViewModel
            {
                ReturnUrl = returnUrl
            });
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            var user = await _securityManager.FindByNameAsync(model.UserName);
            if (user != null)
            {
                var result = await _loginManager.PasswordSignInAsync(user, model.Password, false, false);
                if (result.Succeeded)
                {
                    if (string.IsNullOrEmpty(model.ReturnUrl))
                        return RedirectToAction("Create", "Product");

                    return Redirect(model.ReturnUrl);
                }
            }

            ModelState.AddModelError("", "Username/password not found");
            return View(model);

        }
       

      


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _loginManager.SignOutAsync();
            return RedirectToAction("Login", "Authentication");
        }

        [HttpGet]
        public IActionResult ListUsers()
        {
            var user= _securityManager.Users;
            return View(user);
        }
    }

}



