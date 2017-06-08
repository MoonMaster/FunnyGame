using FunnyGame.Interface;
using FunnyGame.View;

namespace FunnyGame.Controller
{
	public class GamePersonVsPerson : IGameMode
	{
		public void Play()
		{
			ISequenceGame viewerGame = new GameViewerSequenceGame();

			string firstUserName = viewerGame.GetCorrectPlayerName();
			string secondUserName = viewerGame.GetCorrectPlayerName(2);


		}
	}
}