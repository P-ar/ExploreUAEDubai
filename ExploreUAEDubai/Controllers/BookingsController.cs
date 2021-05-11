﻿using System;
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
    public class BookingsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BookingsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VisitorBookings
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Bookings.Include(b => b.Attraction);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: VisitorBookings/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var details = await _context.VisitorDetails
                .Where(m => m.UserID == id).ToListAsync();
            if (details == null)
            {
                return NotFound();
            }

            return View(details);
        }

        
    }
}
