using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBack.DAL;
using CityBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CityBack.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;

        public AboutController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            AboutVM aboutVM = new AboutVM
            {
                AboutCompanies = _db.AboutCompanies,
                AboutCompany=_db.AboutCompanies.FirstOrDefault()
            };
            return View(aboutVM);
        }
    }
}