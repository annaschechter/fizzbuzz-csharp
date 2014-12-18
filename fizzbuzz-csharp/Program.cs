using System;

namespace fizzbuzzcsharp
{
	public class Fizzbuzz
	{
		public static void Main ()
		{
			Fizzbuzz game = new Fizzbuzz ();
			for (int i = 1; i < 100; i++) 
			{
				Console.WriteLine (game.Play (i));
			}
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

		public string Play(int number)
		{
			if (DivisibleByFifteen(number)) 
			{
				return "Fizzbuzz";
			}
			else if (DivisibleByThree(number))
			{
				return "Fizz";
			}
			else if (DivisibleByFive(number))
			{
				return "Buzz";
			}
			else 
			{
				return number.ToString();
			}
		}
	}
}
