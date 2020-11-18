using System;
namespace OOPractice
{
    public class Car : Vehicle
    {
        public Car(string name, IEngine engine) : base(name)
        {
            this.Speed = engine.GetSpeed();
        }
    }
}
