using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.Vehicles
{
    public abstract class Vehicle
    {
        public string RegNo { get; set; }
        public string Color { get; set; }
        public int NrOfWheels { get; set; }
        public string FuelType { get; set; }

        public Vehicle() { }

        public Vehicle(string regNo, string color, int nrOfWheels, string fuelType)
        {
            RegNo = regNo.ToUpper(); // Reg-nummer ska alltid vara versaler 
            Color = color;
            NrOfWheels = nrOfWheels;
            FuelType = fuelType;
        }

        public abstract string GetDescription(); 
    }
}
