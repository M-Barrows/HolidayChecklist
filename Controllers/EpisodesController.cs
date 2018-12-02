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
    public class EpisodesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EpisodesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Episodes
        [HttpGet]
        public IEnumerable<Episode> GetEpisode()
        {
            return _context.Episode;
        }

        // GET: api/Episodes/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEpisode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var episode = await _context.Episode.FindAsync(id);

            if (episode == null)
            {
                return NotFound();
            }

            return Ok(episode);
        }

        // PUT: api/Episodes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEpisode([FromRoute] int id, [FromBody] Episode episode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != episode.EpisodeID)
            {
                return BadRequest();
            }

            _context.Entry(episode).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EpisodeExists(id))
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

        // POST: api/Episodes
        [HttpPost]
        public async Task<IActionResult> PostEpisode([FromBody] Episode episode)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Episode.Add(episode);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEpisode", new { id = episode.EpisodeID }, episode);
        }

        // DELETE: api/Episodes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEpisode([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var episode = await _context.Episode.FindAsync(id);
            if (episode == null)
            {
                return NotFound();
            }

            _context.Episode.Remove(episode);
            await _context.SaveChangesAsync();

            return Ok(episode);
        }

        private bool EpisodeExists(int id)
        {
            return _context.Episode.Any(e => e.EpisodeID == id);
        }
    }
}