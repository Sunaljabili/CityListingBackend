using CityBack.DAL;
using CityBack.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.ViewComponents
{
    public class ExploreViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;

        public ExploreViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            Explore explore = _db.Explores.FirstOrDefault();
            return View( await Task.FromResult(explore));

            
        }
    }
}
