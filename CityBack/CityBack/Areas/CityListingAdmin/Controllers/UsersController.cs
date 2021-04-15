using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBack.DAL;
using CityBack.Models;
using CityBack.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CityBack.Areas.CityListingAdmin.Controllers
{
    [Area("CityListingAdmin")]
    public class UsersController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly AppDbContext _db;

        public UsersController(UserManager<AppUser> userManager, AppDbContext db)
        {
            _userManager = userManager;
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> appUsers = _userManager.Users.ToList();
            List<UserVM> userVMs = new List<UserVM>();
            foreach (AppUser user in appUsers)
            {
                UserVM userVM = new UserVM
                {
                    Id = user.Id,
                    Username = user.UserName,
                    Fullname = user.Fullname,
                    Email = user.Email,
                    Activated=user.Activated,
                    Role = ((await _userManager.GetRolesAsync(user))[0])
                };
                userVMs.Add(userVM);
            }
            return View(userVMs);
        }

        public async Task<IActionResult> Activated(string id)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Activated(string id, bool Activated)
        {
            if (id == null) return NotFound();
            AppUser user = await _userManager.FindByIdAsync(id);
            if (user == null) return NotFound();

            user.Activated = Activated;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}