using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace _4_seminars.Models
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarMake> CarMakes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string path = Path.Combine(
                AppContext.BaseDirectory,
                "app.db"
                );

            optionsBuilder.UseSqlite($"Data Source={path}");

        }





    }
}
