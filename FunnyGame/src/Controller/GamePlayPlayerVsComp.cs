using System;
using System.Linq;
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
				Game game = new Game(playerOne, opposerPlayer);
				SimulationGame(game, statistics);
				if (browserGame.IsShowStatistics())
				{
					statistics.PrintStatistics();
				}

			} while (browserGame.IsExit());

		}

		public void SimulationGame(Game game, Statistics statistics)
		{

			Console.Write("Input Number {0}", game.FirstPlayer.PlayerName);

			var choiceGamer = Console.ReadLine();


			int numberGame = Convert.ToInt16(choiceGamer.Trim());
			int numberOpponent = rnd.Next(0, 100);
			Console.WriteLine("The {0} generate number: {1}", game.SecondPlayer.PlayerName, numberOpponent);

			int resmultiply = numberOpponent * numberGame;
			Console.WriteLine("The multiply: " + resmultiply);

			int firstDigits = CheckFirstDigital(resmultiply);
			statistics.SetStatistics(firstDigits);

			if (firstDigits == 0)
			{
				Console.WriteLine("Continuo game. DRAW");
			}
			else if (game.FirstPlayer.SetNumber.Contains(firstDigits))
			{
				Console.WriteLine("The player {0} is WIN", game.FirstPlayer.PlayerName);
			}
			else
			{
				Console.WriteLine("The player {0} is Win", game.SecondPlayer.PlayerName);
			}


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