﻿using CityBack.DAL;
using CityBack.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.ViewComponents
{
    public class FooterViewComponent:ViewComponent
    {

        private readonly AppDbContext _db;

        public FooterViewComponent(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            Bio bio = _db.Bios.FirstOrDefault();
            return View(await Task.FromResult(bio));


        }
    }
}
