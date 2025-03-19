namespace CalculatorLibrary.Tests.Unit
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldAddTwoNumbers_WhenTwoNumbersAreIntegers ()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1,2);
            Assert.Equal(3, result);
        }
    }
}
