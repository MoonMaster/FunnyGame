using FunnyGame.Helper;
using NUnit.Framework;

namespace FunnyGameUnitTest.tests
{
	[TestFixture]
	public class GameCheckedHelperTests
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

		[TestCase(10, 1)]
		[TestCase(1221, 1)]
		[TestCase(1,1)]
		public void CheckedGetFirstDigitInNumber(int number, int expectedRes)
		{
			var outputResult = GameCheckedHelper.GetFirstDigitInNumber(number);
			Assert.AreEqual(expectedRes, outputResult);
		}

		[TestCase(1, 1, 1)]
		[TestCase(0,1000,0)]
		[TestCase(-1, -1, 1)]
		[TestCase(-10, 10, 100)]
		[TestCase(-1,1,1)]
		public void MultiplyTwoNumber(int numberOne, int numberTwo, int resultMultiply)
		{
			var outputResult = GameCheckedHelper.MultiplyNumber(numberOne, numberTwo);
			Assert.AreEqual(resultMultiply,outputResult);
		}

        [TestCase(1,1,1)]
        public void AMultiplyTwoNumber(int num1, int num2, int num3)
        {
            var outputResult = GameCheckedHelper.MultiplyNumber(num1, num2);
            Assert.AreEqual(outputResult, 1);
        }

	}
}