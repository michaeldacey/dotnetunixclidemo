using System;

namespace calculatorlib
{
    public class Result
    {
		public int Value { get; private set; } 
		public int LastValue { get; private set; }
		
		public Result(int newValue, int last)
		{
			Value = newValue;
			LastValue = last;
		}
    }
}
