﻿using System;
namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car(string name, double speed) : base(name, speed)
        {
        }
    }

    public class Truck : Vehicle
    {
        public Truck(string name, double speed) : base(name, speed)
        {
        }
    }

    public class Vehicle
    {
        public Vehicle(string name, double speed)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public string Name { get; }
        public double Speed { get; }

        public string SpeedUp()
        {
            return $"{Name}: speed up {Speed} km/h";
        }
    }

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
