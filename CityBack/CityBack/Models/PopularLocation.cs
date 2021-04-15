using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Models
{
    public class PopularLocation
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string HeadTitle { get; set; }

        [ MaxLength(30)]
        public string Title { get; set; }

        [Required]
        public string Image { get; set; }

        [Required,MaxLength(50)]
        public string CityName { get; set; }

        public string CityCount { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }

        public int FeaturedCategoryId { get; set; }

        public virtual FeaturedCategory FeaturedCategory { get; set; }
    }
}
