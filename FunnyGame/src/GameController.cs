using System;
using System.Linq;

namespace FunnyGame
{
	public class GameController : IGameController
	{
		public void Run()
		{
			ViewGame viewerGame = new ViewGame();
			PersonController personController = new PersonController();
			string gamerName;
			string choiceGamer;

			viewerGame.GetWelcomePage();
			do
			{
				gamerName = viewerGame.GetGamerName();
				if (!personController.CheckCorrectGameName(gamerName))
				{
					Console.WriteLine("The Gamer Name is not correct");
				}
				else
				{
					break;
				}
			} while (true);

			do
			{
				choiceGamer = viewerGame.GetChoiceModeGamer();
				if (!personController.CheckCorrectChoiceGamer(choiceGamer))
				{
					Console.WriteLine("The Mode Game is not correct");
				}
				else
				{
					break;
				}
			} while (true);

			Person gamer = new Person(gamerName, choiceGamer == "o" ? new int[]{1,2,3} : new []{4,5,6,7,8,9});
			
			do
			{
				try
				{
					int gamerNumber = viewerGame.GetNumberGame(gamer);
					if (!personController.CheckGenerateNumberGamer(gamerNumber))
					{
						Console.WriteLine("Not correct number");
					}
					else
					{
						int compNumer = viewerGame.GetNumberOpponent();
						int resultMultiply = gamerNumber*compNumer;
						viewerGame.OutputResultMultiply(resultMultiply);
						int firstDigits = CheckFirstDigital(resultMultiply);
						if (firstDigits == 0)
						{
							Console.WriteLine("Continuo game. DRAW");
						}
						else if (gamer.ModeGame.Contains(firstDigits))
						{
							Console.WriteLine("The Gamer " + gamer.PersonName + " is WIN");
						}
						else
						{
							Console.WriteLine("The Computer is Win");
						}
						Console.WriteLine("Press any key to continue. Press Esc to exit");
						if (Console.ReadKey(true).Key == ConsoleKey.Escape)
							break;
					}
				}
				catch (InvalidCastException ex)
				{
					Console.WriteLine(ex.ToString());
				}

			} while (true);
			Console.WriteLine("Exit programm");
			Console.ReadLine();
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
