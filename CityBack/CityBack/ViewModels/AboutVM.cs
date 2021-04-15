using System;
using CityBack.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.ViewModels
{
    public class AboutVM
    {
        public IEnumerable<AboutCompany> AboutCompanies { get; set; }
        public AboutCompany AboutCompany { get; set; }
    }
}
