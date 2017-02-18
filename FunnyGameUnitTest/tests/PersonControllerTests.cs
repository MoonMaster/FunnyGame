using FunnyGame;
using NUnit.Framework;

namespace FunnyGameUnitTest.tests
{
	[TestFixture]
	public class PersonControllerTests
	{
		public static PersonController testPersonController = new PersonController();
		[TestCase("Name")]
		[TestCase("Person")]
		public void CheckCorrectGamerNamePositivValue(string gameName)
		{
			bool resultCompare = testPersonController.CheckCorrectGameName(gameName);
			Assert.IsTrue(resultCompare);
		}

		[TestCase("person")]
		[TestCase("name")]
		[TestCase("1Person")]
		[TestCase("name123")]
		[TestCase("Name1234")]
		public void CheckCorrectGameNameNegativValue(string gameName)
		{
			bool resultCompare = testPersonController.CheckCorrectGameName(gameName);
			Assert.IsFalse(resultCompare);
		}
	}
}