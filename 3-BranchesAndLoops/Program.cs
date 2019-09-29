using System;

namespace _3_BranchesAndLoops
{
	class Program
	{
		static void Main(string[] args)
		{
			ExploreIf();
			ExploreWhile();
			ExploreDoWhile();
			ExploreForLoop();
			CombineBranchesAndLoop();
		}
		static void ExploreIf()
		{
			int a = 5;
			int b = 3;
			if (a + b > 10)
			{
				Console.WriteLine("The answer is greater than 10");
			}
			else
			{
				Console.WriteLine("The answer is not greater than 10");
			}

			int c = 4;
			if ((a + b + c > 10) && (a > b))
			{
				Console.WriteLine("The answer is greater than 10");
				Console.WriteLine("And the first number is greater than the second");
			}
			else
			{
				Console.WriteLine("The answer is not greater than 10");
				Console.WriteLine("Or the first number is not greater than the second");
			}

			if ((a + b + c > 10) || (a > b))
			{
				Console.WriteLine("The answer is greater than 10");
				Console.WriteLine("Or the first number is greater than the second");
			}
			else
			{
				Console.WriteLine("The answer is not greater than 10");
				Console.WriteLine("And the first number is not greater than the second");
			}
		}

		static void ExploreWhile()
		{
			int counter = 0;
			while (counter < 10)
			{
				Console.WriteLine($"Hello World! The counter is {counter}");
				counter++;
			}
		}

		static void ExploreDoWhile()
		{
			int counter = 0;
			do
			{
				Console.WriteLine($"Hello World! The counter is {counter}");
				counter++;
			} while (counter < 10);
		}

		static void ExploreForLoop()
		{
			for (int index = 0; index < 10; index++)
			{
				Console.WriteLine($"Hello World! The index is {index}");
			}
		}

		static void CombineBranchesAndLoop()
		{
			int sum = 0;
			for (int number = 1; number < 21; number++)
			{
				if (number % 3 == 0)
				{
					sum += number;
				}
			}
			Console.WriteLine($"The sum is {sum}");
		}
	}
}
