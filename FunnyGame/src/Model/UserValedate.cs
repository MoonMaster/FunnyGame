using System.Text.RegularExpressions;
using FunnyGame.Interface;

namespace FunnyGame.Model
{
	public class UserValedate : IUserValidation
	{
		private string patternUserName = @"^[A-Z][a-z]+$";

		private string patternModeGame = @"^[e|o]$";

		public bool IsValidateUserName(string userName)
		{
			var regExp = new Regex(patternUserName);

			return regExp.Match(userName).Success;
		}

		public bool IsValidateChoiceModeGame(string choiceModeGame)
		{
			var regExp = new Regex(patternModeGame);

			return regExp.Match(choiceModeGame).Success;
		}
	}
}