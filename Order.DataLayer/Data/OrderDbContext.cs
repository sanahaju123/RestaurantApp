using Microsoft.EntityFrameworkCore;
using Order.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Order.WebAPI.Data
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Orders> Orders { get; set; }
    }
}
