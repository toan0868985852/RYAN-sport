using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RYAN_sport.Models
{
    public interface IStoreRepository
    {
        IQueryable<HeaderImage> HeaderImages { get; }
        IQueryable<exercisePackage> exercisePackages { get; }
        IQueryable<about> abouts { get; }
        IQueryable<galery> galerys { get; }
    }
}
