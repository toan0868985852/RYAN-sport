using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RYAN_sport.Models;

namespace RYAN_sport.Areas.Identity.Data
{
    public interface IStoreRepository
    {
        IQueryable<Card> Cards { get; }
        IQueryable<Level> Levels { get; }
        IQueryable<LevelSubject> LevelSubjects { get; }
        IQueryable<SportRoom> SportRooms { get; }
        IQueryable<Subject> Subjects { get; }
        IQueryable<SubjectSportRoom> SubjectSportRooms { get; }
        IQueryable<Subscription> Subscriptions { get; }
        IQueryable<Galery> Galeries { get; }
        IQueryable<Contact> Contacts { get; }
    }
}
