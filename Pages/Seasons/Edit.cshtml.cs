using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HolidayChecklist.Models;

namespace HolidayChecklist.Pages.Seasons
{
    public class EditModel : PageModel
    {
        private readonly HolidayChecklist.Models.AppDbContext _context;

        public EditModel(HolidayChecklist.Models.AppDbContext context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Season).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SeasonExists(Season.ParentShowID))
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

        private bool SeasonExists(int id)
        {
            return _context.Season.Any(e => e.ParentShowID == id);
        }
    }
}
