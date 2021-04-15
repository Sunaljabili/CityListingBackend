using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBack.DAL;
using CityBack.Models;
using CityBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CityBack.Controllers
{
    public class ContactController : Controller
    {

        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(MessageFromUser  user)
        {
            if (ModelState.IsValid) 
            {
                _db.MessageFromUsers.Add(user);
                await _db.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View();
        }
    }
}