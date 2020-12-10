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

        public DbSet<Card> Cards { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<LevelSubject> LevelSubjects { get; set; }
        public DbSet<SportRoom> SportRooms { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<SubjectSportRoom> SubjectSportRooms { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<Galery> Galeries { get; set; }
    }
}
