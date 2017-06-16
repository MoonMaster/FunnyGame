using System;
using FunnyGame.Helper;
using FunnyGame.Model;
using FunnyGame.View;

namespace FunnyGame.Controller
{
	public class GameSimulationCompVsHuman : GameSimulationBasic
	{
		private static readonly Random rnd = new Random();

		public GameSimulationCompVsHuman(Game gameSituation, GameViewerSequenceGame viewerGame) : base(gameSituation, viewerGame)
		{
		}

		public override void StartGame()
		{
			Statistics statistics = new Statistics();
			do
			{
				int numberFirstPlayer = ViewerGame.GetNumberPlayer(GameSituation.FirstPlayer);
				GameSituation.FirstPlayer.ConceivedNumbersPlayer.Add(numberFirstPlayer);
				int numberSecondPlayer = rnd.Next(0, 1000);
				GameSituation.SecondPlayer.ConceivedNumbersPlayer.Add(numberSecondPlayer);

				int resultMultiply = ViewerGame.MultiplyResultPlayer(GameSituation);

				var firstDigits = GameCheckedHelper.GetFirstDigitInNumber(resultMultiply);

				ViewerGame.ShowMessageForWinRound(firstDigits, GameSituation);
				
				statistics.SetStatistics(firstDigits);

				if (ViewerGame.IsShowStatistics())
				{
					statistics.ShowStatistics();
				}

			} while (ViewerGame.IsExit());
		}
	}
}