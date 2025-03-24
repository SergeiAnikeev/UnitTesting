
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
            var expected = new User
            {
                FullName = "John Jones",
                Age = 25,
                DateOfBirth = new(2000, 1, 1)
            };

            var user = _sut.AppUser;

            //Assert.Equal(expected, user);
            user.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void EnumerableAssertionExample()
        {
            var expected = new User
            {
                FullName = "John Jones",
                Age = 25,
                DateOfBirth = new(2000, 1, 1)
            };

            var users = _sut.Users.As<User[]>();

            users.Should().ContainEquivalentOf(expected);
            users.Should().HaveCount(3);
            users.Should().Contain(x => x.FullName.StartsWith("John") && x.Age > 18);

        }


        [Fact]
        public void Exception_ThrownAsseretion()
        {
            var calculator = new Calculator();

            Action result = () => calculator.Divide(1, 0);

            result.Should().Throw<DivideByZeroException>().WithMessage("Attempted to divide by zero.");

        }

        [Fact]
        public void EventRaisedAssertionExample()
        {
            var monitorSubject = _sut.Monitor();

            _sut.RaiseExampleEvent();

            monitorSubject.Should().Raise("ExampleEvent");
        }

        [Fact]
        public void TestInternalMembersExample()
        {
            var number = _sut.InternalSecretNumber;

            number.Should().Be(42);
        }
        }
}
