using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RYAN_sport.Data;
using RYAN_sport.Models;
namespace RYAN_sport.Areas.Identity.Data
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            RYAN_sportDBContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<RYAN_sportDBContext>();
            if (context.Database.GetAppliedMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Levels.Any())
            {
                context.Levels.AddRange(
                    new Level
                    {
                        Name = "CYCING"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
