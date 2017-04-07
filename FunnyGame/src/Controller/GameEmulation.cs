using FunnyGame.Interface;

namespace FunnyGame.Controller
{
	public class GameEmulation
	{
		public void Execute(IGameMode gameMode)
		{
			gameMode.Play();
		}
	}
}