using NUnit.Framework;
using System;
using fizzbuzzcsharp;

namespace UnitTesting
{
	[TestFixture ()]
	public class FizzbuzzTests
	{
		[Test ()]
		public void TestCase ()
		{
			Fizzbuzz game = new Fizzbuzz();
			Assert.AreEqual(true, game.DivisibleByThree(3));
		}
	}
}

