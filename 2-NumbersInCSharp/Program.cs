using System;

namespace _2_NumbersInCSharp
{
	class Program
	{
		static void Main(string[] args)
		{
			WorkingWithIntegers();
			OrderPrecedence();
			IntegerPrecissionAndLimits();
			WorkingWithDouble();
			WorkingWithDecimal();
		}

		static void WorkingWithIntegers()
		{
			int a = 18;
			int b = 6;
			int c = a + b;
			Console.WriteLine(c);
			c = a - b;
			Console.WriteLine(c);
			c = a * b;
			Console.WriteLine(c);
			c = a / b;
			Console.WriteLine(c);
		}

		static void OrderPrecedence()
		{
			int a = 5;
			int b = 4;
			int c = 2;
			int d = a + b * c;
			Console.WriteLine(d);

			d = (a + b) * c;
			Console.WriteLine(d);

			d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
			Console.WriteLine(d);

			int e = 7;
			int f = 4;
			int g = 3;
			int h = (e + f) / g;
			Console.WriteLine(h);
		}

		static void IntegerPrecissionAndLimits()
		{
			int a = 7;
			int b = 4;
			int c = 3;
			int d = (a + b) / c;
			int e = (a + b) % c;
			Console.WriteLine($"quotient: {d}");
			Console.WriteLine($"remainder: {e}");
			//int d = (a + b) / c   //Output: 3. Integer division always produces integer result

			int max = int.MaxValue;
			int min = int.MinValue;
			Console.WriteLine($"The range of integers is {min} to {max}");

			int what = max + 3;
			Console.WriteLine($"An example of overflow: {what}");
		}

		static void WorkingWithDouble()
		{
			double a = 5;
			double b = 4;
			double c = 2;
			double d = (a + b) / c;
			Console.WriteLine(d);

			double e = 19;
			double f = 23;
			double g = 8;
			double h = (e + f) / g;
			Console.WriteLine(h);

			double max = double.MaxValue;
			double min = double.MinValue;
			Console.WriteLine($"The range of double is {min} to {max}");

			double third = 1.0 / 3.0;       //Doubles can have rounding errors
			Console.WriteLine(third);       //0.3 repeating is not the same as 1/3
		}

		static void WorkingWithDecimal()
		{
			decimal min = decimal.MinValue;             //Range is smaller than double, however precision is better
			decimal max = decimal.MaxValue;
			Console.WriteLine($"The range of the decimal type is {min} to {max}");

			double a = 1.0;                             //Output: 0.333333333333333
			double b = 3.0;
			Console.WriteLine(a / b);

			decimal c = 1.0M;
			decimal d = 3.0M;
			Console.WriteLine(c / d);                   //Output: 0.3333333333333333333333333333

			double radius = 2.50;
			double area = Math.PI * radius * radius;
			Console.WriteLine(area);
		}
	}
}
