namespace OOPracticeTest
{
    using OOPractice;
    using Xunit;

    public class CarTest
    {
        [Fact]
        public void Should_Show_Message_With_Name_And_Speed_When_Speed_Up()
        {
            //given
            var expected = "speed up 30 km/h";
            //when
            var car = new Car("Cool Car", 30);
            var actual = car.SpeedUp();
            //then
            Assert.Equal(actual, expected);
        }
    }
}
