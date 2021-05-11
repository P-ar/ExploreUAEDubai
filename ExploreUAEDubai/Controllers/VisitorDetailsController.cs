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
    [Authorize(Roles ="admin")]
    public class VisitorDetailsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public VisitorDetailsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: VisitorDetails
        public async Task<IActionResult> Index()
        {
            return View(await _context.VisitorDetails.ToListAsync());
        }        
    }
}
