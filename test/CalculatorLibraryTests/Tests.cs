﻿namespace CalculatorLibrary.Tests.Unit
{
    public class Tests
    {
        [Fact]
        public void TestAdd()
        {
            var calculator = new Calculator();
            var result = calculator.Add(1,2);
            Assert.Equal(3, result);
        }
    }
}
