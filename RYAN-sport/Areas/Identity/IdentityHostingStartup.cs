using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RYAN_sport.Areas.Identity.Data;
using RYAN_sport.Data;

[assembly: HostingStartup(typeof(RYAN_sport.Areas.Identity.IdentityHostingStartup))]
namespace RYAN_sport.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<RYAN_sportDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("RYAN_sportDBContextConnection")));

                services.AddDefaultIdentity<AplicationtUser>(options => {
                    options.Password.RequireLowercase = false;
                    options.Password.RequireUppercase = false;
                    options.Password.RequireDigit = false;
                    options.SignIn.RequireConfirmedAccount = false;
                }).AddRoles<IdentityRole>()
                    .AddEntityFrameworkStores<RYAN_sportDBContext>();
            });
        }
    }
}