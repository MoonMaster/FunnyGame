using System;
using FunnyGame.Controller;
using FunnyGame.Interface;
using FunnyGame.View;

namespace FunnyGame
{
	class FunnyGame
	{
		static void Main(string[] args)
		{
			GameLog.WriteMessage("The Game started");
			IGameBeginViewer viewerMainOption = new GameStartViewer();
			GameEmulation gameEmulation = new GameEmulation();
			viewerMainOption.WelcomeMessage();
			
			while (true)
			{
				viewerMainOption.ShowMenu();
				var choiceGamer = viewerMainOption.GetChoicePlayer();
				switch (choiceGamer.KeyChar)
				{
					case '1':
						GameLog.WriteMessage("Check first mode game");
						gameEmulation.Execute(new HumanVsCompGame());
						break;
					case '2':
						GameLog.WriteMessage("Check second mode game");
						//gameEmulation.Execute(new GamePersonVsPerson());
						break;
					default:
						Console.WriteLine("Error"); 
						break;

				}

				if (choiceGamer.Key != ConsoleKey.Escape) continue;
				GameLog.WriteMessage("Logged out of the game");
				Environment.Exit(0);
			}
		}
	}
}
