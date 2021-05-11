using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ExploreUAEDubai.Models;

namespace ExploreUAEDubai.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Attraction> Attractions { get; set; }
        public DbSet<Support> Supports { get; set; }
        public DbSet<VisitorDetail> VisitorDetails { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
