using System;

namespace FunnyGame
{
	public class GameController
	{
		public void Run()
		{
			ViewGame viewerGame = new ViewGame();
			Person gamerPerson;

			gamerPerson = viewerGame.InitGameInformation();
		}
	}
}