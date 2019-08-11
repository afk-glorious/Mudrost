using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AFKArena.DBContext;
using AFKArena.Models;

namespace AFKArena.Pages_Heroes
{
    public class IndexModel : PageModel
    {
        private readonly AFKArena.DBContext.HeroContext _context;

        public IndexModel(AFKArena.DBContext.HeroContext context)
        {
            _context = context;
        }

        public IList<Hero> Hero { get;set; }

        public async Task OnGetAsync()
        {
            Hero = await _context.Heroes.ToListAsync();
        }
    }
}
