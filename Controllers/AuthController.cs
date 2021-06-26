using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestaurantProjectWithIdentity.Models;
using static RestaurantProjectWithIdendity.Enum.EnumRoles;

namespace RestaurantProjectWithIdentity.Controllers
{  
    public class AuthController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AuthController(UserManager<User> userManager, SignInManager<User> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel model)
        {
           IdentityResult result = await _userManager.CreateAsync(new RestaurantProjectWithIdentity.User { Email = model.Email, 
                FirstName = model.FirstName, UserName = model.UserName, 
                TC = model.TC }, model.Password
                );
            if (result.Succeeded) return RedirectToAction("Login");



            return RedirectToAction("Register");
        }



        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {

            var result = await _signInManager.PasswordSignInAsync(userName, password, false, false);

            if (!result.Succeeded) return RedirectToAction("Login");


            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
           await _signInManager.SignOutAsync();

            return RedirectToAction("Login");
        }

        public async Task<IActionResult> CreateRole()
        {
            await _roleManager.CreateAsync(new IdentityRole()
            {
                Name = Roles.Admin
            });
            return View();
        }
    }
}
