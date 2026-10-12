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
        public int Id { get; set; }
        public string VIN { get; set; }
        public int ElectricRange { get; set; }
        public int BaseMSRP { get; set; }
        public int LegislativeDistrict { get; set; }
        public int DOLVehicleID { get; set; }
        public string VehicleLocation { get; set; }
        public string ElectricUtility { get; set; }
        public long CT2020 { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }

        public int CarMakeId { get; set; }
        public CarMake CarMake { get; set; }

        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; }
        public Car() { }
        public Car(string vIN, int electricRange, int baseMSRP, int legisLativeDistrict, int dOLVehicleID, string vehicleLocation, string electricUtility,
            long cT2020, int locationId, int carMakeId, int fuelTyoeId) {
        
            VIN = vIN;
            ElectricRange = electricRange;
            BaseMSRP = baseMSRP;
            LegislativeDistrict = legisLativeDistrict;
            DOLVehicleID = dOLVehicleID;
            VehicleLocation = vehicleLocation;
            ElectricUtility = electricUtility;
            CT2020 = cT2020;
            LocationId = locationId;
            CarMakeId = carMakeId;
            FuelTypeId = fuelTyoeId;
        }

    }
}
