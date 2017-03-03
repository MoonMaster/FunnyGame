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
			do
			{
				Game game = new Game(playerOne, opposerPlayer);
				SimulationGame(game);

			} while (browserGame.IsExit());

		}

		private void SimulationGame(Game game)
		{

			Console.Write("Input Number " + game.FirstPlayer.PlayerName + ": ");

			var choiceGamer = Console.ReadLine();


			int numberGame = Convert.ToInt16(choiceGamer.Trim());
			int numberOpponent = rnd.Next(0, 100);
			Console.WriteLine("The " + game.SecondPlayer.PlayerName + " generate number : " + numberOpponent);

			int resmultiply = numberOpponent * numberGame;
			Console.WriteLine("The multiply: " + resmultiply);

			int firstDigits = CheckFirstDigital(resmultiply);

			if (firstDigits == 0)
			{
				Console.WriteLine("Continuo game. DRAW");
			}
			else if (game.FirstPlayer.SetNumber.Contains(firstDigits))
			{
				Console.WriteLine("The Gamer " + game.FirstPlayer.PlayerName + " is WIN");
			}
			else
			{
				Console.WriteLine("The " + game.SecondPlayer.PlayerName + " is Win");
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