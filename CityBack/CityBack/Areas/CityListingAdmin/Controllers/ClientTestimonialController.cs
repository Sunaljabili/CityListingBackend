using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBack.DAL;
using CityBack.Extention;
using CityBack.Helpers;
using CityBack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CityBack.Areas.CityListingAdmin.Controllers
{
    [Area("CityListingAdmin")]
    [Authorize(Roles = "Admin")]
    public class ClientTestimonialController : Controller
    {
        private readonly AppDbContext _db;
        [Obsolete]
        private readonly IHostingEnvironment _env;

        [Obsolete]
        public ClientTestimonialController(AppDbContext db, IHostingEnvironment env)
        {
            _db = db;
            _env = env;
        }


        public IActionResult Index()
        {
            return View(_db.ClientTestimonials.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async  Task<IActionResult> Create(int id,ClientTestimonial clientTestimonial)
        {
            
            if (ModelState["Photo"].ValidationState == ModelValidationState.Invalid)
            {
                return View();
            }

            if (!clientTestimonial.Photo.IsImage("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image format!");
                return View();
            }

            if (clientTestimonial.Photo.MaxLenth(300))
            {
                ModelState.AddModelError("Photo", "Image max size must be 300kb!");
                return View();
            }

            string fileName = await clientTestimonial.Photo.SaveImages(_env.WebRootPath, "assets/img/blog");

            clientTestimonial.WorkerImage = fileName;
            await _db.AddAsync(clientTestimonial);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Info(int? id)
        {
            if (id == null) return NotFound();
            ClientTestimonial client = await _db.ClientTestimonials.FindAsync(id);
            if (client == null) return NotFound();
            return View(client);
           
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null) return NotFound();
            BlogPost blogPost = await _db.BlogPosts.FindAsync(id);
            if (blogPost == null) return NotFound();
            return View(blogPost);
        }
        
        public IActionResult Update()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }
    }
}