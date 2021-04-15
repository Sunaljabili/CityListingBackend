using CityBack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.ViewModels
{
    public class BlogVM
    {
        public IEnumerable<BlogPost> BlogPosts { get; set; }
        public BlogPost BlogPost { get; set; }


        public IEnumerable<BlogCategory> BlogCategories { get; set; }
        public BlogCategory BlogCategory { get; set; }

        public IEnumerable<BlogRecent> BlogRecents { get; set; }
        public BlogRecent BlogRecent { get; set; }

        public IEnumerable<BlogTag> BlogTags { get; set; }
        public BlogTag BlogTag { get; set; }

       

    }
}
