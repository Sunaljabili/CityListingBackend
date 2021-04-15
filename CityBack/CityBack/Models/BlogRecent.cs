using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Models
{
    public class BlogRecent
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Image { get; set; }

        public string RecentTitle { get; set; }

        public DateTime DateTime { get; set; }
    }
}
