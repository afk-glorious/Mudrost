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
    public class IndexModel : PageModel
    {
        private readonly AFKWebApp.Models.HeroContext _context;

        public IndexModel(AFKWebApp.Models.HeroContext context)
        {
            _context = context;
        }

        public IList<Hero> Hero { get;set; }

        public async Task OnGetAsync()
        {
            Hero = await _context.Hero.ToListAsync();
        }
    }
}
