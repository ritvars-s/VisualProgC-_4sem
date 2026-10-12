using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bogus;
using InvoiceDbSeeding.Model;
using InvoiceDbSeeding.Enums;
using System.Security.Policy;

namespace InvoiceDbSeeding.Seeders
{
    internal class DataSeeder
    {
        public static void SeedDatabase() { 
            AppDbContext db = new AppDbContext();

            var faker = new Faker();
            Customer customer = new Customer(
                faker.Name.FullName(),
                faker.Date.Between(new DateTime(1950, 1, 1), new DateTime(1988, 1, 1)),
                faker.Internet.Email(),
                faker.Random.Enum<Gender>()

                );

            var customerFaker = new Faker<Customer>().CustomInstantiator(f => new Customer(
                faker.Name.FullName(),
                faker.Date.Between(new DateTime(1950, 1, 1), new DateTime(1988, 1, 1)),
                faker.Internet.Email(),
                faker.Random.Enum<Gender>()
                ));
            var customers = customerFaker.Generate(1000);
            db.Customers.AddRange(customers);
            db.SaveChanges();
        
        
        }



    }
}
