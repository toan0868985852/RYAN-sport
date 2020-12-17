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
using RYAN_sport.Data;

namespace RYAN_sport.Controllers
{
    public class ContactController : Controller
    {
        private RYAN_sportDBContext context;

        public ContactController(RYAN_sportDBContext repo)
        {
            context = repo;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult Create(string FirstName, string LastName, string Email, string PhoneNumber, string Address01, string Address02, string Messenger)
        {
            Contact contact = new Contact {FirstName = FirstName, LastName = LastName, Email = Email, PhoneNumber = PhoneNumber, Address01 = Address01, Address02 = Address02, Messenger = Messenger};
            context.Add(contact);
            context.SaveChanges();
            String StatusMessage = "Your Feedback Sent";
            return RedirectToAction(nameof(Index), StatusMessage);
        }

    }
}
