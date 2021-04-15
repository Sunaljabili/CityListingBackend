using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBack.DAL;
using CityBack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CityBack.Areas.CityListingAdmin.Controllers
{
    [Area("CityListingAdmin")]
    [Authorize(Roles = "Admin")]
    public class ExploreController : Controller
    {
        private readonly AppDbContext _db;

        public ExploreController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Explores);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null) return NotFound();
            Explore explore = await _db.Explores.FindAsync(id);
            if (explore == null) return NotFound();
            return View(explore);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Create(Explore explore)
        {
            if (!ModelState.IsValid) return View(explore);

            return Content(explore.CategoryTitle + " " + explore.ChooseCategory);


            //bool isExist = _db.Explores.Any(e => e.ChooseCategory.ToLower() == explore.ChooseCategory.ToLower());
            //if (isExist)
            //{
            //    ModelState.AddModelError("ChooseCategory", "Bu adda bashliq var");
            //    return View();
            //}
            //await _db.Explores.AddAsync(explore);
            //await _db.SaveChangesAsync();
            //return RedirectToAction(nameof(Index));

        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            Explore explore = await _db.Explores.FindAsync(id);
            if (explore == null) return NotFound();
            return View(explore);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(int? id, Explore explore)
        {
            if (id == null) return NotFound();

            Explore exploreDb = await _db.Explores.FindAsync(id);

            if (exploreDb == null) return NotFound();

            if (exploreDb.ChooseCategory.ToLower() != explore.ChooseCategory.ToLower())
            {
                bool isExist = _db.Explores.Any(e => e.ChooseCategory.ToLower() == explore.ChooseCategory.ToLower());
                if (isExist)
                {
                    ModelState.AddModelError("ChooseCategory", "Bu adda bashliq var");
                    return View();
                }
            }
            exploreDb.ChooseCategory = explore.ChooseCategory;
            exploreDb.CategoryTitle = explore.CategoryTitle;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


        public async  Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            Explore explore = await _db.Explores.FindAsync(id);
            if (explore == null) return NotFound();
            return View(explore);
     
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {

            if (id == null) return NotFound();
            Explore explore = await _db.Explores.FindAsync(id);
            if (explore == null) return NotFound();
            _db.Explores.Remove(explore);
            await  _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}