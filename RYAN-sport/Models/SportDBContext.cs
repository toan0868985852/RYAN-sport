using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RYAN_sport.Models
{
    public class SportDBContext : DbContext
    {
        public SportDBContext(DbContextOptions<SportDBContext> options)
           : base(options) { }

        public DbSet<HeaderImage> HeaderImages { get; set; }
        public DbSet<exercisePackage> exercisePackages { get; set; }
        public DbSet<about> abouts { get; set; }
        public DbSet<galery> galerys { get; set; }
        public DbSet<Subscription> subscriptions { get; set; }
        public DbSet<Subjects> Subjects { get; set; }
        public DbSet<SportRoom> SportRooms { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Card> Cards { get; set; }
    }
}
