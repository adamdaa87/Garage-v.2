using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.Vehicles
{
    public class Motorcycle : Vehicle
    {
        public string Brand { get; set; }
        public Motorcycle(string regNo, string color, int nrOfWheels, string fuelType, string brand): 
            base(regNo, color, nrOfWheels, fuelType)
        {
            Brand = brand;
        }

        public override string GetDescription()
        {
            return $"Brand is {Brand}";
        }
    }
}
