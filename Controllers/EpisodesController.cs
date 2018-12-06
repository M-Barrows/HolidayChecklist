using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
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
            var results = _context.Episode.Distinct().OrderBy(x => x.ShowTitle).ThenBy(x => x.Watched).ThenBy(x => x.SeasonNumber).ThenBy(x => x.EpisodeNumber);
            return results;
        }

        //GET: api/Episodes/Christmas
        [HttpGet("{holiday}")]
        public IEnumerable<Episode> GetEpisode([FromRoute] string holiday)
        {
            if((holiday == "Christmas") || (holiday == "Kwanzaa") || (holiday == "Hanukkah")){
                var results = _context.Episode.Distinct().Where(x => x.EpisodeAirDate.Month == 12 && x.EpisodeAirDate.Day >10).OrderBy(x => x.ShowTitle).ThenBy(x => x.Watched).ThenBy(x => x.SeasonNumber).ThenBy(x => x.EpisodeNumber)
                    .Union(_context.Episode.Distinct().Where(x => x.EpisodeOverview.Contains("Christmas", System.StringComparison.CurrentCultureIgnoreCase)))
                    .Union(_context.Episode.Distinct().Where(x => x.EpisodeOverview.Contains("Kwanzaa", System.StringComparison.CurrentCultureIgnoreCase)))
                    .Union(_context.Episode.Distinct().Where(x => x.EpisodeOverview.Contains("Hanukkah", System.StringComparison.CurrentCultureIgnoreCase)));
                return results;
            }
            else if(holiday =="Halloween"){
                var results = _context.Episode.Distinct().Where(x => x.EpisodeAirDate.Month == 10 && x.EpisodeAirDate.Day > 15).OrderBy(x => x.ShowTitle).ThenBy(x => x.Watched).ThenBy(x => x.SeasonNumber).ThenBy(x => x.EpisodeNumber)
                .Union(_context.Episode.Distinct().Where(x => x.EpisodeOverview.Contains("Halloween", System.StringComparison.CurrentCultureIgnoreCase)));;
                return results;
            }
            else{
                var results = _context.Episode.Distinct().OrderBy(x => x.ShowTitle).ThenBy(x => x.Watched).ThenBy(x => x.SeasonNumber).ThenBy(x => x.EpisodeNumber);
                return results;
            }
            
        }
        //GET: /api/search/
        /*
        [HttpGet("search")]
        public IEnumerable<Episode> GetSearchedEpisode([FromBody] string term)
        {
            var search = Regex.Replace(term, @"\s+","%20");
            var results = _context.Episode.Distinct().Where(x => x.EpisodeOverview.Contains(search, System.StringComparison.CurrentCultureIgnoreCase));
            return results;
            
        }
*/
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

            _context.SaveChanges();

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
        // DELETE: api/Episodes/
        [HttpDelete]
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

        // DELETE: api/Show/Episodes/5
        [HttpDelete("Show/{id}")]
        public async Task<IActionResult> DeleteEpisodes([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var Episodes =  _context.Episode.Where(x => x.ShowID == id);
            if (Episodes == null)
            {
                return NotFound();
            }
            foreach(var ep in Episodes){
                _context.Episode.Remove(ep);
            }
            
            await _context.SaveChangesAsync();

            return Ok(Episodes);
        }

        private bool EpisodeExists(int id)
        {
            return _context.Episode.Any(e => e.EpisodeID == id);
        }
    }
    
}