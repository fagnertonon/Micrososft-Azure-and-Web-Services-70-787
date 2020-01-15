using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise.BlueYonder.Flights
{
    public class FlightsContext : DbContext
    {
        public FlightsContext(DbContextOptions<FlightsContext> options) : base(options)
        {
        }

        public DbSet<Flight> Flights { get; set; }
    }
}
