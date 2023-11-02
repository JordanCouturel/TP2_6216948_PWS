using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using TP2_6216948_PWS.Data;
using TP2_6216948_PWS.Models;

namespace TP2_6216948_PWS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DGsController : ControllerBase
    {
        private readonly TP2DbContext _context;

        public DGsController(TP2DbContext context)
        {
            _context = context;
        }

        // GET: api/DGs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DG>>> GetDG()
        {
          if (_context.DG == null)
          {
              return NotFound();
          }
            return await _context.DG.ToListAsync();
        }

        // GET: api/DGs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DG>> GetDG(int id)
        {
          if (_context.DG == null)
          {
              return NotFound();
          }
            var dG = await _context.DG.FindAsync(id);

            if (dG == null)
            {
                return NotFound();
            }

            return dG;
        }

        // PUT: api/DGs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDG(int id, DG dG)
        {
            if (id != dG.ID)
            {
                return BadRequest();
            }

            _context.Entry(dG).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DGExists(id))
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


        [HttpGet("FilteredByage")]
        public async Task<ActionResult<IEnumerable<DG>>> GetDGsFilteredByAge([FromQuery]int agemin, [FromQuery]int agemax)
        {
            if (_context.DG == null)
            {
                return NotFound();
            }
            return await _context.DG.Where(x => x.Age >= agemin && x.Age <= agemax).ToListAsync();
        }



        // POST: api/DGs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DG>> PostDG(DG dG)
        {
          if (_context.DG == null)
          {
              return Problem("Entity set 'TP2DbContext.DG'  is null.");
          }
            _context.DG.Add(dG);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDG", new { id = dG.ID }, dG);
        }

        // DELETE: api/DGs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDG(int id)
        {
            if (_context.DG == null)
            {
                return NotFound();
            }
            var dG = await _context.DG.FindAsync(id);
            if (dG == null)
            {
                return NotFound();
            }

            _context.DG.Remove(dG);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DGExists(int id)
        {
            return (_context.DG?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
