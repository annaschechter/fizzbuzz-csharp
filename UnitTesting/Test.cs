using NUnit.Framework;
using System;
using fizzbuzzcsharp;

namespace UnitTesting
{
	[TestFixture ()]
	public class FizzbuzzTests
	{
		private Fizzbuzz game;

		[SetUp]
		public void BeforeTest ()
		{
			game = new Fizzbuzz();
		}

		[Test ()]
		public void TestDivisibleByThree ()
		{
			Assert.IsTrue(game.DivisibleByThree(3));
			Assert.IsFalse(game.DivisibleByThree (1));
		}

		[Test ()]
		public void TestDivisibleByFive ()
		{
			Assert.IsTrue(game.DivisibleByFive(5));
			Assert.IsFalse(game.DivisibleByFive (1));
		}

		[Test ()]
		public void TestDivisibleByFifteen ()
		{
			Assert.IsTrue(game.DivisibleByFifteen (15));
			Assert.IsFalse(game.DivisibleByFifteen (1));
		}
	}
}

