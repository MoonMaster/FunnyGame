using System;
using System.Linq;
using System.Text;
using FunnyGame.Controller;
using FunnyGame.Helper;
using FunnyGame.Interface;
using FunnyGame.Model;

namespace FunnyGame.View
{
	public class GameViewerSequenceGame : GameViewer, ISequenceGame
	{
		
		private readonly string[] _optionsGameMode = new[]
		{
			"[o] - first part {1,2,3}",
			"[e] - second part {4,5,6,7,8,9}"
		};

		public GameViewerSequenceGame()
		{
			base.Options = _optionsGameMode;
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

				if (!GameCheckedHelper.IsValidUserName(playerName))
				{
					WriteMessage(errorMessage);
				}
			} while (!GameCheckedHelper.IsValidUserName(playerName));
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
				if (!GameCheckedHelper.IsValidInputModeGame(modeGame))
				{
					WriteMessage(errorMessage);
				}
			} while (!GameCheckedHelper.IsValidInputModeGame(modeGame));
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

		public int MultiplyResultPlayer(Game gameUser)
		{
			int numberPlayer = gameUser.FirstPlayer.ConceivedNumbersPlayer.Last();
			int numberOpposserPlayer = gameUser.SecondPlayer.ConceivedNumbersPlayer.Last();

			Console.WriteLine("The number player {0} is: {1}",gameUser.FirstPlayer.PlayerName,numberPlayer);
			Console.WriteLine("The number player {0} is: {1}", gameUser.SecondPlayer.PlayerName,numberOpposserPlayer);

			int multiplyRes = numberOpposserPlayer*numberPlayer;

			Console.WriteLine("Result multiply: {0}", multiplyRes);

			return multiplyRes;

		}

		public void ShowMessageForWinRound(int firstDigits, Game gameUser)
		{
			Console.WriteLine("The first Digits is {0}", firstDigits);
			StringBuilder messageGame = new StringBuilder("The player is ");
			if (firstDigits != 0)
			{
				if (gameUser.FirstPlayer.SetNumber.Contains(firstDigits))
				{
					messageGame.Append(Convert.ToString(gameUser.FirstPlayer.PlayerName));
					messageGame.Append(" is Win");
					GameLog.WriteMessage(messageGame.ToString());
					Console.WriteLine("The player {0} is WIN", gameUser.FirstPlayer.PlayerName);
				}
				else
				{
					messageGame.Append(Convert.ToString(gameUser.SecondPlayer.PlayerName));
					messageGame.Append(" is Win");
					GameLog.WriteMessage(messageGame.ToString());
					Console.WriteLine("The player {0} is Win", gameUser.SecondPlayer.PlayerName);
				}
			}
			else
			{
				string message = "In this round draw";
				WriteMessage(message);
			}
			messageGame.Clear();
		}

		#region private method

		private static void WriteMessage(string message)
		{
			Console.WriteLine(message);
		}

		#endregion private method
	}
}