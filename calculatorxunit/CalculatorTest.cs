using System;
using Xunit;
using calculatorlib;

namespace calculatorxunit
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
			Calculator calc = new Calculator();
			Result actual = calc.Add(5);
			Assert.Equal(0, actual.LastValue);
			Assert.Equal(5, actual.Value);
        }
    }
}
