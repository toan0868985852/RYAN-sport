using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RYAN_sport.Models;
using RYAN_sport.Models.ViewModels;
using RYAN_sport.Areas.Identity.Data;


namespace RYAN_sport.Controllers
{
    public class SubjectController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 6;
        public ViewResult Index(int productPage = 1)
             => View(new ProductListViewModel
             {
                 Subjects = repository.Subjects
                 .OrderBy(p => p.ID)
                 .Skip((productPage - 1) * PageSize)
                 .Take(PageSize),
                 PagingInfo = new PagingInfo
                 {
                     CurrentPage = productPage,
                     ItemsPerPage = PageSize,
                     TotalItems = repository.Subjects.Count()
                 }
             });
    }
}
