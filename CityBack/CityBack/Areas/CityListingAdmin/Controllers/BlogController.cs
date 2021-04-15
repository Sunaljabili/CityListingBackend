using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using CityBack.DAL;
using CityBack.Extention;
using CityBack.Helpers;
using CityBack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace CityBack.Areas.CityListingAdmin.Controllers
{
    [Area("CityListingAdmin")]
    [Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        [Obsolete]
        private readonly IHostingEnvironment _env;
        private readonly IHttpContextAccessor _contextAccessor;

        [Obsolete]
        public BlogController(AppDbContext db, IHostingEnvironment env, IHttpContextAccessor contextAccessor)
        {
            _db = db;
            _env = env;
            _contextAccessor = contextAccessor;
        }
        #region Index
        public IActionResult Index()
        {
            return View(_db.BlogPosts.ToList());
        }
        #endregion

        #region Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Create(BlogPost blogPost)
        {

            

            if (!blogPost.Photo.IsImage("image/"))
            {
                ModelState.AddModelError("Photo", "Please select image format!");
                return View();
            }

            if (blogPost.Photo.MaxLenth(600))
            {
                ModelState.AddModelError("Photo", "Image max size must be 300kb!");
                return View();
            }


            string fileName = await blogPost.Photo.SaveImages(_env.WebRootPath, "assets/img/blog");

            blogPost.Image = fileName;
            blogPost.DateTime = DateTime.Now;
            await _db.AddAsync(blogPost);
            await _db.SaveChangesAsync();

            List<SubscribedUsers> subscribedUsers = _db.SubscribedUsers.Where(s => s.Actived).ToList();

            foreach (SubscribedUsers user in subscribedUsers)
            {
                string url = _contextAccessor.HttpContext.Request.Scheme + System.Uri.SchemeDelimiter + _contextAccessor.HttpContext.Request.Host.Value + "/reset/unsubscribe/" + user.ActiveCode;
                MailMessage message = new MailMessage();
                message.From = new MailAddress("sunalsj@code.edu.az", "City Listing");
                message.To.Add(new MailAddress(user.Email));

                message.Subject = "New Blog News!";
                message.Body = "We have a new blog news go to site for check him! if you want to unsubscribe notification <a href='" + url + "'>click</a>";
                message.IsBodyHtml = true;
                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                smtp.Credentials = new NetworkCredential("sunalsj@code.edu.az", "Su!nal123456@");
                smtp.Send(message);
            }
            return RedirectToAction(nameof(Index));


        }

        #endregion

        #region Read
        public IActionResult Info(int? id)
        {
            if (id == null) return NotFound();
            BlogPost blogPost = _db.BlogPosts.FirstOrDefault(b => b.Id == id);
            if (blogPost == null) return NotFound();
            return View(blogPost);
        }
        #endregion

        #region Update
        public IActionResult Update(int? id)
        {
            if (id == null) return NotFound();
            BlogPost blogPost = _db.BlogPosts.FirstOrDefault(b=>b.Id==id);
            if (blogPost == null) return NotFound();
            return View(blogPost);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Obsolete]
        public async Task<IActionResult> Update(int? id, BlogPost blogPost)
        {
            if (id == null) return NotFound();

            BlogPost blogPostDb = _db.BlogPosts.FirstOrDefault(b => b.Id == id);

            if (blogPostDb == null) return NotFound();


            if (blogPost.Photo != null)
            {
                if (!blogPost.Photo.IsImage("image/"))
                {
                    ModelState.AddModelError("Photo", "Please select image format!");
                    return View();
                }

                if (blogPost.Photo.MaxLenth(600))
                {
                    ModelState.AddModelError("Photo", "Image max size must be 600kb!");
                    return View();
                }
                string fileName = await blogPost.Photo.SaveImages(_env.WebRootPath, "assets/img/blog");

                Helper.DeleteImg(_env.WebRootPath, "assets/img/blog", blogPostDb.Image);
                blogPostDb.Image = fileName;
            }
            blogPostDb.PostDescription = blogPost.PostDescription;
            blogPostDb.PostTitle = blogPost.PostTitle;
            blogPostDb.BlogDescription = blogPost.BlogDescription;
            blogPostDb.BlogDetailLink = blogPost.BlogDetailLink;
            blogPostDb.BlogNews = blogPost.BlogNews;
            blogPostDb.BlogText = blogPost.BlogText;
             _db.BlogPosts.Update(blogPostDb);
            await _db.SaveChangesAsync();

            

            return RedirectToAction(nameof(Index));



           
        }
        #endregion

        #region Delete
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return NotFound();
            BlogPost blogPost = await _db.BlogPosts.FindAsync(id);
            if (blogPost == null) return NotFound();
            return View(blogPost);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null) return NotFound();
            BlogPost blogPost = _db.BlogPosts.FirstOrDefault();
            if (blogPost == null) return NotFound();
            _db.BlogPosts.Remove(blogPost);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        #endregion
    }
}