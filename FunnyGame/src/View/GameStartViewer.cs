using System;
using FunnyGame.Interface;

namespace FunnyGame.View
{
	public class GameStartViewer : GameViewer, IGameBeginViewer
	{
		private readonly string[] _optionsGame = new[]
		{
			"1. Start the game in the player against the computer mode",
			"2. Start the game in the player against the player mode",
			"esc. For exit"
		};
		public GameStartViewer()
		{
			base.Options = _optionsGame;
		}

		public ConsoleKeyInfo GetChoicePlayer()
		{
			Console.WriteLine("Your choice: ");
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