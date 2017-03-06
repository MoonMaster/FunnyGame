using System;
using System.Text.RegularExpressions;

namespace FunnyGame.View
{
	public class PresentorGamePlayPlayerVsPlayer : Presentor
	{

		private string patternName = @"^[A-Z][a-z]+$";
		private string patternModeGame = @"^[e|o]$";

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

		public bool IsExit()
		{
			string message = "For Exit input X";
			WriteMessage(message);
			string checkPlayer = Console.ReadLine();
			if (checkPlayer == null)
				return true;
			if (checkPlayer.Trim() == "X" || checkPlayer.Trim() == "x")
				return false;
			if (checkPlayer.Trim().Length > 0)
				return true;
			return true;
		}

		public string GetCorrectPlayerName()
		{
			string message = "What is your name?";
			string errorMessage = "Invalid player Name";
			string playerName;
			do
			{
				WriteMessage(message);
				playerName = Console.ReadLine();
				if (!IsValidValue(playerName, patternName))
				{
					WriteMessage(errorMessage);
				}
			} while (!IsValidValue(playerName, patternName));
			return playerName;
		}
		// return 0 - {1,2,3} ; 1 - {4,5,6,7,8,9}
		public int GetCorrectModeGame()
		{
			string message = "What is choice mode game?";
			string errorMessage = "Wrong choice mode game";
			string modeGame;
			do
			{
				WriteMessage(message);
				base.ShowMenu();
				modeGame = Console.ReadLine();
				if (!IsValidValue(modeGame, patternModeGame))
				{
					WriteMessage(errorMessage);
				}
			} while (!IsValidValue(modeGame, patternModeGame));
			return modeGame == "o" ? 0 : 1;

		}

		public bool IsShowStatistics()
		{
			string message = "Show Statistics? Y or N";
			WriteMessage(message);
			var choiceGame = Console.ReadLine();
			if (choiceGame == "Y")
				return true;
			return false;
		}

		#region private method

		private bool IsValidValue(string str, string pattern)
		{
			Regex regex = new Regex(pattern);
			var matches = regex.Match(str);
			return matches.Success;
		}

		private void WriteMessage(string message)
		{
			Console.WriteLine(message);
		}

		#endregion private method
	}
}