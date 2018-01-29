using FunnyGame.Helper;
using FunnyGame.Interface;
using FunnyGame.Model;
using FunnyGame.View;
using System.Linq;

namespace FunnyGame.Controller
{
	public class GamePersonVsPerson : IGameMode
	{
		public void Play()
		{
            ISequenceGame viewerGame = new GameViewerSequenceGame();

            string firstUserName = viewerGame.GetCorrectPlayerName();
            string secondUserName = viewerGame.GetCorrectPlayerName(2);

            int[] modeGame = viewerGame.GetCorrectModeGame(firstUserName);

            int[] modeGameSecondPlayer = CheckChoicePlayer(modeGame);

            Player firstPlayer = new Player(firstUserName, modeGame);
            Player secondPlayer = new Player(secondUserName, modeGameSecondPlayer);

            Game game = new Game(firstPlayer, secondPlayer);

            SimulationGame(game, viewerGame);
        }

        private int[] CheckChoicePlayer(int[] modeGame)
        {
            return modeGame.Contains(1) ? new int[] { 4, 5, 6, 7, 8, 9 } : new int[] { 1, 2, 3 };
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