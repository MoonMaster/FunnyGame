using System;
using FunnyGame.Controller;
using FunnyGame.View;
using NLog;

namespace FunnyGame
{
	class Program
	{
		private static Logger logger = LogManager.GetLogger("FunnyGame");
		static void Main(string[] args)
		{
			logger.Info("The Game started");
			PresentorMainGame browserMainOptions = new PresentorMainGame();
			BrowserGame browserGame = new BrowserGame();
			browserMainOptions.WelcomeMessage();
			
			while (true)
			{
				browserMainOptions.ShowMenu();
				var choiceGamer = browserMainOptions.GetChoicePlayer();
				switch (choiceGamer.KeyChar)
				{
					case '1':
						logger.Info("Check first mode game");
						browserGame.Execute(new GamePlayPlayerVsComp());
						break;
					default:
						Console.WriteLine("Error"); 
						break;

				}
				if (choiceGamer.Key == ConsoleKey.Escape)
				{
					logger.Info("Logged out of the game");
					Environment.Exit(0);
					
				}
			}
		}
	}
}
