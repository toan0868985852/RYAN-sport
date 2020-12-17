using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RYAN_sport.Data;
using RYAN_sport.Models;


namespace RYAN_sport.Areas.Identity.Data
{
    public class EFStoreRepository : IStoreRepository
    {
        private RYAN_sportDBContext context;
        public EFStoreRepository(RYAN_sportDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Card> Cards => context.Cards;
        public IQueryable<Level> Levels => context.Levels;
        public IQueryable<LevelSubject> LevelSubjects => context.LevelSubjects;
        public IQueryable<SportRoom> SportRooms => context.SportRooms;
        public IQueryable<Subject> Subjects => context.Subjects;
        public IQueryable<SubjectSportRoom> SubjectSportRooms => context.SubjectSportRooms;
        public IQueryable<Subscription> Subscriptions => context.Subscriptions;
        public IQueryable<Galery> Galeries => context.Galeries;
        public IQueryable<Contact> Contacts => context.Contacts;
    }
}
