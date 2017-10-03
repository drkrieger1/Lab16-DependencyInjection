using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lab16Erik.Model;

namespace Lab16Erik.Models
{
    public class Lab16ErikContext : DbContext
    {
        public Lab16ErikContext (DbContextOptions<Lab16ErikContext> options)
            : base(options)
        {
        }

        public DbSet<Lab16Erik.Model.Location> Location { get; set; }
    }
}
