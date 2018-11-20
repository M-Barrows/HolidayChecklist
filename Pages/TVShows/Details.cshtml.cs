using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using HolidayChecklist.Models;

namespace HolidayChecklist.Pages.TVShows
{
    public class DetailsModel : PageModel
    {
        private readonly HolidayChecklist.Models.AppDbContext _context;

        public DetailsModel(HolidayChecklist.Models.AppDbContext context)
        {
            _context = context;
        }

        public TVShow TVShow { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TVShow = await _context.TVShow.FirstOrDefaultAsync(m => m.Id == id);

            if (TVShow == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
