using System.Text.RegularExpressions;

namespace FunnyGame
{
	public class PersonController
	{
		private string pattern = @"^[A-Z][a-z]+$";
		private string patterChoice = @"^[e|o]$";

		public bool CheckCorrectGameName(string gameName)
		{
			Regex regex = new Regex(this.pattern);
			var resultRegex = regex.Match(gameName.Trim());
			return resultRegex.Success;
		}

		public bool CheckCorrectChoiceGamer(string choiceGamer)
		{
			Regex regex = new Regex(this.patterChoice);
			var resultRegex = regex.Match(choiceGamer.Trim());
			return resultRegex.Success;
		}
	}
}