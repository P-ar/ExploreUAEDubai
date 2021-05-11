using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExploreUAEDubai.Data;
using ExploreUAEDubai.Models;

namespace ExploreUAEDubai.Controllers
{
    [Authorize(Roles = "admin")]
    public class AttractionsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AttractionsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Attractions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Attractions.ToListAsync());
        }

        
        // GET: Attractions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Attractions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AttractionID,Name,Address,ContactNo")] Attraction attraction)
        {
            if (ModelState.IsValid)
            {
                _context.Add(attraction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(attraction);
        }

        // GET: Attractions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attraction = await _context.Attractions.FindAsync(id);
            if (attraction == null)
            {
                return NotFound();
            }
            return View(attraction);
        }

        // POST: Attractions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AttractionID,Name,Address,ContactNo")] Attraction attraction)
        {
            if (id != attraction.AttractionID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(attraction);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AttractionExists(attraction.AttractionID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(attraction);
        }

        // GET: Attractions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var attraction = await _context.Attractions
                .FirstOrDefaultAsync(m => m.AttractionID == id);
            if (attraction == null)
            {
                return NotFound();
            }

            return View(attraction);
        }

        // POST: Attractions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var attraction = await _context.Attractions.FindAsync(id);
            _context.Attractions.Remove(attraction);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AttractionExists(int id)
        {
            return _context.Attractions.Any(e => e.AttractionID == id);
        }
    }
}
