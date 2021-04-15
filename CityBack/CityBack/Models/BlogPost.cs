using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Models
{
    public class BlogPost
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string PostTitle { get; set; }

        public string PostDescription { get; set; }

        public DateTime DateTime { get; set; }
        [NotMapped]
        public IFormFile Photo { get; set; }
        public string BlogDetailLink { get; set; }

        public string BlogNews { get; set; }

        public string BlogDescription { get; set; }

        public string BlogText { get; set; }


    }
}
