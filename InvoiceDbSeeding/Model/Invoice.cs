using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceDbSeeding.Model
{
    internal class Invoice
    {
        public int Id { get; set; }
        public string InvoiceNumber { get; set; }
        public string Title { get; set; }
        public float TotalAmount { get; set; }

        public Customer Customer { get; set; }

        public Invoice(string invoiceNumber, string title, float totalAmount, Customer customer) {
            InvoiceNumber = invoiceNumber;
            Title = title;
            TotalAmount = totalAmount;
            Customer = customer;
        }
        public Invoice() { }
    }
}
