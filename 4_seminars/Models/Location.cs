using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_seminars.Models
{
    internal class Location
    {
        public int Id { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int PostalCode { get; set; }
        public Location() { }
        public Location(string county, string city, string state, int postalCode) {
            County = county;
            City = city;
            State = state;
            PostalCode = postalCode;
        }
    }
}
