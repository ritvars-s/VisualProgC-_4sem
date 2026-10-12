using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_seminars.Models
{
    internal class CarMake
    {
        public int Id { get; set; }
        public string Modelyear {  get; set; }
        public string Make { get; set; }
        public string Model {  get; set; }
        public CarMake() { }
        public CarMake(string modelYear, string make, string model) {
            Modelyear = modelYear;
            Make = make;
            Model = model;
        }
    }
}
