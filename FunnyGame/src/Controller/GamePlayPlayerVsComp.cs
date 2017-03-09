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
			DataContractJsonSerializer jSonFormatt = new DataContractJsonSerializer(typeof(Player));

			using (FileStream fs = new FileStream("player.json", FileMode.OpenOrCreate))
			{
				jSonFormatt.WriteObject(fs, playerOne);
			}

			Player opposerPlayer = new Player("Computer");
			Statistics statistics = new Statistics();
			do
			{

				int playerNumer = browserGame.GetNumberPlayer(playerOne);
				int opponentPlayerNumber = rnd.Next(0, 100);

				var resultMultiply = playerNumer*opponentPlayerNumber;
				Console.WriteLine("Result Multiply: {0}", resultMultiply);

				int firstDigits = CheckFirstDigital(resultMultiply);
				Console.WriteLine("The first Digits in {0}: {1}",resultMultiply, firstDigits);
				statistics.SetStatistics(firstDigits);

				if (firstDigits != 0)
				{
					if (playerOne.SetNumber.Contains(firstDigits))
					{
						Console.WriteLine("The player {0} is WIN", playerOne.PlayerName);
					}
					else
					{
						Console.WriteLine("The player {0} is Win", opposerPlayer.PlayerName);
					}
				}
				else
				{
					Console.WriteLine("Continuo game. DRAW");
				}

				if (browserGame.IsShowStatistics())
				{
					statistics.PrintStatistics();
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