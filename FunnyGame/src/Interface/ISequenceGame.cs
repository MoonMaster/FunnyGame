using FunnyGame.Model;

namespace FunnyGame.Interface
{
	public interface ISequenceGame
	{
		bool IsExit();
		string GetCorrectPlayerName();
		int[] GetCorrectModeGame();
		bool IsShowStatistics();
		int GetNumberPlayer(Player player);
		int MultiplyResultPlayer(Game gameUser);
		void ShowMessageForWinRound(int firstDigits, Game gameUser);
	}
}