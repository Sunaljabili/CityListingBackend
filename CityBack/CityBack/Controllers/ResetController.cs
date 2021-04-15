using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBack.DAL;
using CityBack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CityBack.Controllers
{
    public class ResetController : Controller
    {
        private readonly AppDbContext _db;

        public ResetController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {

        
            return View();
        }
        public async Task<IActionResult> Unsubscribe(string id)
        {
            if (id == null) return NotFound();
            SubscribedUsers user = await _db.SubscribedUsers.Where(user => user.ActiveCode == id).FirstOrDefaultAsync();
            if (user == null) return NotFound();
            _db.SubscribedUsers.Remove(user);
            await _db.SaveChangesAsync();
            return RedirectToAction("index", "home");

        }
    }
}