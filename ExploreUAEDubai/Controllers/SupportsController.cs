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
    public class SupportsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SupportsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Supports
        public async Task<IActionResult> Index()
        {
            return View(await _context.Supports.ToListAsync());
        }

        // GET: Supports/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supp = await _context.Supports
                .FirstOrDefaultAsync(m => m.SupportID == id);
            if (supp == null)
            {
                return NotFound();
            }

            return View(supp);
        }

        // GET: Supports/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Supports/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SupportID,Question,Answer")] Support supp)
        {
            if (ModelState.IsValid)
            {
                _context.Add(supp);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(supp);
        }

        // GET: Supports/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supp = await _context.Supports.FindAsync(id);
            if (supp == null)
            {
                return NotFound();
            }
            return View(supp);
        }

        // POST: Supports/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SupportID,Question,Answer")] Support supp)
        {
            if (id != supp.SupportID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(supp);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SupportExists(supp.SupportID))
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
            return View(supp);
        }

        // GET: Supports/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var supp = await _context.Supports
                .FirstOrDefaultAsync(m => m.SupportID == id);
            if (supp == null)
            {
                return NotFound();
            }

            return View(supp);
        }

        // POST: Supports/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var supp = await _context.Supports.FindAsync(id);
            _context.Supports.Remove(supp);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SupportExists(int id)
        {
            return _context.Supports.Any(e => e.SupportID == id);
        }
    }
}
