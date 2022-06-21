using Garage_v._2.Vehicles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_v._2.Garage
{
    public class Garage<T> : IEnumerable<T>, IGarage where T : Vehicle
    {
        private Vehicle[] vehicles;

        int count;
        public int Count 
        { 
            get { return count; } 
        }
       
        public int Capacity
        {
            get { return vehicles.Length; }
        }

        public Garage(int capacity)
        {
            vehicles = new Vehicle[capacity];
            count = 0;
        }

        public ParkingResult ParkVehicle(Vehicle vehicle)
        {
            ParkingResult result;
            if (Count < vehicles.Length)
            {
                if (IndexOf(vehicle.RegNo) == -1)
                {
                    vehicles[Count] = vehicle;
                    count++;
                    result = new ParkingResult(true, null);
                }
                else
                {
                    result = new ParkingResult(false, $"{vehicle.RegNo} not unique!");
                }
            }
            else
            {
                result = new ParkingResult(false, "Garage is full");
            }
            return result;
        }
        
        public Vehicle UnparkVehicle(string regNo)
        {
            Vehicle vehicle = null; // är inte hittad

            var matchIndex = IndexOf(regNo.ToUpper());
            if(matchIndex != -1)
            {
                vehicle = vehicles[matchIndex];
                count--;
                for (int i = matchIndex; i < count; i++)
                {
                    vehicles[i] = vehicles[i + 1];
                }
            }
            return vehicle;
        }
        
        public int IndexOf(string regNo)
        {
            int matchIndex = -1; 
            for (int i= 0; i<count; i++)
            {
                if (vehicles[i].RegNo == regNo.ToUpper())
                {
                    matchIndex = i;
                    break;
                }
            }
            return matchIndex;
        }

        public Vehicle GetVehicle(string regNo)
        {
            var index = IndexOf(regNo);
            return (index != -1) ? vehicles[index] : null;
        }

        public bool IsFull()
        {
            return (vehicles.Length == count);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i= 0; i<count; i++)
            {
                yield return vehicles[i] as T;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}

