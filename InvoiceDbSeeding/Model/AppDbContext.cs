using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InvoiceDbSeeding.Model
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            string dbPath = Path.Combine(
                AppContext.BaseDirectory,
                "app.db"
                );
            optionsBuilder.UseSqlite($"DataSource={dbPath}");
        }
    
    }
}
