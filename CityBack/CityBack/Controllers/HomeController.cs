using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBack.DAL;
using CityBack.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace CityBack.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;

        public HomeController(AppDbContext db)
        {
            _db = db;
        }

   
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                PopularLocations = _db.PopularLocations,
                PopularLocation=_db.PopularLocations.FirstOrDefault(),

                Explores=_db.Explores,
                Explore=_db.Explores.FirstOrDefault(),

                FeaturedCategories=_db.FeaturedCategories,
                FeaturedCategory=_db.FeaturedCategories.FirstOrDefault(),

                Offerings=_db.Offerings,
                Offering=_db.Offerings.FirstOrDefault(),

                ClientTestimonials=_db.ClientTestimonials,
                ClientTestimonial=_db.ClientTestimonials.FirstOrDefault(),

                Intro= _db.Intros.FirstOrDefault()


            };
            return View(homeVM);

        }

        public IActionResult LocationCategory()
        {
            return View(_db.PopularLocations.ToList());
        }
    }
}