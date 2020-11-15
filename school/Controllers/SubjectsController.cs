﻿using System;
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
    public class SubjectsController : ControllerBase
    {
        private readonly schoolContext _context;

        public SubjectsController(schoolContext context)
        {
            _context = context;
        }

        // GET: api/Subjects
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Subjects>>> GetSubjects()
        {
            return await _context.Subjects.ToListAsync();
        }

        // GET: api/Subjects/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Subjects>> GetSubjects(int id)
        {
            var subjects = await _context.Subjects.FindAsync(id);

            if (subjects == null)
            {
                return NotFound();
            }

            return subjects;
        }

        // PUT: api/Subjects/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSubjects(int id, Subjects subjects)
        {
            if (id != subjects.Id)
            {
                return BadRequest();
            }

            _context.Entry(subjects).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SubjectsExists(id))
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

        // POST: api/Subjects
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Subjects>> PostSubjects(Subjects subjects)
        {
            _context.Subjects.Add(subjects);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSubjects", new { id = subjects.Id }, subjects);
        }

        // DELETE: api/Subjects/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Subjects>> DeleteSubjects(int id)
        {
            var subjects = await _context.Subjects.FindAsync(id);
            if (subjects == null)
            {
                return NotFound();
            }

            _context.Subjects.Remove(subjects);
            await _context.SaveChangesAsync();

            return subjects;
        }

        private bool SubjectsExists(int id)
        {
            return _context.Subjects.Any(e => e.Id == id);
        }
    }
}
