using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Models
{
    public class MessageFromUser
    {
        public int Id { get; set; }

        public string Name { get; set; }
        [Required(ErrorMessage = "Please,add your Email"), EmailAddress]
        public string Email { get; set; }
        public string Subject { get; set; }

        [Required(ErrorMessage = "Please,add your Message")]
        public string Message { get; set; }
    }
}
