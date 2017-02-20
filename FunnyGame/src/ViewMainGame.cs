using System;

namespace FunnyGame
{
	public class ViewMainGame
	{
		private readonly string[] optionsGame = new[]
		{
			"1. The Game User vs Computer",
			"2. The Game User vs User",
			"3. The Game Computer vs Computer"
		};

		public void PrintOptionsGame()
		{
			foreach (var itemOptions in optionsGame)
			{
				Console.WriteLine(itemOptions);
			}
		}

		public int GetChoiceOption(string choiceGamer)
		{
			Console.Write("Your Choice: ");
			return Convert.ToInt16(Console.ReadLine());
		}
	}
}