using CityBack.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CityBack.DAL
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
        }
        public DbSet<PopularLocation> PopularLocations { get; set; }
        public DbSet<Explore> Explores { get; set; }
        public DbSet<FeaturedCategory> FeaturedCategories { get; set; }
        public DbSet<Offering> Offerings { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<ClientTestimonial> ClientTestimonials { get; set; }
        public DbSet<Subscribe> Subscribe { get; set; }
        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<BlogRecent> BlogRecents { get; set; }
        public DbSet<BlogTag> BlogTags { get; set; }
        public DbSet<BlogInstagramFeed> BlogInstagramFeeds { get; set; }
        public DbSet<AboutCompany> AboutCompanies { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<MessageFromUser> MessageFromUsers { get; set; }
        public DbSet<Intro> Intros { get; set; }
        public DbSet<SubscribedUsers> SubscribedUsers { get; set; }
        public DbSet<Bio> Bios { get; set; }


    }
}
