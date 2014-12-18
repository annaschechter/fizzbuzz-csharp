using System;

namespace fizzbuzzcsharp
{
	public class Fizzbuzz
	{
		public static void Main ()
		{
			Console.WriteLine ("Hello World!");
		}

		public bool DivisibleByThree(int number)
		{
			return number % 3 == 0;
		}

		public bool DivisibleByFive(int number)
		{
			return number % 5 == 0;
		}

		public bool DivisibleByFifteen(int number)
		{
			return number % 15 == 0;
		}
	}
}
