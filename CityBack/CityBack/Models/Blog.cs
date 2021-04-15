using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string HeadTitle { get; set; }

        [MaxLength(50)]
        public string  Title { get; set; }
        [Required]
        public string BlogImage { get; set; }
        [MaxLength(50)]
        public string BlogTittle { get; set; }
        [MaxLength(150)]
        public string BlogDescription { get; set; }
        public DateTime DateTime { get; set; }
        public string PostedBy { get; set; }
        
    }
}
