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
    public class DetailsModel : PageModel
    {
        private readonly AFKWebApp.Models.HeroContext _context;

        public DetailsModel(AFKWebApp.Models.HeroContext context)
        {
            _context = context;
        }

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
    }
}
