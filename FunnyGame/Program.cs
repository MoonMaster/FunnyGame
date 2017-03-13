using System;
using FunnyGame.Controller;
using FunnyGame.View;
using NLog;

namespace FunnyGame
{
	class Program
	{
		
		static void Main(string[] args)
		{
			GameLog.WriteMessage("The Game started");
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
						GameLog.WriteMessage("Checl first mode game");
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
