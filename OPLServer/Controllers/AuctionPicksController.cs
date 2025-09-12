using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OPLServer.Database;
using OPLServer.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace OPLServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuctionPicksController : ControllerBase
    {
        private readonly OPLDBContext _context;

        public AuctionPicksController(OPLDBContext context)
        {
            _context = context;
        }

        // GET: api/AuctionPicks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AuctionPick>>> GetAuctionPicks()
        {
            return await _context.AuctionPicks.Where(e => e.IsActive).ToListAsync();
        }

        // GET: api/AuctionPicks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AuctionPick>> GetAuctionPick(int id)
        {
            var auctionPick = await _context.AuctionPicks.FindAsync(id);

            if (auctionPick == null)
            {
                return NotFound();
            }

            return auctionPick;
        }

        // PUT: api/AuctionPicks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAuctionPick(int id, AuctionPick auctionPick)
        {
            if (id != auctionPick.Id)
            {
                return BadRequest();
            }

            _context.Entry(auctionPick).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AuctionPickExists(id))
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

        // POST: api/AuctionPicks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AuctionPick>> PostAuctionPick(AuctionPick auctionPick)
        {
            _context.AuctionPicks.Add(auctionPick);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAuctionPick", new { id = auctionPick.Id }, auctionPick);
        }

        // DELETE: api/AuctionPicks/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteAuctionPick(int id)
        //{
        //    var auctionPick = await _context.AuctionPicks.FindAsync(id);
        //    if (auctionPick == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.AuctionPicks.Remove(auctionPick);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        private bool AuctionPickExists(int id)
        {
            return _context.AuctionPicks.Any(e => e.Id == id && e.IsActive);
        }
    }
}
