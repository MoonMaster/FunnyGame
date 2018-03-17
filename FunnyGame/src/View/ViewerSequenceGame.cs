using System;
using System.Linq;
using System.Text;
using FunnyGame.Controller;
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
			Options = _optionsGameMode;
		}

		public bool IsExit()
		{
			string message = "For Exit input X";
			ShowMessage(message);
			string checkPlayer = Console.ReadLine();
			if (checkPlayer == null)
				return true;
			if (checkPlayer.Trim() == "X" || checkPlayer.Trim() == "x")
				return false;
			if (checkPlayer.Trim().Length > 0)
				return true;
			return true;
		}

		public string GetCorrectPlayerName(int countPlayers = 1)
		{
			StringBuilder message = new StringBuilder().Clear();

			if (countPlayers == 1)
			{
				message.Append("The First Player. What is your Name?");
			}
			else if (countPlayers > 1)
			{
				message.Append("The Second Player. What is your Name?");
			}
			
			string errorMessage = "Invalid player Name";

			ShowMessage(message.ToString());

			var inputPlayerName = Console.ReadLine();

			//while (!GameCheckedHelper.IsValidUserName(inputPlayerName))
			//{
			//	ShowMessage(errorMessage);
			//	ShowMessage(message.ToString());
				inputPlayerName = Console.ReadLine();
			//}

			return inputPlayerName;
		}
		public int[] GetCorrectModeGame(string playerName)
		{
			StringBuilder message = new StringBuilder();
			string errorMessage = "Wrong choice mode game";

			message.AppendFormat("The Player {0}. What is your choice?", playerName);
			
			ShowMessage(message.ToString());
			ShowMenu();

			var modeGame = Console.ReadLine();

			//while (!GameCheckedHelper.IsValidInputModeGame(modeGame))
			//{
			//	ShowMessage(errorMessage);
			//	ShowMenu();
				modeGame = Console.ReadLine();
			//}

			return modeGame == "o" ? new int[] {1, 2, 3} : new int[] {4, 5, 6, 7, 8, 9};

		}

		public bool IsShowStatistics()
		{
			string message = "Show Statistics? Y or N";
			ShowMessage(message);
			var choiceGame = Console.ReadLine();
			return choiceGame == "Y";
		}

		public int GetNumberPlayer(Player player)
		{
			string message = "What is your number " + player.PlayerName;
			string errorMessage = "Input must be number";
			int playerNumber;
			ShowMessage(message);
			while (!int.TryParse(Console.ReadLine(), out playerNumber))
			{
				ShowMessage(errorMessage);
				ShowMessage(message);
			}
			return playerNumber;

		}

		public int MultiplyResultPlayer(Game gameUser)
		{
			//int numericValueFirstPlayer = gameUser.FirstPlayer.ConceivedNumbersPlayer.Last();
			//int numericValueSecondPlayer = gameUser.SecondPlayer.ConceivedNumbersPlayer.Last();

			//Console.WriteLine("The number player {0} is: {1}",gameUser.FirstPlayer.PlayerName,numericValueFirstPlayer);
			//Console.WriteLine("The number player {0} is: {1}", gameUser.SecondPlayer.PlayerName,numericValueSecondPlayer);

			//int multiplyRes = GameCheckedHelper.MultiplyNumber(numericValueFirstPlayer, numericValueSecondPlayer);

			//Console.WriteLine("Result multiply: {0}", multiplyRes);

			//return multiplyRes;
			return 0;

		}

		public void ShowMessageForWinRound(int firstDigits, Game gameUser)
		{
			//Console.WriteLine("The first Digits is {0}", firstDigits);
			//StringBuilder messageGame = new StringBuilder("The player is ");
			//if (firstDigits != 0)
			//{
			//	if (gameUser.FirstPlayer.SetNumber.Contains(firstDigits))
			//	{
			//		messageGame.AppendFormat("{0} Win", gameUser.FirstPlayer.PlayerName);
			//		GameLog.WriteMessage(messageGame.ToString());
			//		Console.WriteLine("The player {0} is WIN", gameUser.FirstPlayer.PlayerName);
			//	}
			//	else
			//	{
			//		messageGame.AppendFormat("{0} Win", gameUser.SecondPlayer.PlayerName);
			//		GameLog.WriteMessage(messageGame.ToString());
			//		Console.WriteLine("The player {0} is Win", gameUser.SecondPlayer.PlayerName);
			//	}
			//}
			//else
			//{
			//	string message = "In this round draw";
			//	ShowMessage(message);
			//}
			//messageGame.Clear();
		}


		public int[] CheckCorrectModeGame(Player player)
		{
			return new[] { 1, 2, 3 };
			//int[] arrayOnes = new[] {1, 2, 3};
			//return player.SetNumber.SequenceEqual(arrayOnes) ? new[] {4, 5, 6, 7, 8, 9} : arrayOnes;
		}
	}
}