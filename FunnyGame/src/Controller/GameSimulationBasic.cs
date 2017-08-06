using FunnyGame.Interface;
using FunnyGame.Model;

namespace FunnyGame.Controller
{
	public abstract class GameSimulationBasic
	{
		protected readonly Game GameSituation;
		protected readonly ISequenceGame ViewerGame;

		protected GameSimulationBasic(Game gameSituation, ISequenceGame viewerGame)
		{
			GameSituation = gameSituation;
			ViewerGame = viewerGame;
		}

		public abstract void StartGame();
	}
}