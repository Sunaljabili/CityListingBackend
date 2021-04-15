using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Models
{
    public class FeaturedCategory
    {
        public int Id { get; set; }
        [MaxLength(80)]
        public string HeadTitle { get; set; }
        [MaxLength(80)]
        public string Title { get; set; }
        public string CatgIcon { get; set; }
        [Required,MaxLength(100)]
        public string CatgTitle { get; set; }
        [MaxLength(200)]
        public string CatgDdescription { get; set; }
        public ICollection<PopularLocation>  PopularLocation { get; set; }
    }
}
