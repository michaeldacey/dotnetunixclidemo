using System;
using calculatorlib;

namespace calculatorapi
{
    public interface ICalculatorAPI
    {
        public int GetValue();
		public Result AddNumber(int number);
    }
}
