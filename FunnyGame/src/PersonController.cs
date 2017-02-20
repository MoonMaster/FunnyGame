using System;
using System.Text.RegularExpressions;

namespace FunnyGame
{
	public class PersonController
	{
		private string pattern = @"^[A-Z][a-z]+$";
		private string patterChoice = @"^[e|o]$";
		private string patternNumber = @"^[1-9]\d+$";

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

		public bool CheckGenerateNumberGamer(int generateNumberGamer)
		{
			Regex regex = new Regex(this.patternNumber);
			var resultCheck = regex.Match(Convert.ToString(generateNumberGamer));
			return resultCheck.Success;

		}
	}
}