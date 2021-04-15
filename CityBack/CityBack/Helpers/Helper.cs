using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Helpers
{
    public static class Helper
    {
        public static void DeleteImg(string root, string folder, string image)
        {
            string deletedPath = Path.Combine(root, folder, image);
            if (System.IO.File.Exists(deletedPath))
            {
                System.IO.File.Delete(deletedPath);
            }
        }
        public enum Roles
        {
            Admin,
            Moderator,
            Member
        }
    }
}
