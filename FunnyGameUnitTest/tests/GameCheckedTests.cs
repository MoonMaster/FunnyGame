using FunnyGame.Helper;
using NUnit.Framework;

namespace FunnyGameUnitTest.tests
{
	[TestFixture]
	public class GameCheckedTests
	{
		[TestCase("Abc")]
		[TestCase("Test")]
		public void CheckedValidUserName(string userName)
		{
			var result = GameCheckedHelper.IsValidUserName(userName);
			Assert.IsTrue(result);
		}
		[TestCase("TEst")]
		[TestCase("Abc1")]
		[TestCase("12Abc12")]
		[TestCase("ABc")]
		[TestCase(" ")]
		public void CheckUnValiedUserName(string userName)
		{
			var result = GameCheckedHelper.IsValidUserName(userName);
			Assert.IsFalse(result);
		}
		[TestCase("e")]
		[TestCase("o")]
		public void CheckedValidModeGame(string modeGame)
		{
			var result = GameCheckedHelper.IsValidInputModeGame(modeGame);
			Assert.IsTrue(result);
		}

		[TestCase(10)]
		[TestCase(1221)]
		[TestCase(1)]
		public void CheckedGetFirstDigitInNumber(int number)
		{
			var result = GameCheckedHelper.GetFirstDigitInNumber(number);
			Assert.AreEqual(1,result);
		}
	}
}