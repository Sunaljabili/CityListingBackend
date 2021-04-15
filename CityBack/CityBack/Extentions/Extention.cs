using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.Extention
{
    public static class Extention
    {
        public static bool IsImage(this IFormFile file, string fileType)
        {
            return file.ContentType.Contains(fileType);
        }
        public static bool MaxLenth(this IFormFile file, int kb)
        {
            return file.Length / 1024 > kb;
        }
        public async static Task<string> SaveImages(this IFormFile file, string root, string folder)
        {
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string resulthPath = Path.Combine(root, folder, fileName);
            using (FileStream fileStream = new FileStream(resulthPath, FileMode.Create))
            {
                await file.CopyToAsync(fileStream);
            }
            return fileName;
        }
    }
}
