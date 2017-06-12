using FunnyGame.Model;

namespace FunnyGame.Interface
{
	public interface ISequenceGame
	{
		bool IsExit();
		string GetCorrectPlayerName(int countPlayers = 1);
		int[] GetCorrectModeGame(Player player);
		bool IsShowStatistics();
		int GetNumberPlayer(Player player);
		int MultiplyResultPlayer(Game gameUser);
		void ShowMessageForWinRound(int firstDigits, Game gameUser);
		int[] CheckCorrectModeGame(Player player);
	}
}