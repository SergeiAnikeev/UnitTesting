using FluentAssertions;
using Xunit.Abstractions;

namespace CalculatorLibrary.Tests.Unit
{
    public class CalculatorTests : IAsyncLifetime, IClassFixture<MyClassFixture>
    {
        private readonly Calculator _sut = new();
        //private readonly Guid _guid = Guid.NewGuid();
        private readonly MyClassFixture _fixture;
        private ITestOutputHelper _outputHelper;

        public CalculatorTests(ITestOutputHelper outputHelper, MyClassFixture fixture)
        {
            _outputHelper = outputHelper;
            _outputHelper.WriteLine("Hello from Ctor");
            _fixture = fixture;
        }

        [Theory]
        [InlineData(5, 5, 10)]
        [InlineData(-5, 5, 0)]
        [InlineData(-15, -5, -20)]
        public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers(int a, int b, int expected)
        {
            //Act
            var result = _sut.Add(a,b);
            
            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 5, 0)]
        [InlineData(15, 5, 10)]
        [InlineData(-5, -5, 0)]
        [InlineData(-15, -5, -10)]
        [InlineData(5, 10, -5)]
        public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers(int a, int b, int expected)
        {
            //Act
            var result = _sut.Substract(a, b);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 5, 25)]
        [InlineData(50, 0, 0)]
        [InlineData(-5, 5, -25)]
        public void Multiply_ShouldMultiplyTwoNumbers_WhenTwoNumbersAreIntegers(int a, int b, int expected)
        {
            //Act
            var result = _sut.Multiply(a, b);

            //Assert
            //Assert.Equal(expected, result);
            result.Should().Be(expected);
        }


        [Theory]
        [InlineData(5, 5, 1)]
        [InlineData(15, 5, 3)]
        public void Divide_ShouldDivideTwoNumbers_WhenTwoNumbersAreIntegers(int a, int b, int expected)
        {
            //Act
            var result = _sut.Divide(a, b);

            //Assert
            Assert.Equal(expected, result);
        }






        [Fact]
        public void Test_Guid_1()
        {
            _outputHelper.WriteLine(_fixture.id.ToString());
        }
        //[Fact(Skip = "this is just a test")]
        [Fact]
        public void Test_Guid_2()
        {
            _outputHelper.WriteLine(_fixture.id.ToString());
        }

        public async Task InitializeAsync()
        {
            _outputHelper.WriteLine("Hello from InitializeAsync");
            await Task.Delay(1);
        }

        public async Task DisposeAsync()
        {
            _outputHelper.WriteLine("Hello from DisposeAsync");
            await Task.Delay(1);
        }
    }
}
