using System;
using System.Text.RegularExpressions;

namespace FunnyGame.Helper
{
	public static class GameCheckedHelper
	{
		public static bool IsValidUserName(string inputUserName)
		{
			var patterUserName = @"^[A-Z][a-z]+$";
			Regex regex = new Regex(patterUserName.Trim());
			var result = regex.Match(inputUserName);
			return result.Success;
		}

		public static bool IsValidInputModeGame(string inputModeGame)
		{
			var patterModeGame = @"^[e|o]$";
			Regex regex = new Regex(patterModeGame.Trim());
			var result = regex.Match(inputModeGame);
			return result.Success;
		}

		public static int GetFirstDigitInNumber(int num)
		{
			var result = Math.Abs(num);
			while (result >= 10)
			{
				result /= 10;
			}
			return result;
		}
	}
}