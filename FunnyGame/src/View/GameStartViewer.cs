using System;

namespace FunnyGame.View
{
	public class GameStartViewer : GameViewer
	{
		private readonly string[] _optionsGame = new[]
		{
			"1. Start the game in the player against the computer mode",
			"esc. For exit"
		};
		public GameStartViewer()
		{
			base.Options = _optionsGame;
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