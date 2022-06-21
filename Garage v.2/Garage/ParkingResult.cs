using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.Garage
{
    public class ParkingResult
    {
        public bool Success { get; }
        public string Message { get; }

        public ParkingResult(bool success, string message)
        {
            Success = success;
            Message = message;
        }
    }
}
