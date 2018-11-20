using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HolidayChecklist.Models;

namespace HolidayChecklist.Pages.Episodes
{
    public class IndexModel : PageModel
    {
        private readonly HolidayChecklist.Models.AppDbContext _context;

        public IndexModel(HolidayChecklist.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Episode> Episode { get;set; }

        public async Task OnGetAsync()
        {
            Episode = await _context.Episode.ToListAsync();
        }
    }
}
