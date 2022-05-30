using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoEmployee.Models;
using DemoEmployee.db;

namespace DemoEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EnginesController : ControllerBase
    {
        private readonly EmployeeDbContext _context;

        public EnginesController(EmployeeDbContext context)
        {
            _context = context;
        }

        // GET: api/Engines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Engine>>> GetEngines()
        {
          if (_context.Engines == null)
          {
              return NotFound();
          }
            return await _context.Engines.ToListAsync();
        }

        // GET: api/Engines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Engine>> GetEngine(Guid id)
        {
          if (_context.Engines == null)
          {
              return NotFound();
          }
            var engine = await _context.Engines.FindAsync(id);

            if (engine == null)
            {
                return NotFound();
            }

            return engine;
        }

        // PUT: api/Engines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEngine(Guid id, Engine engine)
        {
            if (id != engine.Id)
            {
                return BadRequest();
            }

            _context.Entry(engine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EngineExists(id))
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

        // POST: api/Engines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Engine>> PostEngine(Engine engine)
        {
          if (_context.Engines == null)
          {
              return Problem("Entity set 'EmployeeDbContext.Engines'  is null.");
          }
            _context.Engines.Add(engine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEngine", new { id = engine.Id }, engine);
        }

        // DELETE: api/Engines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEngine(Guid id)
        {
            if (_context.Engines == null)
            {
                return NotFound();
            }
            var engine = await _context.Engines.FindAsync(id);
            if (engine == null)
            {
                return NotFound();
            }

            _context.Engines.Remove(engine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EngineExists(Guid id)
        {
            return (_context.Engines?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
