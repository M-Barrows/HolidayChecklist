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
    public class DeleteModel : PageModel
    {
        private readonly HolidayChecklist.Models.AppDbContext _context;

        public DeleteModel(HolidayChecklist.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Season Season { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Season = await _context.Season.FirstOrDefaultAsync(m => m.ParentShowID == id);

            if (Season == null)
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

            Season = await _context.Season.FindAsync(id);

            if (Season != null)
            {
                _context.Season.Remove(Season);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
