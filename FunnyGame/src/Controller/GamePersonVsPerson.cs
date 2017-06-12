using FunnyGame.Helper;
using FunnyGame.Interface;
using FunnyGame.Model;
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

			Player firstPlayer = new Player(firstUserName);
			Player secondPlayer = new Player(secondUserName);

			int[] modeGame = viewerGame.GetCorrectModeGame(firstPlayer);
			firstPlayer.SetNumber = modeGame;

			secondPlayer.SetNumber = viewerGame.CheckCorrectModeGame(firstPlayer);

			Game game = new Game(firstPlayer,secondPlayer);

			SimulationGame(game,viewerGame);
		}


		private void SimulationGame(Game gameUsers, ISequenceGame viewerGame)
		{
			do
			{
				gameUsers.FirstPlayer.ConceivedNumbersPlayer.Add(viewerGame.GetNumberPlayer(gameUsers.FirstPlayer));

				gameUsers.SecondPlayer.ConceivedNumbersPlayer.Add(viewerGame.GetNumberPlayer(gameUsers.SecondPlayer));


				var resultMultiply = viewerGame.MultiplyResultPlayer(gameUsers);

				var firstDigits = GameCheckedHelper.GetFirstDigitInNumber(resultMultiply);

				viewerGame.ShowMessageForWinRound(firstDigits, gameUsers);

			} while (viewerGame.IsExit());
		}
	}
}