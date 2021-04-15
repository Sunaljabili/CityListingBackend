using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Models
{
    public class Subscribe
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string HeadTitle { get; set; }

        [MaxLength(50)]
        public string Title { get; set; }
    }
}
