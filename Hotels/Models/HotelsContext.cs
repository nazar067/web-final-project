using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotels.Models
{
    public class HotelsContext:DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Order> Orders { get; set; }
        public HotelsContext(DbContextOptions<HotelsContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }
}
