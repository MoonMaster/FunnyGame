using System;
using System.Text.RegularExpressions;

namespace FunnyGame.View
{
	public class PresentorGamePlayPlayerVsPlayer : Presentor
	{
		
		private readonly string[] optionsGameMode = new[]
		{
			"[o] - first part {1,2,3}",
			"[e] - second part {4,5,6,7,8,9}"
		};

		public PresentorGamePlayPlayerVsPlayer()
		{
			base.Options = optionsGameMode;
		}

		public string GetUserName()
		{
			Console.WriteLine("What is your name?");
			string playerName = Console.ReadLine();
			return playerName;
		}

		public bool CheckStr(string str, string pattern)
		{
			Regex regex = new Regex(pattern);
			var resultMatch = regex.Match(str);
			return resultMatch.Success;
		}
	}
}