using System;
namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car(string name, double speed) : base(name, speed)
        {
        }

        public string SpeedUp()
        {
            return $"{Name} Car: speed up {Speed} km/h";
        }
    }

    public class Truck : Vehicle
    {
        public Truck(string name, double speed) : base(name, speed)
        {
        }

        public string SpeedUp()
        {
            return $"{Name} Truck: speed up {Speed} km/h";
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
    }
}
