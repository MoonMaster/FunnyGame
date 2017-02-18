using System;

namespace FunnyGame
{
	public class GameController : IGameController
	{
		public void Run()
		{
			ViewGame viewerGame = new ViewGame();

			Person gamerPerson = viewerGame.InitGameInformation();

			Console.Write("How iteration? ");
			int counter = Convert.ToInt16(Console.ReadLine());
			viewerGame.PlayFunnyGame(gamerPerson, counter);
		}
	}
}