using FunnyGame.Model;
using NUnit.Framework;

namespace FunnyGameUnitTest.tests
{
	[TestFixture]
	public class UserValidateTests
	{
		private UserValedate _validate;

		[SetUp]
		public void SetUp()
		{
			_validate = new UserValedate();
		}

		[TestCase("Abc")]
		[TestCase("Test")]
		public void Test_ReturnTrueIfUserNameIsCorrect(string userName)
		{
			var result = _validate.IsValidateUserName(userName);
			Assert.IsTrue(result);
		}
		[TestCase("TEst")]
		[TestCase("Abc1")]
		[TestCase("12Abc12")]
		[TestCase("ABc")]
		[TestCase(" ")]
		public void Test_ReturnFailseWhenUserNameIsNotValidate(string userName)
		{
			var result = _validate.IsValidateUserName(userName);
			Assert.IsFalse(result);
		}
		[TestCase("e")]
		[TestCase("o")]
		public void Test_ReturnTrueWhenUserInputCorrectModeGame(string inputModeGame)
		{
			var result = _validate.IsValidateChoiceModeGame(inputModeGame);
			Assert.IsTrue(result);
		}

		
		[TearDown]
		public void TearnDown()
		{
			_validate = null;
		}

	}
}