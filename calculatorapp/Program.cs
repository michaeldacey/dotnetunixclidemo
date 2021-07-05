using System;
using calculatorlib;

namespace calculatorapp
{
    class Program
    {
        static void Main(string[] args)
        {
			Calculator calc = new Calculator();
			Result res = new Result(0, 0);
			
			for(int i = 0; i < 2; i++)
				res = calc.Add(ReadNumber("Enter number: "));
				
			Console.WriteLine("Total is {0}", res.Value);
			Console.ReadKey(); // Pause
        }
		
		static int ReadNumber(string prompt)
		{
			string text;
			int number;
			Console.Write(prompt);
			text = Console.ReadLine();
			while(int.TryParse(text, out number) == false)
			{
				Console.Write(prompt);
				text = Console.ReadLine();			
			}
			return number;
		}
    }
}
