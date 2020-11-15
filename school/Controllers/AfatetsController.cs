using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using school.Data;
using school.Models;

namespace school.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class AfatetsController : ControllerBase
    {
        private readonly schoolContext _context;

        public AfatetsController(schoolContext context)
        {
            _context = context;
        }

        // GET: api/Afatets 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Afatet>>> GetAfatet()
        {
            return await _context.Afatet.ToListAsync();
        }

        // GET: api/Afatets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Afatet>> GetAfatet(int id)
        {
            var afatet = await _context.Afatet.FindAsync(id);

            if (afatet == null)
            {
                return NotFound();
            }

            return afatet;
        }

        // PUT: api/Afatets/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAfatet(int id, Afatet afatet)
        {
            if (id != afatet.Id)
            {
                return BadRequest();
            }

            _context.Entry(afatet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AfatetExists(id))
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

        // POST: api/Afatets
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Afatet>> PostAfatet(Afatet afatet)
        {
            _context.Afatet.Add(afatet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAfatet", new { id = afatet.Id }, afatet);
        }

        // DELETE: api/Afatets/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Afatet>> DeleteAfatet(int id)
        {
            var afatet = await _context.Afatet.FindAsync(id);
            if (afatet == null)
            {
                return NotFound();
            }

            _context.Afatet.Remove(afatet);
            await _context.SaveChangesAsync();

            return afatet;
        }

        private bool AfatetExists(int id)
        {
            return _context.Afatet.Any(e => e.Id == id);
        }
    }
}
