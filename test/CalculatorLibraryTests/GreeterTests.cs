using FluentAssertions;
using NSubstitute;
using TestingTechniques;

namespace CalculatorLibrary.Tests.Unit
{
    public class GreeterTests
    {
        private readonly Greeter sut;
        private readonly IDateTimeProvider _dateTimeProvider = Substitute.For<IDateTimeProvider>();

        public GreeterTests()
        {
            sut = new Greeter(_dateTimeProvider);
        }

        [Fact]
        public void GreeterClassShouldReturnGoodMorning_WhenItIsMorning()
        {
            //Arrange
            _dateTimeProvider.DateTimeNow.Returns(new DateTime(2020, 1, 1, 9, 0, 0));

            //Act
            var result = sut.GenerateGreetMessage();

            //Assert
            result.Should().Be("Good morning");
        }

        [Fact]
        public void GreeterClassShouldReturnGoodAfternoon_WhenItIsAfternoon()
        {
            //Arrange
            _dateTimeProvider.DateTimeNow.Returns(new DateTime(2020, 1, 1, 13, 0, 0));

            //Act
            var result = sut.GenerateGreetMessage();

            //Assert
            result.Should().Be("Good afternoon");
        }
        [Fact]
        public void GreeterClassShouldReturnGoodEvening_WhenItIsEvening()
        {
            //Arrange
            _dateTimeProvider.DateTimeNow.Returns(new DateTime(2020, 1, 1, 20, 0, 0));

            //Act
            var result = sut.GenerateGreetMessage();

            //Assert
            result.Should().Be("Good evening");
        }

    }
}
