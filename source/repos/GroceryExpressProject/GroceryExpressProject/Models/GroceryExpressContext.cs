using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroceryExpressProject.Models
{
    public class GroceryExpressContext:DbContext
    {
        public GroceryExpressContext(DbContextOptions<GroceryExpressContext> options) : base(options) { }
        public DbSet<Customer_Details> Customers { get; set; }
        public DbSet<Driver_Details> Drivers { get; set; }
        public DbSet<order> Orders{ get; set; }
        public DbSet<Products> Prodcut { get; set; }
    }
}
