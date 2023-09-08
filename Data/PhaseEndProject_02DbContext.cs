using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebAppPhaseEndProject_02.Models;

namespace WebAppPhaseEndProject_02.Data
{
    public class PhaseEndProject_02DbContext : DbContext
    {
        public PhaseEndProject_02DbContext (DbContextOptions<PhaseEndProject_02DbContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppPhaseEndProject_02.Models.Order> Order { get; set; } = default!;

        public DbSet<WebAppPhaseEndProject_02.Models.OrderDetails>? OrderDetails { get; set; }

        public DbSet<WebAppPhaseEndProject_02.Models.Product>? Product { get; set; }
    }
}
