using System;

namespace FunnyGame.View
{
	public class GameStartViewer : GameViewer
	{
		private readonly string[] optionsGame = new[]
		{
			"1. Start the game in the player against the computer mode",
			"esc. For exit"
		};
		public GameStartViewer()
		{
			base.Options = optionsGame;
		}

		public ConsoleKeyInfo GetChoicePlayer()
		{
			Console.Write("Your choice: ");
			return Console.ReadKey();
		}

		public void WelcomeMessage()
		{
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Welcome to Funny Game");
			Console.ResetColor();
		}
	}
}