using System;
using System.Linq;
using FunnyGame.Helper;
using FunnyGame.Interface;
using FunnyGame.Model;
using FunnyGame.View;

namespace FunnyGame.Controller
{
	public class GameCompVsHuman : IGameMode
	{
		private static Random rnd = new Random();

        #region public 

        /// <summary>
        /// The main function for play game 
        /// </summary>

        public void Play()
        {
            ISequenceGame viewerGame = new GameViewerSequenceGame();

			string playerName = viewerGame.GetCorrectPlayerName();

			int[] modeGame = viewerGame.GetCorrectModeGame(playerName);

            Player firstPlayer = new Player(playerName, modeGame);

			Player secondPlayer = new Player("Computer",CheckChoicePlayer(modeGame));

			Game gamer = new Game(firstPlayer, secondPlayer);
			
			SimulationGame(gamer, viewerGame);		

		}

        #endregion Public

        #region Private Region

        private int[] CheckChoicePlayer(int[] modeGame)
        {
            return modeGame.Contains(1) ? new int [] { 4, 5, 6, 7, 8, 9 } : new int[] { 1, 2, 3 };
        }

        private void SimulationGame(Game gameUser, ISequenceGame viewerGame)
		{
			Statistics statistics = new Statistics();
			do
			{
				int playerNumer = viewerGame.GetNumberPlayer(gameUser.FirstPlayer);
				gameUser.FirstPlayer.ConceivedNumbersPlayer.Add(playerNumer);
				int opponentPlayerNumber = rnd.Next(0, 100);
				gameUser.SecondPlayer.ConceivedNumbersPlayer.Add(opponentPlayerNumber);

				var resultMultiply = viewerGame.MultiplyResultPlayer(gameUser);

				var firstDigits = GameCheckedHelper.GetFirstDigitInNumber(resultMultiply);

				viewerGame.ShowMessageForWinRound(firstDigits, gameUser);

				statistics.SetStatistics(firstDigits);

				if (viewerGame.IsShowStatistics())
				{
					statistics.ShowStatistics();
				}

			} while (viewerGame.IsExit());
		}

		#endregion Private Region
	}
}