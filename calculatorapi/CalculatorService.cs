using System;
using calculatorlib;

namespace calculatorapi
{
    public class CalculatorService : ICalculatorAPI
    {
		private Calculator calc = new Calculator();

        public int GetValue()
		{
            Result result = calc.Add(0);
			return result.Value;
		}
		
		public Result AddNumber(int number)
		{
            return calc.Add(number);
		}
    }
}
