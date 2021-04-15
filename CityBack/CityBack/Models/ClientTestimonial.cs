using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Models
{
    public class ClientTestimonial
    {
        public int Id { get; set; }
        [MaxLength(50)]
        public string HeadTtitle { get; set; }
        [MaxLength(50)]
        public string Title { get; set; }

        [MaxLength(350),Required]
        public string Description { get; set; }
        [Required]
        public string WorkerImage { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
        [MaxLength(70),  Required (ErrorMessage ="Bu input doldurulmalidir!")]
        public string WorkerName { get; set; }
        [MaxLength(70)]
        public string WorkerJob { get; set; }
    }
}
