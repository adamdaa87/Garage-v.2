using Garage_v._2.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.Garage
{
    public interface IGarage
    {
        int Capacity { get; }
        int Count { get; }

        Vehicle GetVehicle(string regNo);

        int IndexOf(string regNo);

        bool IsFull();

        Vehicle UnparkVehicle(string regNo);
    }
}
