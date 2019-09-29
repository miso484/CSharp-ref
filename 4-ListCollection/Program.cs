using System;
using System.Collections.Generic;				//List<T>

namespace _4_ListCollection
{
	class Program
	{
		static void Main(string[] args)
		{
			//WorkingWithLists();
			ListsOfOtherTypes();
		}

		static void WorkingWithLists()
		{
			// Create lists

			var names = new List<string> { "<name>", "Ana", "Felipe" };
			foreach (var name in names)
			{
				Console.WriteLine($"Hello {name.ToUpper()}!");
			}

			// Modify list contents

			Console.WriteLine();
			names.Add("Maria");
			names.Add("Bill");
			names.Remove("Ana");
			foreach (var name in names)
			{
				Console.WriteLine($"Hello {name.ToUpper()}!");
			}

			Console.WriteLine($"My name is {names[0]}.");
			Console.WriteLine($"I've added {names[2]} and {names[3]} to the list.");
			Console.WriteLine($"The list has {names.Count} people in it");

			// Search and sort lists

			var index = names.IndexOf("Felipe");			//1
			if (index != -1)
				Console.WriteLine($"The name {names[index]} is at index {index}");

			var notFound = names.IndexOf("Not Found");		//-1
			Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");

			names.Sort();
			foreach (var name in names)
			{
				Console.WriteLine($"Hello {name.ToUpper()}!");
			}
		}

		static void ListsOfOtherTypes()
		{
			// Lists of other types

			var fibonacciNums = new List<int> { 1, 1 };

			var prev = fibonacciNums[fibonacciNums.Count - 1];
			var prev2 = fibonacciNums[fibonacciNums.Count - 2];

			fibonacciNums.Add(prev + prev2);

			foreach (var item in fibonacciNums)
				Console.WriteLine(item);

			// Challenge - write the code to generate the first 20 numbers in the sequence. (The 20th Fibonacci number is 6765.)

			var fibonacciNumbers = new List<int> { 1, 1 };

			while (fibonacciNumbers.Count < 20)
			{
				var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
				var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

				fibonacciNumbers.Add(previous + previous2);
			}
			foreach (var item in fibonacciNumbers)
				Console.WriteLine(item);
		}
	}
}
