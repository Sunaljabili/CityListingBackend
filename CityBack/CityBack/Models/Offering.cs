using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Models
{
    public class Offering
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string  HeadTitle { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
      
        public string Image { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public string Icon { get; set; }
        [MaxLength(150)]
        public string OfferingTitle { get; set; }

        [MaxLength(250)]
        public string OfferingDescription { get; set; }


    }
}
