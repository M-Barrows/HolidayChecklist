using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HolidayChecklist.Models;

namespace HolidayChecklist.Pages.TVShows
{
    public class EditModel : PageModel
    {
        private readonly HolidayChecklist.Models.AppDbContext _context;

        public EditModel(HolidayChecklist.Models.AppDbContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TVShow).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TVShowExists(TVShow.Id))
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

        private bool TVShowExists(int id)
        {
            return _context.TVShow.Any(e => e.Id == id);
        }
    }
}
