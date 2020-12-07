using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace RYAN_sport.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            SportDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<SportDBContext>();
            if (context.Database.GetAppliedMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.HeaderImages.Any())
            {
                context.HeaderImages.AddRange(
                    new HeaderImage
                    {
                        Image = "1.jpg",
                        SportName = "SWIMMING COACH",
                    }
                );
                context.SaveChanges();
            }

            if (!context.exercisePackages.Any())
            {
                context.exercisePackages.AddRange(
                    new exercisePackage
                    {
                        Image = "1.jpg",
                        TitlePackage = "SWIMMING COACH",
                        ContentPackage = "Scarce and cheer alone nor in light with are his lone childe not uncouth",
                        Price = 8,
                        datePackage = "6 Months"
                    }
                );
                context.SaveChanges();
            }

            if (!context.abouts.Any())
            {
                context.abouts.AddRange(
                    new about
                    {
                        Image = "1.jpg",
                        ContentAbout = "Scarce and cheer alone nor in light with are his lone childe not uncouth",
                    }
                );
                context.SaveChanges();
            }

            if (!context.galerys.Any())
            {
                context.galerys.AddRange(
                    new galery
                    {
                        Image = "1.jpg",
                        SportName = "SWIMMING COACH",
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
