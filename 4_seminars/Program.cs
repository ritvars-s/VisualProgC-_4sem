using _4_seminars.Models;
using Microsoft.EntityFrameworkCore;

namespace _4_seminars
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            AppDbContext db = new AppDbContext();
            db.FuelTypes.ExecuteDelete();
            db.CarMakes.ExecuteDelete();
            db.Locations.ExecuteDelete();

            db.Database.ExecuteSqlRaw(
                "DELETE FROM sqlite_sequence WHERE name = 'FuelTypes'"
                );
            db.Database.ExecuteSqlRaw(
                "DELETE FROM sqlite_sequence WHERE name = 'CarMakes'"
                );
            db.Database.ExecuteSqlRaw(
                "DELETE FROM sqlite_sequence WHERE name = 'Locations'"
                );


            Application.Run(new Form1());
        }
    }
}