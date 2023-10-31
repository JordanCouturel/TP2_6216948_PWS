using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TP2_6216948_PWS.Data;
using TP2_6216948_PWS.Models;
using TP2_6216948_PWS.Services;

namespace TP2_6216948_PWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LeaguesController : ControllerBase
    {
        private readonly TP2DbContext _context;

        public LeaguesController(TP2DbContext context)
        {
            _context = context;
        }

        // GET: api/Leagues
        [HttpGet]
        [AllowAnonymous]
        public async Task<ActionResult<IEnumerable<League>>> GetLeagues()
        {
          if (_context.Leagues == null)
          {
              return NotFound();
          }
            return await _context.Leagues.ToListAsync();
        }

        // GET: api/Leagues/5
        [HttpGet("{id}")]
        [AllowAnonymous]
        public async Task<ActionResult<League>> GetLeague(int id)
        {
          if (_context.Leagues == null)
          {
              return NotFound();
          }
            var league = await _context.Leagues.FindAsync(id);

            if (league == null)
            {
                return NotFound();
            }

            return league;
        }

        // PUT: api/Leagues/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles ="Admin")]
        public async Task<IActionResult> PutLeague(int id, League league)
        {
            if (id != league.Id)
            {
                return BadRequest();
            }

            _context.Entry(league).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LeagueExists(id))
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

        // POST: api/Leagues
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<League>> PostLeague(League league)
        {
          if (_context.Leagues == null)
          {
              return Problem("Entity set 'TP2DbContext.Leagues'  is null.");
          }
            _context.Leagues.Add(league);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLeague", new { id = league.Id }, league);
        }

        // DELETE: api/Leagues/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteLeague(int id)
        {
            if (_context.Leagues == null)
            {
                return NotFound();
            }
            var league = await _context.Leagues.FindAsync(id);
            if (league == null)
            {
                return NotFound();
            }

            if (league.Teams.Count>0 || league.Saisons.Count>0)
            {
                return NoContent();
            }
            else
            {
                
                _context.Leagues.Remove(league);
                await _context.SaveChangesAsync();
            }

         

            return NoContent();
        }
        [AllowAnonymous]
        private bool LeagueExists(int id)
        {
            return (_context.Leagues?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
