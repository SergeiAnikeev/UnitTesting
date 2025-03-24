
using FluentAssertions;
using TestingTechniques;
using Xunit;

namespace CalculatorLibrary.Tests.Unit
{
    public class ValueSamplesTests
    {
        private readonly ValueSamples _sut = new();


        [Fact]
        public void StringAssertionExample()
        {
            var fullName = _sut.FullName;
            fullName.Should().Be("John Jones");
            fullName.Should().NotBeEmpty();
            fullName.Should().StartWith("John");
            fullName.Should().EndWith("Jones");
        }

        [Fact]
        public void NumbersAssertionExample()
        {
            var age = _sut.Age;

            age.Should().Be(25);
            age.Should().BePositive();
            age.Should().BeGreaterThan(20);
            age.Should().BeInRange(18, 60);

        }

        [Fact]
        public void DateAssertionExample()
        {
            var date = _sut.DateOfBirth;

            date.Should().Be(new(2000, 1, 1));
            date.Should().BeOnOrAfter(new(2000, 1, 1));

        }

        [Fact]
        public void ObjectAssertionExample()
        {

        }
    }
}
