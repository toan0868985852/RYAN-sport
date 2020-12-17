using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RYAN_sport.Areas.Identity.Data;
using RYAN_sport.Models;

namespace RYAN_sport.Data
{
    public class RYAN_sportDBContext : IdentityDbContext<AplicationtUser>
    {
        public RYAN_sportDBContext(DbContextOptions<RYAN_sportDBContext> options)
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
