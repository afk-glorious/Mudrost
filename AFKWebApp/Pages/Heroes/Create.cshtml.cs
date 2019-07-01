using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using AFKWebApp.Models;

namespace AFKWebApp.Pages.Heroes
{
    public class CreateModel : PageModel
    {
        private readonly AFKWebApp.Models.HeroContext _context;

        public CreateModel(AFKWebApp.Models.HeroContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Hero Hero { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Hero.Add(Hero);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}