using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Models
{
    public class Explore
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string HeadTitle { get; set; }

        [MaxLength(30)]
        public string Title { get; set; }

        [Required]
        public string Icon { get; set; }

        [Required(ErrorMessage ="Bu input doldurulmalidir!"),MaxLength(100)]
        public string ChooseCategory { get; set; }

        [MaxLength(300)]
        public string CategoryTitle { get; set; }

    }
}
