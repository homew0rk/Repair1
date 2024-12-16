using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Repair1.models;

namespace Repair1.Data
{
    public class Repair1Context : DbContext
    {
        public Repair1Context (DbContextOptions<Repair1Context> options)
            : base(options)
        {
        }

        public DbSet<Repair1.models.Staff> Staff { get; set; } = default!;
        public DbSet<Repair1.models.Client> Client { get; set; } = default!;
        public DbSet<Repair1.models.Service> Service { get; set; } = default!;
        public DbSet<Repair1.models.Request> Request { get; set; } = default!;
    }
}
