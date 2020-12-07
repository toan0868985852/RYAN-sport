using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RYAN_sport.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private SportDBContext context;
        public EFStoreRepository(SportDBContext ctx)
        {
            context = ctx;
        }
        public IQueryable<HeaderImage> HeaderImages => context.HeaderImages;
        public IQueryable<exercisePackage> exercisePackages => context.exercisePackages;
        public IQueryable<about> abouts => context.abouts;
        public IQueryable<galery> galerys => context.galerys;
    }
}
