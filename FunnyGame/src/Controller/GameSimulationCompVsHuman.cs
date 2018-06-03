using System;
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
			//Statistics statistics = new Statistics();
			//do
			//{
			//	GameSituation.FirstPlayer.ConceivedNumbersPlayer.Add(ViewerGame.GetNumberPlayer(GameSituation.FirstPlayer));
				
			//	GameSituation.SecondPlayer.ConceivedNumbersPlayer.Add(rnd.Next(0,1000));
				
			//	var firstDigits = GameCheckedHelper.GetFirstDigitInNumber(ViewerGame.MultiplyResultPlayer(GameSituation));

			//	ViewerGame.ShowMessageForWinRound(firstDigits, GameSituation);
				
			//	statistics.SetStatistics(firstDigits);

			//	if (ViewerGame.IsShowStatistics())
			//	{
			//		statistics.ShowStatistics();
			//	}

			//} while (ViewerGame.IsExit());
		}
	}
}