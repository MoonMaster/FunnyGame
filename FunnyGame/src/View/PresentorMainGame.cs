using System;

namespace FunnyGame.View
{
	public class PresentorMainGame : Presentor
	{
		private readonly string[] optionsGame = new[]
		{
			"1. Start the game in the player against the computer mode"
		};
		public PresentorMainGame()
		{
			base.Options = optionsGame;
		}

		public ConsoleKeyInfo GetChoicePlayer()
		{
			Console.Write("Your choice: ");
			return Console.ReadKey();
		}
	}
}