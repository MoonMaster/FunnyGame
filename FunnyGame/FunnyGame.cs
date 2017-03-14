using System;
using FunnyGame.Controller;
using FunnyGame.View;

namespace FunnyGame
{
	class FunnyGame
	{
		static void Main(string[] args)
		{
			GameLog.WriteMessage("The Game started");
			GameStartViewer viewerMainOption = new GameStartViewer();
			GameEmulation gameEmulation = new GameEmulation();
			viewerMainOption.WelcomeMessage();
			
			while (true)
			{
				viewerMainOption.ShowMenu();
				var choiceGamer = viewerMainOption.GetChoicePlayer();
				switch (choiceGamer.KeyChar)
				{
					case '1':
						GameLog.WriteMessage("Checl first mode game");
						gameEmulation.Execute(new GameCompVsHuman());
						break;
					default:
						Console.WriteLine("Error"); 
						break;

				}
				if (choiceGamer.Key == ConsoleKey.Escape)
				{
					GameLog.WriteMessage("Logged out of the game");
					Environment.Exit(0);
					
				}
			}
		}
	}
}
