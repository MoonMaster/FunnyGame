using System;
using System.IO;
using FunnyGame.Model;
using FunnyGame.View;
using NUnit.Framework;

namespace FunnyGameUnitTest.tests
{
	[TestFixture]
	public class ViewrSequenceGameTest
	{
		private Player testPlayer;
		private GameViewerSequenceGame testObj;

		[SetUp]
		public void init()
		{
			testPlayer = new Player("test", new []{1,2,3});
			testObj = new GameViewerSequenceGame();
		}

		[TestCase("12", 12)]
		[TestCase("100", 100)]
		public void GetNumberPlayerPositivTest(string inputValue, int expectedValue)
		{
			var sr = new StringReader(inputValue);
			Console.SetIn(sr);

			int result = testObj.GetNumberPlayer(testPlayer);

			Assert.AreEqual(expectedValue,result);
		}

		[TearDown]
		public void dispose()
		{
			testPlayer = null;
			testObj = null;
		}
	}
}