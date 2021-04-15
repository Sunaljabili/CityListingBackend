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
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;

        public BlogController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            BlogVM blogVM = new BlogVM
            {
                BlogCategories = _db.BlogCategories,
                BlogCategory = _db.BlogCategories.FirstOrDefault(),

                BlogPosts = _db.BlogPosts,
                BlogPost = null,

                BlogRecents=_db.BlogRecents,
                BlogRecent=_db.BlogRecents.FirstOrDefault(),

                BlogTags=_db.BlogTags,
                BlogTag=_db.BlogTags.FirstOrDefault()

            };
            return View(blogVM);
        }
        public IActionResult BlogDetails(int? id)
        {

            BlogVM blogVM = new BlogVM
            {
                BlogPosts = _db.BlogPosts,
                BlogPost=_db.BlogPosts.FirstOrDefault(b => b.Id == id)
            };
            return View(blogVM);
        }
       
        public async Task<IActionResult> Subscribe(SubscribedUsers sub)
        {
            if (ModelState.IsValid)
            {
                _db.SubscribedUsers.Add(sub);
                sub.ActiveCode = Guid.NewGuid().ToString();
                sub.Actived = true;
                await _db.SaveChangesAsync();
                return Json("Success!");
            }
            string errors = "";
            foreach (var item in ModelState.Values)
            {
                foreach (var error in item.Errors)
                {
                    errors += error.ErrorMessage;
                }
            }
            return Json(errors);
        }


        public IActionResult Search(string search)
        {
            IEnumerable<BlogPost> blogPosts = _db.BlogPosts.Where(p => p.PostTitle.ToLower().Contains(search.ToLower()))
            .OrderByDescending(p => p.Id).Take(10);

            return PartialView("_BlogPostSearch",blogPosts);
        }
    }
}