using InvoiceDbSeeding.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceDbSeeding.Model
{
    internal class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }
        public List<Invoice> Invoices { get; set; }
        public Customer(string name, DateTime dateOfBirth, string email, Gender gender)
        {
            Name = name;
            DateOfBirth = dateOfBirth;
            Email = email;
            Gender = gender;
        }
        public Customer() { }
    }
}
