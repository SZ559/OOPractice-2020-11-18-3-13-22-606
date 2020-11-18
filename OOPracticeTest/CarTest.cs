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
            var expected = "speed up 30 km/h";
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
    }
}
