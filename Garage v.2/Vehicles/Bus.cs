using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.Vehicles
{
    public class Bus : Vehicle
    {
        public int NrOfSeats { get; }
        public Bus(string regNo, string color, int nrOfWheels, string fuelType, int nrOfSeats)
            : base(regNo, color, nrOfWheels, fuelType)
        {
            NrOfSeats = nrOfSeats;
        }

        public override string GetDescription()
        {
            return $"Has {NrOfSeats} seats";
        }
    }
}
