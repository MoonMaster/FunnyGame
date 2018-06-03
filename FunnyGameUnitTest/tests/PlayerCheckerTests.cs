using FunnyGame.Model;
using NUnit.Framework;

namespace FunnyGameUnitTest.tests
{
	[TestFixture]
	class PlayerCheckerTests
	{
		static object[] ValidUserName =
		{
			"Test","Post","Get"
		};

		static object[] NotValidUserName =
		{
			"TEST","POST","GET","1Test","T1est"
		};
		[Category("Successfully tests username")]
		[TestCaseSource("ValidUserName")]
		public void Input_WhenUserInputName_successfully(string inputStr)
		{
			PlayerChecker checker = new PlayerChecker();

			Assert.True(checker.CheckPlayerName(inputStr));
		}

		[Category("Not Successfull user name")]
		[TestCaseSource("NotValidUserName")]
		public void Input_WherUserInputNotValidName_unsuccessfully(string inputStr)
		{
			PlayerChecker checker = new PlayerChecker();
			Assert.False(checker.CheckPlayerName(inputStr));
		}

		[TestCase("e")]
        [TestCase("o")]
        public void Input_WhenUserValidValue_successfully(string userModeGaem)
        {
            PlayerChecker checker = new PlayerChecker();

            Assert.IsTrue(checker.CheckModeGame(userModeGaem));
        }

        [TestCase("aaa")]
        [TestCase("eee")]
        [TestCase("ooo")]
        public void Input_WhenUserUnvalidValue_unsuccessfully(string userModeGame)
        {
            PlayerChecker checker = new PlayerChecker();

            Assert.IsFalse(checker.CheckModeGame(userModeGame));
        }
	}
}
