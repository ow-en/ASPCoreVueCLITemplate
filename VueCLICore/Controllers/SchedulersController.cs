using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DAL.Models;

namespace VueCLICore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SchedulersController : ControllerBase
    {
        private readonly ControlContext _context;

        public SchedulersController(ControlContext context)
        {
            _context = context;
        }

        // GET: api/Schedulers
        [HttpGet]
        public IEnumerable<Scheduler> GetSchedules()
        {
            return _context.Schedules;
        }

        // GET: api/Schedulers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetScheduler([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var scheduler = await _context.Schedules.FindAsync(id);

            if (scheduler == null)
            {
                return NotFound();
            }

            return Ok(scheduler);
        }

        // PUT: api/Schedulers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutScheduler([FromRoute] int id, [FromBody] Scheduler scheduler)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != scheduler.SchedulerId)
            {
                return BadRequest();
            }

            _context.Entry(scheduler).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchedulerExists(id))
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

        // POST: api/Schedulers
        [HttpPost]
        public async Task<IActionResult> PostScheduler([FromBody] Scheduler scheduler)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Schedules.Add(scheduler);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetScheduler", new { id = scheduler.SchedulerId }, scheduler);
        }

        // DELETE: api/Schedulers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteScheduler([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var scheduler = await _context.Schedules.FindAsync(id);
            if (scheduler == null)
            {
                return NotFound();
            }

            _context.Schedules.Remove(scheduler);
            await _context.SaveChangesAsync();

            return Ok(scheduler);
        }

        private bool SchedulerExists(int id)
        {
            return _context.Schedules.Any(e => e.SchedulerId == id);
        }
    }
}