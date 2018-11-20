using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HolidayChecklist.Models;

namespace HolidayChecklist.Pages.Episodes
{
    public class EditModel : PageModel
    {
        private readonly HolidayChecklist.Models.AppDbContext _context;

        public EditModel(HolidayChecklist.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Episode Episode { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Episode = await _context.Episode.FirstOrDefaultAsync(m => m.ParentShowID == id);

            if (Episode == null)
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

            _context.Attach(Episode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpisodeExists(Episode.ParentShowID))
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

        private bool EpisodeExists(int id)
        {
            return _context.Episode.Any(e => e.ParentShowID == id);
        }
    }
}
