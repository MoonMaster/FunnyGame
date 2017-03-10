using System;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using FunnyGame.Interface;
using FunnyGame.Model;
using FunnyGame.View;

namespace FunnyGame.Controller
{
	public class GamePlayPlayerVsComp : IGameMode
	{
		private static Random rnd = new Random();

		public void Play()
		{
			PresentorGamePlayPlayerVsPlayer browserGame = new PresentorGamePlayPlayerVsPlayer();

			string playerName = browserGame.GetCorrectPlayerName();
			int modeGame = browserGame.GetCorrectModeGame();

			Player playerOne = new Player(playerName, modeGame == 0 ? new int[] { 1, 2, 3 } : new[] { 4, 5, 6, 7, 8, 9 });
			
			Player opposerPlayer = new Player("Computer");
			Statistics statistics = new Statistics();
			do
			{

				int playerNumer = browserGame.GetNumberPlayer(playerOne);
				playerOne.ConceivedNumbersPlayer.Add(playerNumer);
				int opponentPlayerNumber = rnd.Next(0, 100);
				opposerPlayer.ConceivedNumbersPlayer.Add(opponentPlayerNumber);

				int resultMultiply = browserGame.MultiplyResultPlayer(playerOne, opposerPlayer);
				
				int firstDigits = CheckFirstDigital(resultMultiply);

				browserGame.ShowMessageForWinRound(firstDigits,playerOne,opposerPlayer.PlayerName);
				
				statistics.SetStatistics(firstDigits);

				if (browserGame.IsShowStatistics())
				{
					statistics.ShowStatistics();
				}

			} while (browserGame.IsExit());

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