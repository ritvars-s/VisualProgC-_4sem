using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_seminars.Models
{
    internal class Car
    {
        [Key]
        public string VIN { get; set; }
        public int ElectricRange { get; set; }
        public int BaseMSRP { get; set; }
        public int LegislativeDistrict { get; set; }
        public int DOLVehicleID { get; set; }
        public string VehicleLocation { get; set; }
        public string ElectricUtility { get; set; }
        public int CT2020 { get; set; }


        public int LocationId { get; set; }
        public Location Location { get; set; }

        public int CarMakeId { get; set; }
        public CarMake CarMake { get; set; }

        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; }



    }
}
