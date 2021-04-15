using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }

        public bool Activated { get; set; } = false;

    }
}
