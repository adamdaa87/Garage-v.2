using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.Vehicles
{
    public class Airplane : Vehicle
    {
        public int NrOfEngines { get; set; }

        public Airplane(string regNo, string color, int nrOfWheels, string fuelType, int nrOfEngines)
            : base(regNo, color, nrOfWheels, fuelType)
        {
            NrOfEngines = nrOfEngines;
        }

        public override string GetDescription()
        {
            return $"Has {NrOfEngines} engine{(NrOfEngines != 1 ? "s" : "")}";
        }
    }
}
