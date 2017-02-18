using System.Text.RegularExpressions;

namespace FunnyGame
{
	public class PersonController
	{
		private string pattern = @"^[A-Z][a-z]+$";

		public bool CheckCorrectGameName(string gameName)
		{
			Regex regex = new Regex(this.pattern);
			var resultRegex = regex.Match(gameName);
			if (resultRegex.Success)
			{
				return true;
			}
			return false;
		}
	}
}