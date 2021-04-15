using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using CityBack.DAL;
using CityBack.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CityBack.Areas.CityListingAdmin.Controllers
{
    [Area("CityListingAdmin")]
    [Authorize(Roles ="Admin")]
    public class DashboardController : Controller
    {
        public readonly AppDbContext _db;
        public DashboardController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.MessageFromUsers.ToList());
        }

         public async Task<IActionResult> Info(int? id)
        {
            if (id == null) NotFound();
            MessageFromUser message = _db.MessageFromUsers.FirstOrDefault(m => m.Id == id);
            if (message == null) NotFound();
            await _db.SaveChangesAsync();
            return View(message);
        }
        public IActionResult SendEmail()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SendEmail(int id,MessageFromAdmin messageFrom)
        {
            if (ModelState.IsValid)
            {
                var email = _db.MessageFromUsers.FirstOrDefault(u => u.Id == id).Email;
                messageFrom.Email = email;

                MailMessage mail = new MailMessage { };
                mail.From = new MailAddress("sunalsj@code.edu.az","citylisting");
                mail.To.Add(new MailAddress(messageFrom.Email));

                mail.Subject = messageFrom.Subject;
                mail.Body = messageFrom.Message;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.EnableSsl = true;

                smtp.Credentials = new NetworkCredential("sunalsj@code.edu.az", "Su!nal123456@");
                smtp.Send(mail);



            }
            return View();
        }
    }
}