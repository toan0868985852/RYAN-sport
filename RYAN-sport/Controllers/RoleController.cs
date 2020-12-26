using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace RYAN_sport.Controllers
{
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> RoleManager;

        public RoleController(RoleManager<IdentityRole> roleManager)
        {
            RoleManager = roleManager;
        }

        public IActionResult Index()
        {
            var roles = RoleManager.Roles.ToList();
            return View(roles);
        }

        public IActionResult Create()
        {
            return View(new IdentityRole());
        }

        public async void DefautCreateUser()
        {
            IdentityRole AdminManager = new IdentityRole { Name = "Administrator" };
            IdentityRole UserManager = new IdentityRole { Name = "User" };
            await RoleManager.CreateAsync(AdminManager);
            await RoleManager.CreateAsync(UserManager);
        }

        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole role)
        {
            await RoleManager.CreateAsync(role);
            return RedirectToAction("Index");
        }
    }
}
