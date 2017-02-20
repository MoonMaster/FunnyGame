using FunnyGame;
using NUnit.Framework;

namespace FunnyGameUnitTest.tests
{
	[TestFixture]
	public class PersonControllerTests
	{
		public static PersonController TestPersonController = new PersonController();
		[TestCase("Name")]
		[TestCase("Person")]
		public void CheckCorrectGamerNamePositivValue(string gameName)
		{
			bool resultCompare = TestPersonController.CheckCorrectGameName(gameName);
			Assert.IsTrue(resultCompare);
		}

		[TestCase("person")]
		[TestCase("name")]
		[TestCase("1Person")]
		[TestCase("name123")]
		[TestCase("Name1234")]
		[TestCase("")]
		[TestCase("    ")]
		[TestCase("Nasm ds")]
		[TestCase("Name d")]
		public void CheckCorrectGameNameNegativValue(string gameName)
		{
			bool resultCompare = TestPersonController.CheckCorrectGameName(gameName);
			Assert.IsFalse(resultCompare);
		}

		[TestCase("e")]
		[TestCase("o")]
		public void CheckCorrectChoiceGamerPositiv(string choiceGamer)
		{
			bool resultCompareChoice = TestPersonController.CheckCorrectChoiceGamer(choiceGamer);
			Assert.True(resultCompareChoice);
		}

		[TestCase("a")]
		[TestCase("z")]
		[TestCase("")]
		public void CheckCorrectChoiceGaerNegativ(string choiceGamer)
		{
			bool resultCompare = TestPersonController.CheckCorrectChoiceGamer(choiceGamer);
			Assert.False(resultCompare);
		}

		[TestCase(100)]
		[TestCase(23)]
		public void CheckGenerateGamerNumberPositiv(int generateNumber)
		{
			bool resultRegex = TestPersonController.CheckGenerateNumberGamer(generateNumber);
			Assert.True(resultRegex);
		}

		[TestCase(-20)]
		[TestCase(-11)]
		public void CheckGenerateGamerNumberNegativ(int generateNumber)
		{
			bool resultRegex = TestPersonController.CheckGenerateNumberGamer(generateNumber);
			Assert.False(resultRegex);
		}
	}
}