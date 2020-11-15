using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using school.Data;
using school.Models;

namespace school.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DirectionsController : ControllerBase
    {
        private readonly schoolContext _context;

        public DirectionsController(schoolContext context)
        {
            _context = context;
        }

        // GET: api/Directions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Directions>>> GetDirections()
        {
            return await _context.Directions.ToListAsync();
        }

        // GET: api/Directions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Directions>> GetDirections(int id)
        {
            var directions = await _context.Directions.FindAsync(id);

            if (directions == null)
            {
                return NotFound();
            }

            return directions;
        }

        // PUT: api/Directions/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDirections(int id, Directions directions)
        {
            if (id != directions.Id)
            {
                return BadRequest();
            }

            _context.Entry(directions).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DirectionsExists(id))
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

        // POST: api/Directions
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Directions>> PostDirections(Directions directions)
        {
            _context.Directions.Add(directions);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDirections", new { id = directions.Id }, directions);
        }

        // DELETE: api/Directions/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Directions>> DeleteDirections(int id)
        {
            var directions = await _context.Directions.FindAsync(id);
            if (directions == null)
            {
                return NotFound();
            }

            _context.Directions.Remove(directions);
            await _context.SaveChangesAsync();

            return directions;
        }

        private bool DirectionsExists(int id)
        {
            return _context.Directions.Any(e => e.Id == id);
        }
    }
}
