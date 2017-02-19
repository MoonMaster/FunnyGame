using System;
using System.Linq;

namespace FunnyGame
{
	public class ViewGame
	{
		private readonly string[] optionsGame =
		{
			"[o] - first part {1,2,3}",
			"[e] - second part {4,5,6,7,8,9}"
		};

		public void GetWelcomePage()
		{
			Console.WriteLine("Welcome to FunnyGame.");
		}

		public string GetGamerName()
		{
			Console.WriteLine("What is Your Name?");
			string gamerName = Console.ReadLine();
			return gamerName;
		}

		public string GetChoiceModeGamer()
		{
			ShowModeGame();
			Console.WriteLine("Your Choice?");
			string resultChoiceGamer = Console.ReadLine();
			return resultChoiceGamer;
		}

		private void ShowModeGame()
		{
			foreach (var itemOfArr in optionsGame)
			{
				Console.WriteLine(itemOfArr);
			}
		}

		public int GetNumberGame(Person gamer)
		{
			Console.Write(gamer.PersonName + " Input your number: ");
			return Convert.ToInt16(Console.ReadLine());
		}

		public int GetNumberOpponent()
		{
			Random rnd = new Random();
			Console.Write("The Compute is number: ");
			int compNumb = rnd.Next(0, 100);
			Console.WriteLine(" " + compNumb);
			return compNumb;
		}

		public void OutputResultMultiply(int result)
		{
			Console.WriteLine("Result Multiply: " + result);
		}
		
	}
}