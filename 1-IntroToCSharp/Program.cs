using System;								// Importing System library (it is used by Console class, Int32, and string classes as well)

namespace _1_IntroToCSharp					// Namespaces are used to group and organize code
{
	class Program
	{
		static void Main(string[] args)		// Main is the static entrypoint method that returns void, and accepts more arguments
											// This is where program starts
		{
			// Hello World

			Console.WriteLine("Hello World!");
			System.Console.WriteLine("Hello World!");

			// Variables

			string aFriend = "Bill";
			Console.WriteLine(aFriend);

			aFriend = "Maira";
			Console.WriteLine("Hello " + aFriend);
			Console.WriteLine($"Hello {aFriend}"); // String interpolation

			// Strings

			string firstFriend = "Maria";
			string secondFriend = "Sage";
			Console.WriteLine($"My friends are {firstFriend} and {secondFriend}");
			Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
			Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

			// Do more with strings

			string greeting = "      Hello World!       ";
			Console.WriteLine($"[{greeting}]");

			string trimmedGreeting = greeting.TrimStart();
			Console.WriteLine($"[{trimmedGreeting}]");

			trimmedGreeting = greeting.TrimEnd();
			Console.WriteLine($"[{trimmedGreeting}]");

			trimmedGreeting = greeting.Trim();
			Console.WriteLine($"[{trimmedGreeting}]");

			string sayHello = "Hello World!";
			Console.WriteLine(sayHello);
			sayHello = sayHello.Replace("Hello", "Greetings");
			Console.WriteLine(sayHello);

			Console.WriteLine(sayHello.ToUpper());
			Console.WriteLine(sayHello.ToLower());

			// Search strings

			string songLyrics = "You say goodbye, and I say hello";
			Console.WriteLine(songLyrics.Contains("goodbye"));
			Console.WriteLine(songLyrics.Contains("greetings"));

			Console.WriteLine(songLyrics.StartsWith("You"));
			Console.WriteLine(songLyrics.StartsWith("goodbye"));

			Console.WriteLine(songLyrics.EndsWith("hello"));
			Console.WriteLine(songLyrics.EndsWith("goodbye"));

			var result = songLyrics.EndsWith("hello");
			Console.WriteLine(result);
		}
	}
}
