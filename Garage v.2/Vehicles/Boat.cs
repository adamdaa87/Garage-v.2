using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.Vehicles
{
    public class Boat : Vehicle
    {
        public int Length { get; set; }

        public Boat (string regNo, string color, int nrOfWheels, string fuelType, int length)
            : base (regNo, color, nrOfWheels, fuelType)
        {
            Length = length;
        }

        public override string GetDescription()
        {
            return $"Length is {Length} m";
        }
    }
}
