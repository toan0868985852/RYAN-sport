using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Admin2.Models;
using Admin2.Data;
using Microsoft.AspNetCore.Authorization;

namespace Admin2.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class HomeController : Controller
    {
        private Admin2Context context;
       
        public HomeController(Admin2Context ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
