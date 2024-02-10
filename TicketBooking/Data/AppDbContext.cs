using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TicketBooking.Entity;

namespace TicketBooking.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Booking> Bookings { get; set; }
    }
}
