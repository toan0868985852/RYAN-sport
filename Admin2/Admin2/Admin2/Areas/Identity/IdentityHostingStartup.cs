using System;
using Admin2.Areas.Identity.Data;
using Admin2.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(Admin2.Areas.Identity.IdentityHostingStartup))]
namespace Admin2.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<Admin2Context>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("Admin2ContextConnection")));

                services.AddDefaultIdentity<Admin2User>(options =>
                {
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireDigit = false;
                    options.SignIn.RequireConfirmedAccount = false;
                }).AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<Admin2Context>();
            });
        }
    }
}