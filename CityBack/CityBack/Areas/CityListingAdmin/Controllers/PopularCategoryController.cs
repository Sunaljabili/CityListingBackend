using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CityBack.DAL;
using CityBack.Extention;
using CityBack.Helpers;
using CityBack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CityBack.Areas.CityListingAdmin.Controllers
{
    [Area("CityListingAdmin")]
    [Authorize(Roles = "Admin")]
    public class PopularCategoryController : Controller
    {
        private readonly AppDbContext _db;
        [Obsolete]
        private readonly IHostingEnvironment _env;

        [Obsolete]
        public PopularCategoryController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }
        public IActionResult Index()
        {
            return View(_db.PopularLocations.Include(p=>p.FeaturedCategory).ToList());
        }
        public IActionResult Create()
        {
            ViewBag.Category = _db.FeaturedCategories.ToList();
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Create(PopularLocation popular,int Catg)
        {

            ViewBag.Category = _db.FeaturedCategories.ToList();
            if (!popular.Photo.IsImage("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image format!");
                return View();
            }

            if (popular.Photo.MaxLenth(600))
            {
                ModelState.AddModelError("Photo", "Image max size must be 300kb!");
                return View();
            }
            string fileName = await popular.Photo.SaveImages(_env.WebRootPath, "assets/img/gallery");

            popular.Image = fileName;
            popular.FeaturedCategoryId = Catg;
            await _db.AddAsync(popular);
            await _db.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            ViewBag.Category = _db.FeaturedCategories.ToList();
            if (id == null) return NotFound();
            PopularLocation location = _db.PopularLocations.Include(p => p.FeaturedCategory).FirstOrDefault(p => p.Id == id);
            if (location == null) return NotFound();
            return View(location);
           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Update(int? id, PopularLocation popular, int Catg)
        {
            ViewBag.Category = _db.FeaturedCategories.ToList();
            if (id == null) return NotFound();
            PopularLocation locationDb = _db.PopularLocations.Include(p => p.FeaturedCategory).FirstOrDefault(p => p.Id == id);
            if (locationDb == null) return NotFound();
   

            if (popular.Photo != null)
            {
                if (!popular.Photo.IsImage("image"))
                {
                    ModelState.AddModelError("Photo", "Please select image file");
                    return View();
                }
                if (popular.Photo.MaxLenth(600))
                {
                    ModelState.AddModelError("Photo", "Please select max 3mb image");
                    return View();
                }

                string fileName = await popular.Photo.SaveImages(_env.WebRootPath, "assets/img/gallery");
                Helper.DeleteImg(_env.WebRootPath, "assets/img/gallery", locationDb.Image);
                locationDb.Image = fileName;
            }

            locationDb.CityName = popular.CityName;
            locationDb.CityCount = popular.CityCount;
            locationDb.FeaturedCategoryId = Catg;

            _db.PopularLocations.Update(locationDb);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            PopularLocation location = await _db.PopularLocations.FindAsync(id);
            if (location == null) return NotFound();
            return View(location);
           
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteLocation(int? id)
        {
            if (id == null) return NotFound();
            PopularLocation location = _db.PopularLocations.Where(f => f.Id == id).FirstOrDefault();
            if (location == null) return NotFound();
            _db.PopularLocations.Remove(location);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Info(int? id)
        {
            ViewBag.Category = _db.FeaturedCategories.ToList();
            if (id == null) return NotFound();
            PopularLocation popular = _db.PopularLocations.Where(l => l.Id == id).Include(l => l.FeaturedCategory).FirstOrDefault();
            if (popular == null) return NotFound();
            return View(popular);
       ;
        }
    }
}