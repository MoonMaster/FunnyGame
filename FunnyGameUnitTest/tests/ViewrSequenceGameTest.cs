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
		private Player _testPlayer;
		private Player _secondTestPlayer;
		private GameViewerSequenceGame _testObj;
		public GameViewerSequenceGame viewer = new GameViewerSequenceGame();

		[SetUp]
		public void init()
		{
			_testPlayer = new Player("test", new []{1,2,3});
			_secondTestPlayer = new Player("test2", new[] {4, 5, 6, 7, 8, 9});
			_testObj = new GameViewerSequenceGame();
		}

		[TestCase("12", 12)]
		[TestCase("100", 100)]
		public void GetNumberPlayerPositivTest(string inputValue, int expectedValue)
		{
			var sr = new StringReader(inputValue);
			Console.SetIn(sr);

			int result = _testObj.GetNumberPlayer(_testPlayer);

			Assert.AreEqual(expectedValue,result);
		}

		[Test]
		public void CheckCorrectModeGame()
		{
			var result = viewer.CheckCorrectModeGame(_testPlayer);
			int[] expected = new[] {4, 5, 6, 7, 8, 9};

			Assert.AreEqual(expected,result);
		}

		[Test]
		public void CheckCorrectModeGameTwo()
		{
			var result = viewer.CheckCorrectModeGame(_secondTestPlayer);
			int[] expecterdResult = new[] {1, 2, 3};

			Assert.AreEqual(expecterdResult,result);
		}

		[TearDown]
		public void Dispose()
		{
			_testPlayer = null;
			_secondTestPlayer = null;
			_testObj = null;
		}
	}
}