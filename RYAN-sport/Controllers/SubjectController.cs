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

        public SubjectController(IStoreRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index(string category, int productPage = 1)
             => View(new SubjectListViewModel
             {
                 Subjects = repository.Subjects
                 .Where(p => category == null || p.Category == category)
                 .OrderBy(p => p.ID)
                 .Skip((productPage - 1) * PageSize)
                 .Take(PageSize),
                 PagingInfo = new PagingInfo
                 {
                     CurrentPage = productPage,
                     ItemsPerPage = PageSize,
                     TotalItems = category == null ? repository.Subjects.Count() : repository.Subjects.Where(e => e.Category == category).Count()
                 },
                 CurrentCategory = category
             });

        public ViewResult DetailSubject(int SubjectId)
            => View(new SubjectListViewModel
            {
                Subjects = repository.Subjects
                 .Where(p => p.ID == SubjectId),
                
            });
    }
}
