using System;
using FunnyGame.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using StringAssert = Microsoft.VisualStudio.TestTools.UnitTesting.StringAssert;

namespace FunnyGameUnitTest.tests
{
	[TestFixture]
	public class CalculatorHelperTests
	{
		private CalculatorHelper calcHelper;

		[SetUp]
		public void SetUp()
		{
			calcHelper = new CalculatorHelper();
		}

		[TestCase(1, 1, 1)]
		[TestCase(10,10,1)]
		public void Test_ReturnFirstDigitalAfterMultiply(int fistNumber, int secondNumber, int expectedRes)
		{
			var result = calcHelper.GetFirstDigitalNumberMultiply(fistNumber, secondNumber);

			Assert.AreEqual(expectedRes, result);
		}

		[TestCase(-10,10)]
		[TestCase(10,-10)]
		public void Test_GetArgumentExceptionWhenValueIsNegative(int firstNumber, int secondNumber)
		{
			var expectedResult = Assert.Throws<ArgumentException>(() =>
				calcHelper.GetFirstDigitalNumberMultiply(firstNumber, secondNumber));

			StringAssert.Contains("Один из аргументов отрицательный. Проверьте вводимые значения",expectedResult.Message);
		}

		[TearDown]
		public void TearnDown()
		{
			calcHelper = null;
		}
	}
}