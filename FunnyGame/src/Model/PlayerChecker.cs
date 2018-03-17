using System.Text.RegularExpressions;

namespace FunnyGame.Model
{
	public class PlayerChecker
	{
		private readonly string patternUserName = @"^[A-Z][a-z]+$";

		private readonly string patternModeGame = @"^[e|o]$";

		public bool CheckPlayerName (string userName)
		{
			Regex regexp = new Regex(this.patternUserName);

			return regexp.Match(userName.Trim()).Success;

		}

		public bool CheckModeGame (string inputModeGame)
		{
			Regex regexp = new Regex(this.patternModeGame);

			return regexp.Match(inputModeGame.Trim()).Success;
		}

	}
}
