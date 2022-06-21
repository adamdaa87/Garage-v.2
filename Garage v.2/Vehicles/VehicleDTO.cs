using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.Vehicles
{
    public class VehicleDTO: Vehicle
    {
        public VehicleDTO(string regNo, string color, int nrOfWheels, string fuelType)
        {
            RegNo = regNo.ToUpper(); // Registration number always in uppercase
            Color = color;
            NrOfWheels = nrOfWheels;
            FuelType = fuelType;
        }
        public override string GetDescription()
        {
            return "DTO";
        }
    }
}
