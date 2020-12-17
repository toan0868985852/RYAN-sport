using Microsoft.AspNetCore.Mvc;
using System.Linq;
using RYAN_sport.Areas.Identity.Data;

namespace RYAN_sport.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IStoreRepository repository;
        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Subjects
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
