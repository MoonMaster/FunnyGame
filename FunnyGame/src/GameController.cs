using System;

namespace FunnyGame
{
	public class GameController
	{
		public void Run()
		{
			ViewGame viewerGame = new ViewGame();

			Person gamerPerson = viewerGame.InitGameInformation();

			Console.WriteLine("How iteration?");
			int counter = Convert.ToInt16(Console.ReadLine());
			viewerGame.playFunnyGame(gamerPerson, counter);
		}
	}
}