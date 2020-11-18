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
            var car = new Car("Cool", 30);
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
            var truck = new Truck("Big", 10);
            var actual = truck.SpeedUp();
            //then
            Assert.Equal(actual, expected);
        }

        [Fact]
        public void Should_Drive_Mutiple_Type_Of_Vehicle_And_Show_Message_When_Speed_Up()
        {
            //given
            var expected = "Cool Car: speed up 30 km/h";
            //when
            var vehicle = new Car("Cool Car", 30);
            var driver = new Driver(vehicle);
            var actual = driver.SpeedUp();
            //then
            Assert.Equal(actual, expected);
        }
    }
}
