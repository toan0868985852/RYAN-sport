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
using Microsoft.EntityFrameworkCore.Internal;

namespace RYAN_sport.Areas.Identity.Pages.Account.Manage
{
    public class MembershipModel : PageModel
    {
        private readonly UserManager<AplicationtUser> _userManager;
        private readonly SignInManager<AplicationtUser> _signInManager;

        private RYAN_sportDBContext _context;

        public MembershipModel(
            UserManager<AplicationtUser> userManager,
            SignInManager<AplicationtUser> signInManager,
            RYAN_sportDBContext ctx)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _context = ctx;
        }

        public string Username { get; set; }

        [TempData]
        public string StatusMessage { get; set; }

        [BindProperty]
        public InputModel Input { get; set; }

        
        public class InputModel
        {
            public IEnumerable<Card> Cards { get; set; }

            public int Active { get; set; }
            public string UserId { get; set; }
        }

        private async Task LoadAsync(AplicationtUser user)
        {
            var userName = await _userManager.GetUserNameAsync(user);

            Username = userName;

            IEnumerable<Card> Card = _context.Cards.Where(p => p.AplicationtUserId == user.Id);

            if (Card.Count() == 0)
            {
                Input = new InputModel
                {
                    Cards = _context.Cards.OrderBy(x => x.ID),
                    UserId = user.Id,
                    Active = 0
                };
            }
            else
            {
                Input = new InputModel
                {
                    Cards = Card,
                    UserId = user.Id,
                    Active = 1
                };
            }
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            await LoadAsync(user);
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int Id)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{_userManager.GetUserId(User)}'.");
            }

            if (!ModelState.IsValid)
            {
                await LoadAsync(user);
                return Page();
            }

            Card card = _context.Cards.Find(Id);
            card.AplicationtUserId = user.Id;
            _context.Update(card);

            await _userManager.UpdateAsync(user);

            StatusMessage = "Your profile has been updated";
            return RedirectToPage();
        }
    }
}
