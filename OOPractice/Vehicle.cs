namespace OOPractice
{
    public class Vehicle
    {
        public Vehicle(string name)
        {
            this.Name = name;
        }

        public Vehicle(string name, double speed)
        {
            this.Name = name;
            this.Speed = speed;
        }

        public string Name { get; }
        public double Speed { get; set; }

        public string SpeedUp()
        {
            return $"{Name}: speed up {Speed} km/h";
        }
    }
}
