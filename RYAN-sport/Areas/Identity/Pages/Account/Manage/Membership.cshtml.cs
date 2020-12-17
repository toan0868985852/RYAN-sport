using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RYAN_sport.Areas.Identity.Data;
using RYAN_sport.Models;
using RYAN_sport.Data;

namespace RYAN_sport.Areas.Identity.Pages.Account.Manage
{
    public class MembershipModel : PageModel
    {
        private readonly UserManager<AplicationtUser> _userManager;
        private readonly SignInManager<AplicationtUser> _signInManager;

        private IStoreRepository _context;

        public MembershipModel(
            UserManager<AplicationtUser> userManager,
            SignInManager<AplicationtUser> signInManager,
            IStoreRepository ctx)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = ctx;
        }

        public string Username { get; set; }

        [BindProperty]
        public Card Input { get; set; }

        public IEnumerable<Card> Card { get; set; }

        private async Task LoadAsync(AplicationtUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);

            Username = userName;

            Card = _context.Cards.Where(p => p.UserId == user.Id);
        }

        public void OnGet()
        {
        }
    }
}
