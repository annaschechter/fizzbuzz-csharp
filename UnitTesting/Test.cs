using NUnit.Framework;
using System;
using fizzbuzzcsharp;

namespace UnitTesting
{
	[TestFixture ()]
	public class FizzbuzzTests
	{
		[Test ()]
		public void TestDivisibleByThree ()
		{
			Fizzbuzz game = new Fizzbuzz();
			Assert.AreEqual(true, game.DivisibleByThree(3));
		}

		[Test ()]
		public void TestDivisibleByFive ()
		{
			Fizzbuzz game = new Fizzbuzz();
			Assert.AreEqual(true, game.DivisibleByFive(5));
		}

		[Test ()]
		public void TestDivisibleByFifteen ()
		{
			Fizzbuzz game = new Fizzbuzz ();
			Assert.AreEqual (true, game.DivisibleByFifteen (15));
		}
	}
}

