using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBack.Models;
using CityBack.Helpers;
using CityBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CityBack.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Login()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM login)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            if (!ModelState.IsValid)
            {
                return View(login);
            }
            AppUser loginUser = await _userManager.FindByEmailAsync(login.Email);
            if (loginUser == null){

                ModelState.AddModelError("", "Email or Password is wrong");
                return View(login);
            }
            if (!loginUser.Activated)
            {
                ModelState.AddModelError( "", "Please wait Activation");
                return View();

            }

            var signInResult = await _signInManager.PasswordSignInAsync(loginUser,login.Password,login.RememberMe,true);
            if (!signInResult.Succeeded)
            {
                ModelState.AddModelError("", "Email or Password is wrong");
                return View(login);
            }

            string role = (await _userManager.GetRolesAsync(loginUser))[0];

            if (role == Helper.Roles.Admin.ToString()){

                return RedirectToAction("Index", "Dashboard",new { area="CityListingAdmin"});
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
          
        }
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterVM register)
        {
            if (User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Index", "Home");
            }

            if (!ModelState.IsValid) return View();
            AppUser user = new AppUser
            {
                Fullname = register.Fullname,
                Email = register.Email,
                UserName = register.Username,
                Activated = false
                
            };

            IdentityResult identityResult = await _userManager.CreateAsync(user, register.Password);

            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError("",error.Description);
                }
                return View(register);
            }
            await _userManager.AddToRoleAsync(user, Helper.Roles.Member.ToString());
            //await _signInManager.SignInAsync(user,true);
            ModelState.AddModelError("", "Successfully registrated ,please wait activation ");
            return View();
        }

        public async Task<IActionResult> Logout()
        {
           await _signInManager.SignOutAsync();

            return RedirectToAction("Index","Home");
        }


        //public async Task CreateRole()
        //{
        //    if (! await  _roleManager.RoleExistsAsync("Admin" ))
        //      await   _roleManager.CreateAsync(new IdentityRole { Name = "Admin" });

        //    if (!await _roleManager.RoleExistsAsync("Moderator"))
        //       await  _roleManager.CreateAsync(new IdentityRole { Name = "Moderator" });

        //    if (!await _roleManager.RoleExistsAsync("Member"))
        //       await _roleManager.CreateAsync(new IdentityRole { Name = "Member" });
        //}
    }
}