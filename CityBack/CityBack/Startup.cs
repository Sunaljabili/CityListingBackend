using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CityBack.DAL;
using CityBack.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CityBack
{
    public class Startup
    {
        private readonly IConfiguration _config;
        public Startup(IConfiguration config)
        {
            _config = config;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options=>
            {
                options.UseSqlServer(_config["ConnectionStrings:Default"]);
            });
            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
            });

            services.AddIdentity<AppUser, IdentityRole>(IdentityOptions =>
            {
                IdentityOptions.Password.RequiredLength = 8;
                IdentityOptions.Password.RequiredUniqueChars = 1;
                IdentityOptions.Password.RequireDigit = true;
                IdentityOptions.Password.RequireLowercase = true;
                IdentityOptions.Password.RequireUppercase = true;
                IdentityOptions.Password.RequireNonAlphanumeric = true;

                IdentityOptions.User.RequireUniqueEmail = true;

                IdentityOptions.Lockout.AllowedForNewUsers = true;
                IdentityOptions.Lockout.MaxFailedAccessAttempts = 3;
                IdentityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);

            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseRouting();
            app.UseStaticFiles();
         

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                     name: "areas",
                     template: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );
                routes.MapRoute(
                    name: "Default",
                    template:"{controller=Home}/{action=Index}/{id?}"

                    );
            });
        }
    }
}
