using System;
namespace OOPractice
{
    public class Car
    {
        public Car(string name, double speed)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public string Name { get; }
        public double Speed { get; }

        public string SpeedUp()
        {
            return "speed up 30 km/h";
        }
    }
}
