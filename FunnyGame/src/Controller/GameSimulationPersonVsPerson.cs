using FunnyGame.Helper;
using FunnyGame.Interface;
using FunnyGame.Model;

namespace FunnyGame.Controller
{
	public class GameSimulationPersonVsPerson : GameSimulationBasic
	{
		public GameSimulationPersonVsPerson(Game gameSituation, ISequenceGame viewerGame) : base(gameSituation, viewerGame)
		{
		}

		public override void StartGame()
		{
			do
			{
				
				GameSituation.FirstPlayer.ConceivedNumbersPlayer.Add(ViewerGame.GetNumberPlayer(GameSituation.FirstPlayer));

				GameSituation.SecondPlayer.ConceivedNumbersPlayer.Add(ViewerGame.GetNumberPlayer(GameSituation.SecondPlayer));

				var resultMultiply = ViewerGame.MultiplyResultPlayer(GameSituation);

				var firstDigits = GameCheckedHelper.GetFirstDigitInNumber(resultMultiply);

				ViewerGame.ShowMessageForWinRound(firstDigits, GameSituation);

			} while (ViewerGame.IsExit());
		}
	}
}