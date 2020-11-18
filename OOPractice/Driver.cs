using System;
using System.Collections.Generic;
using System.Text;

namespace OOPractice
{
    public class Driver
    {
        public Driver(Vehicle vehicle)
        {
            this.VehicleOwned = vehicle;
        }

        public Vehicle VehicleOwned { get; }

        public string SpeedUp()
        {
            return VehicleOwned.SpeedUp();
        }
    }
}
