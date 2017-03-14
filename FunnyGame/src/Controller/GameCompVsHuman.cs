using System;
using FunnyGame.Interface;
using FunnyGame.Model;
using FunnyGame.View;

namespace FunnyGame.Controller
{
	public class GameCompVsHuman : IGameMode
	{
		private static Random rnd = new Random();

		public void Play()
		{
			GameViewerSequenceGame viewerGame = new GameViewerSequenceGame();

			string playerName = viewerGame.GetCorrectPlayerName();
			int modeGame = viewerGame.GetCorrectModeGame();

			Player playerOne = new Player(playerName, modeGame == 0 ? new[] { 1, 2, 3 } : new[] { 4, 5, 6, 7, 8, 9 });
			
			Player secondPlayer = new Player("Computer");

			Game gamer = new Game(playerOne, secondPlayer);

			Statistics statistics = new Statistics();
			do
			{

				int playerNumer = viewerGame.GetNumberPlayer(playerOne);
				playerOne.ConceivedNumbersPlayer.Add(playerNumer);
				int opponentPlayerNumber = rnd.Next(0, 100);
				secondPlayer.ConceivedNumbersPlayer.Add(opponentPlayerNumber);

				var resultMultiply = viewerGame.MultiplyResultPlayer(playerOne, secondPlayer);
				
				var firstDigits = CheckFirstDigital(resultMultiply);

				viewerGame.ShowMessageForWinRound(firstDigits,playerOne,secondPlayer.PlayerName);
				
				statistics.SetStatistics(firstDigits);

				if (viewerGame.IsShowStatistics())
				{
					statistics.ShowStatistics();
				}

			} while (viewerGame.IsExit());

		}

		private int CheckFirstDigital(int numbr)
		{
			int result = Math.Abs(numbr);
			while (result >= 10)
			{
				result /= 10;
			}
			return result;
		}
	}
}