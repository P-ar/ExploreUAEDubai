using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using ExploreUAEDubai.Data;
using ExploreUAEDubai.Models;

namespace ExploreUAEDubai.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly IWebHostEnvironment _environment;

        public HomeController(ApplicationDbContext context, UserManager<IdentityUser> userManager, ILogger<HomeController> logger, IWebHostEnvironment env)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
            _environment = env;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> AllSupport()
        {
            return View(await _context.Supports.ToListAsync());
        }

        public async Task<IActionResult> AllAttraction()
        {
            return View(await _context.Attractions.ToListAsync());
        }

        [Authorize]
        public IActionResult AttractionBooking()
        {
            string userid = _userManager.GetUserName(this.User);
            var details = _context.VisitorDetails
                .Where(m => m.UserID == userid);
            if(details.Count() == 0)
            {
                return RedirectToAction(nameof(AddVisitorDetail));
            }
            ViewData["AttractionID"] = new SelectList(_context.Attractions, "AttractionID", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AttractionBooking([Bind("BookingID,BookingDate,AttractionID")] Booking booking)
        {
            ModelState.Remove("UserID");
            if (ModelState.IsValid)
            {
                string userid = _userManager.GetUserName(this.User);
                var bookings = _context.Bookings
                .Where(m => m.UserID == userid);
                if(bookings.Count() == 2)
                {
                    ModelState.AddModelError("BookingDate", "You Allowed For Only Two Vaccine Bookings");
                }
                else
                {
                    booking.UserID = userid;
                    _context.Add(booking);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(MyBookings));
                }
            }
            ViewData["AttractionID"] = new SelectList(_context.Attractions, "AttractionID", "Name", booking.AttractionID);
            return View(booking);
        }

        [Authorize]
        public IActionResult AddVisitorDetail()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddVisitorDetail([Bind("VisitorDetailID,Name,Address,ContactNo,File")] VisitorDetail personalDetail)
        {
            using (var memoryStream = new MemoryStream())
            {
                await personalDetail.File.FormFile.CopyToAsync(memoryStream);

                string photoname = personalDetail.File.FormFile.FileName;
                personalDetail.Extension = Path.GetExtension(photoname);
                if (!".jpg.jpeg.png.gif.bmp".Contains(personalDetail.Extension.ToLower()))
                {
                    ModelState.AddModelError("File.FormFile", "Invalid Format of Image Given.");
                }
                else
                {
                    ModelState.Remove("Extension");
                }
            }
            ModelState.Remove("UserID");
            if (ModelState.IsValid)
            {
                personalDetail.UserID = _userManager.GetUserName(this.User);    
                _context.Add(personalDetail);
                await _context.SaveChangesAsync();
                await _context.SaveChangesAsync();
                var uploadsRootFolder = Path.Combine(_environment.WebRootPath, "person");
                if (!Directory.Exists(uploadsRootFolder))
                {
                    Directory.CreateDirectory(uploadsRootFolder);
                }
                string filename = personalDetail.VisitorDetailID + personalDetail.Extension;
                var filePath = Path.Combine(uploadsRootFolder, filename);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    await personalDetail.File.FormFile.CopyToAsync(fileStream).ConfigureAwait(false);
                }
                return RedirectToAction(nameof(MyDetails));
            }
            return View(personalDetail);
        }

        [Authorize]
        public async Task<IActionResult> MyDetails()
        {
            string userid = _userManager.GetUserName(this.User);
            var details = await _context.VisitorDetails
                .Where(m => m.UserID == userid).ToListAsync();
            return View(details);
        }

        [Authorize]
        public async Task<IActionResult> MyBookings()
        {
            string userid = _userManager.GetUserName(this.User);
            var bookings = await _context.Bookings
                .Include(m => m.Attraction)
                .Where(m => m.UserID == userid).ToListAsync();
            return View(bookings);
        }

        [Authorize]
        public async Task<IActionResult> CancelBooking(int? id)
        {
            var booking = await _context.Bookings.FindAsync(id);
            _context.Bookings.Remove(booking);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(MyBookings));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
