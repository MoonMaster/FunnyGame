using FunnyGame.Interface;

namespace FunnyGame.Model
{
	public abstract class GameSimulationBasic
	{
		protected Game GameSituation;
		protected ISequenceGame ViewerGame;

		protected GameSimulationBasic(Game gameSituation, ISequenceGame viewerGame)
		{
			GameSituation = gameSituation;
			ViewerGame = viewerGame;
		}

		public abstract void StartGame();
	}
}