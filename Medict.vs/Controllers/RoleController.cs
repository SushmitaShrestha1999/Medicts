using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medict.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Medict.Controllers
{
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> roleManager;
        private readonly UserManager<IdentityUser> _securityManager;
        //private readonly SignInManager<IdentityUser> _loginManager;
        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> securityManager)
        {
            this.roleManager = roleManager;
            _securityManager = securityManager;
        }

        public IActionResult Index()
        {
            var roles = roleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await roleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
        public IActionResult CreateUsersRole()
        {
           ViewBag.Roles= roleManager.Roles.ToList();

            return View();
        }

        [HttpPost]
        public  async Task<IActionResult> CreateUsersRole(RoleModel model)
        {
            var user = await _securityManager.FindByNameAsync(model.UserName);
            var response=await _securityManager.AddToRoleAsync(user, model.Role);
            return RedirectToAction("Index");
        }
        

          public async Task<IActionResult> EditRole(string id)
           {
           var role=await roleManager.FindByIdAsync(id);
              
               return View(role);
           }
        [HttpPost]
        public async Task<IActionResult> Delete(string id)
        {
            IdentityRole role = await roleManager.FindByIdAsync(id);
            if (role != null)
            {
                IdentityResult result = await roleManager.DeleteAsync(role);
                if (result.Succeeded)
                    return RedirectToAction("Index");
                
            }
            else
                ModelState.AddModelError("", "No role found");
            return View("Index");
        }

        /* [HttpPost]
          public async Task<IActionResult> EditRole(IdentityRole model)
          {
              var role= await roleManager.UpdateAsync(id);
              TempData["message"] = "Successfully updated product";
              return RedirectToAction("Index");
          }

          public async Task<IActionResult> Delete(string id)
          {
             var role= await roleManager.DeleteAsync(id);
              TempData["message"] = "Successfully deleted product";
              return RedirectToAction("Index");

          }*/

    }
}
