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
    public class ProffesorsController : ControllerBase
    {
        private readonly schoolContext _context;

        public ProffesorsController(schoolContext context)
        {
            _context = context;
        }

        // GET: api/Proffesors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Proffesors>>> GetProffesors()
        {
            return await _context.Proffesors.ToListAsync();
        }

        // GET: api/Proffesors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Proffesors>> GetProffesors(int id)
        {
            var proffesors = await _context.Proffesors.FindAsync(id);

            if (proffesors == null)
            {
                return NotFound();
            }

            return proffesors;
        }

        // PUT: api/Proffesors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProffesors(int id, Proffesors proffesors)
        {
            if (id != proffesors.Id)
            {
                return BadRequest();
            }

            _context.Entry(proffesors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProffesorsExists(id))
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

        // POST: api/Proffesors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Proffesors>> PostProffesors(Proffesors proffesors)
        {
            _context.Proffesors.Add(proffesors);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProffesors", new { id = proffesors.Id }, proffesors);
        }

        // DELETE: api/Proffesors/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Proffesors>> DeleteProffesors(int id)
        {
            var proffesors = await _context.Proffesors.FindAsync(id);
            if (proffesors == null)
            {
                return NotFound();
            }

            _context.Proffesors.Remove(proffesors);
            await _context.SaveChangesAsync();

            return proffesors;
        }

        private bool ProffesorsExists(int id)
        {
            return _context.Proffesors.Any(e => e.Id == id);
        }
    }
}
