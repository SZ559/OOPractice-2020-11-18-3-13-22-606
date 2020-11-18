namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Speed_Up_Car()
        {
            //given
            var expected = "Cool Car: speed up 30 km/h";
            //when
            var engine = new GasolineEngine();
            var car = new Car("Cool Car", engine);
            var actual = car.SpeedUp();
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Speed_Up_For_Truck()
        {
            //given
            var expected = "Big Truck: speed up 10 km/h";
            //when
            var truck = new Truck("Big Truck", 10);
            var actual = truck.SpeedUp();
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_Drive_Car_And_Show_Message_When_Speed_Up()
        {
            //given
            var expected = "Cool Car: speed up 30 km/h";
            //when
            var engine = new GasolineEngine();
            var vehicle = new Car("Cool Car", engine);
            var driver = new Driver(vehicle);
            var actual = driver.SpeedUp();
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_Drive_Truck_And_Show_Message_When_Speed_Up()
        {
            //given
            var expected = "Big Truck: speed up 10 km/h";
            //when
            var vehicle = new Truck("Big Truck", 10);
            var driver = new Driver(vehicle);
            var actual = driver.SpeedUp();
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_Has_Gasoline_Enginee_And_Has_Speed_30()
        {
            //given
            var expected = "Cool Car: speed up 30 km/h";
            //when
            var engine = new GasolineEngine();
            var vehicle = new Car("Cool Car", engine);
            var driver = new Driver(vehicle);
            var actual = driver.SpeedUp();
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_Has_Electric_Enginee_And_Has_Speed_25()
        {
            //given
            var expected = "Cool Car: speed up 25 km/h";
            //when
            var engine = new ElectricEngine();
            var vehicle = new Car("Cool Car", engine);
            var driver = new Driver(vehicle);
            var actual = driver.SpeedUp();
            //then
            Assert.Equal(actual, expected);
        }
    }
}
