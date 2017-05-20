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
		Player testPlayer = new Player("test", new []{1,2,3});
		GameViewerSequenceGame testObj = new GameViewerSequenceGame();

		[TestCase("12", 12)]
		[TestCase("100", 100)]
		public void GetNumberPlayerPositivTest(string inputValue, int expectedValue)
		{
			var sr = new StringReader(inputValue);
			Console.SetIn(sr);

			int result = testObj.GetNumberPlayer(testPlayer);

			Assert.AreEqual(expectedValue,result);
		}
 		
	}
}