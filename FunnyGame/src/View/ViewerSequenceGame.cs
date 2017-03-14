﻿using System;
using System.Linq;
using System.Text.RegularExpressions;
using FunnyGame.Model;

namespace FunnyGame.View
{
	public class GameViewerSequenceGame : GameViewer
	{
		private string patternName = @"^[A-Z][a-z]+$";
		private string patternModeGame = @"^[e|o]$";

		private readonly string[] optionsGameMode = new[]
		{
			"[o] - first part {1,2,3}",
			"[e] - second part {4,5,6,7,8,9}"
		};

		public GameViewerSequenceGame()
		{
			base.Options = optionsGameMode;
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
			return choiceGame == "Y";
		}

		public int GetNumberPlayer(Player player)
		{
			string message = "What is your number " + player.PlayerName;
			WriteMessage(message);
			int playerNumber = Convert.ToInt16(Console.ReadLine());
			return playerNumber;

		}

		public int MultiplyResultPlayer(Player player, Player opposerPlayer)
		{
			int numberPlayer = player.ConceivedNumbersPlayer.Last();
			int numberOpposserPlayer = opposerPlayer.ConceivedNumbersPlayer.Last();

			Console.WriteLine("The number player {0} is: {1}",player.PlayerName,numberPlayer);
			Console.WriteLine("The number player {0} is: {1}", opposerPlayer.PlayerName,numberOpposserPlayer);

			int multiplyRes = numberOpposserPlayer*numberPlayer;

			Console.WriteLine("Result multiply: {0}", multiplyRes);

			return multiplyRes;

		}

		public void ShowMessageForWinRound(int firstDigits, Player playerOne, string opposerNamePlayer)
		{
			Console.WriteLine("The first Digits is {0}", firstDigits);

			if (firstDigits != 0)
			{
				if (playerOne.SetNumber.Contains(firstDigits))
				{
					Console.WriteLine("The player {0} is WIN", playerOne.PlayerName);
				}
				else
				{
					Console.WriteLine("The player {0} is Win", opposerNamePlayer);
				}
			}
			else
			{
				string message = "In this round draw";
				WriteMessage(message);
			}
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