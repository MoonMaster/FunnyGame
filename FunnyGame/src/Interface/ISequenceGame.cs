using FunnyGame.Model;

namespace FunnyGame.Interface
{
	public interface ISequenceGame
	{
		bool IsExit();
		string GetCorrectPlayerName();
		int[] GetCorrectModeGame(string playerName);
		bool IsShowStatistics();
		int GetNumberPlayer(Player player);
		int MultiplyResultPlayer(Game gameUser);
		void ShowMessageForWinRound(int firstDigits, Game gameUser);
		int[] CheckCorrectModeGame(Player player);
	}
}