using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AFKWebApp.Models;

namespace AFKWebApp.Pages.Heroes
{
    public class EditModel : PageModel
    {
        private readonly AFKWebApp.Models.HeroContext _context;

        public EditModel(AFKWebApp.Models.HeroContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Hero Hero { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hero = await _context.Hero.FirstOrDefaultAsync(m => m.ID == id);

            if (Hero == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Hero).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HeroExists(Hero.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool HeroExists(int id)
        {
            return _context.Hero.Any(e => e.ID == id);
        }
    }
}
