using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HolidayChecklist.Models;

namespace HolidayChecklist.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TVShowsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TVShowsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/TVShows
        [HttpGet]
        public IEnumerable<TVShow> GetTVShow()
        {
            return _context.TVShow;
        }

        // GET: api/TVShows/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTVShow([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tVShow = await _context.TVShow.FindAsync(id);

            if (tVShow == null)
            {
                return NotFound();
            }

            return Ok(tVShow);
        }

        // PUT: api/TVShows/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTVShow([FromRoute] int id, [FromBody] TVShow tVShow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tVShow.Id)
            {
                return BadRequest();
            }

            _context.Entry(tVShow).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TVShowExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TVShows
        [HttpPost]
        public async Task<IActionResult> PostTVShow([FromBody] TVShow tVShow)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.TVShow.Add(tVShow);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTVShow", new { id = tVShow.Id }, tVShow);
        }

        // DELETE: api/TVShows/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTVShow([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tVShow = await _context.TVShow.FindAsync(id);
            if (tVShow == null)
            {
                return NotFound();
            }

            _context.TVShow.Remove(tVShow);
            await _context.SaveChangesAsync();

            return Ok(tVShow);
        }

        private bool TVShowExists(int id)
        {
            return _context.TVShow.Any(e => e.Id == id);
        }
    }
}