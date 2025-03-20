using Xunit.Abstractions;

namespace CalculatorLibrary.Tests.Unit
{
    public class CalculatorTests : IAsyncLifetime
    {
        private readonly Calculator _sut = new();
        private readonly Guid _guid = Guid.NewGuid();
        private ITestOutputHelper _outputHelper;

        public CalculatorTests(ITestOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
            _outputHelper.WriteLine("Hello from Ctor");
        }

        [Fact]
        public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers()
        {
            //Act
            var result = _sut.Add(1,2);
            
            //Assert
            Assert.Equal(3, result);
        }
        [Fact]
        public void Subtract_ShouldSubtractTwoNumbers_WhenTwoNumbersAreIntegers()
        {
            //Act
            var result = _sut.Substract(5, 4);

            //Assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void Test_Guid_1()
        {
            _outputHelper.WriteLine(_guid.ToString());
        }
        [Fact]
        public void Test_Guid_2()
        {
            _outputHelper.WriteLine(_guid.ToString());
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
