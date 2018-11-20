using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HolidayChecklist.Models;

namespace HolidayChecklist.Pages.Seasons
{
    public class IndexModel : PageModel
    {
        private readonly HolidayChecklist.Models.AppDbContext _context;

        public IndexModel(HolidayChecklist.Models.AppDbContext context)
        {
            _context = context;
        }

        public IList<Season> Season { get;set; }

        public async Task OnGetAsync()
        {
            Season = await _context.Season.ToListAsync();
        }
    }
}
