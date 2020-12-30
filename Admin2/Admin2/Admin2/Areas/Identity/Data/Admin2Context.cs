using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Admin2.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Admin2.Models;

namespace Admin2.Data
{
    public class Admin2Context : IdentityDbContext<Admin2User>
    {
        public Admin2Context(DbContextOptions<Admin2Context> options)
            : base(options)
        {
        }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<LevelSubject> LevelSubjects { get; set; }
        public DbSet<SportRoom> SportRooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectSportRoom> SubjectSportRooms { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Galery> Galeries { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
