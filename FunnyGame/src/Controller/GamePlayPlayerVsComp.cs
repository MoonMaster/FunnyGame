using System;
using System.Linq;
using FunnyGame.Interface;
using FunnyGame.Model;
using FunnyGame.View;

namespace FunnyGame.Controller
{
	public class GamePlayPlayerVsComp : IGameMode
	{
		private string patternName = @"^[A-Z][a-z]+$";
		private string patternModeGame = @"^[e|o]$";

		public void Play()
		{
			Console.WriteLine("For exit input X");
			PresentorGamePlayPlayerVsPlayer browserGame = new PresentorGamePlayPlayerVsPlayer();
			while (true)
			{
				Console.WriteLine("What is your Name?");
				var choiceGame = Console.ReadLine();
				
				if (choiceGame == "X")
					break;
				if (!browserGame.CheckStr(choiceGame, patternName))
				{
					Console.WriteLine("The name you entered does not meet the rules");
				}
				else
				{
					Console.WriteLine("Mode Game?");
					browserGame.ShowMenu();
					var modeGame = Console.ReadLine();
					if (!browserGame.CheckStr(modeGame, patternModeGame))
					{
						Console.WriteLine("Selected the wrong game mode");
					}
					else
					{
						var seqInts = modeGame == "o" ? new[] {1, 2, 3} : new[] {4, 5, 6, 7, 8, 9};
						Player playerOne = new Player
						{
							PlayerName = choiceGame,
							SetNumber = seqInts
						};

						Player opponent = new Player {PlayerName = "Computer"};
						Game game = new Game(playerOne,opponent);
						SimulationGame(game);
					}
				}

			}
		}

		private void SimulationGame(Game game)
		{
			Random rnd = new Random();
			while (true)
			{
				Console.WriteLine("The exit input X");
				Console.Write("Input Number " + game.FirstPlayer.PlayerName + ": ");

				var choiceGamer = Console.ReadLine();

				if (choiceGamer == "X")
					break;
				int numberGame = Convert.ToInt16(choiceGamer.Trim());
				int numberOpponent = rnd.Next(0, 100);
				Console.WriteLine("The " + game.SecondPlayer.PlayerName + " generate number : " + numberOpponent);
				
				int resmultiply = numberOpponent*numberGame;
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

				if (choiceGamer == "X")
					break;
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