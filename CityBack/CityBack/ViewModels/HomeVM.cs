using CityBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<PopularLocation> PopularLocations { get; set; }
        public PopularLocation PopularLocation { get; set; }

        public IEnumerable<Explore> Explores { get; set; }
        public Explore Explore { get; set; }

        public IEnumerable<FeaturedCategory> FeaturedCategories { get; set; }
        public FeaturedCategory FeaturedCategory { get; set; }


        public IEnumerable<Offering> Offerings { get; set; }

        public Offering Offering { get; set; }


        public IEnumerable<ClientTestimonial> ClientTestimonials { get; set; }

        public ClientTestimonial ClientTestimonial { get; set; }

        public Subscribe Subscribe { get; set; }

        public Intro Intro { get; set; }

    }
}
