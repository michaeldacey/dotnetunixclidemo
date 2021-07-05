using System;

namespace calculatorlib
{
    public class Calculator
    {
		private int _result = 0;
		
		public Result Add(int number)
		{
			int last = _result;
			_result += number;
			return new Result(_result, last);
		}
    }
}
