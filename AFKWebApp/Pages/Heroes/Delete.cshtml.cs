using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AFKWebApp.Models;

namespace AFKWebApp.Pages.Heroes
{
    public class DeleteModel : PageModel
    {
        private readonly AFKWebApp.Models.HeroContext _context;

        public DeleteModel(AFKWebApp.Models.HeroContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Hero = await _context.Hero.FindAsync(id);

            if (Hero != null)
            {
                _context.Hero.Remove(Hero);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
