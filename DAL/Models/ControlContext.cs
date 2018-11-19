using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DAL.Models
{
    public class ControlContext : DbContext
    {
        public ControlContext(DbContextOptions<ControlContext> options)
            : base(options)
        { }

        public DbSet<Manager> Overrides { get; set; }
        public DbSet<Scheduler> Schedules { get; set; }
    }
}