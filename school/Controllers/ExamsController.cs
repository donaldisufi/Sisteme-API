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
    public class ExamsController : ControllerBase
    {
        private readonly schoolContext _context;

        public ExamsController(schoolContext context)
        {
            _context = context;
        }

        // GET: api/Exams
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Exams>>> GetExams()
        {
            return await _context.Exams.ToListAsync();
        }

        // GET: api/Exams/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Exams>> GetExams(int id)
        {
            var exams = await _context.Exams.FindAsync(id);

            if (exams == null)
            {
                return NotFound();
            }

            return exams;
        }

        // PUT: api/Exams/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExams(int id, Exams exams)
        {
            if (id != exams.Id)
            {
                return BadRequest();
            }

            _context.Entry(exams).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExamsExists(id))
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

        // POST: api/Exams
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Exams>> PostExams(Exams exams)
        {
            _context.Exams.Add(exams);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetExams", new { id = exams.Id }, exams);
        }

        // DELETE: api/Exams/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Exams>> DeleteExams(int id)
        {
            var exams = await _context.Exams.FindAsync(id);
            if (exams == null)
            {
                return NotFound();
            }

            _context.Exams.Remove(exams);
            await _context.SaveChangesAsync();

            return exams;
        }

        private bool ExamsExists(int id)
        {
            return _context.Exams.Any(e => e.Id == id);
        }
    }
}
