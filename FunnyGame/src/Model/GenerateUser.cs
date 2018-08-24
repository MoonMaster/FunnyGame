using FunnyGame.View;

namespace FunnyGame.Model
{
	public abstract class GenerateUser
	{
		public Player GenerateCorrectPlayer()
		{
			var viewer = new GameViewerSequenceGame();

			string playerName = viewer.GetCorrectPlayerName();

			var modeGame = viewer.GetCorrectModeGame(playerName.Trim());

			return new Player(playerName,modeGame);
		}

		public Player GenerateCorrectComputerPlayer(Player firstPlayer)
		{
			var viewer = new GameViewerSequenceGame();

			string computerName = "computer";

			var computerModeGame = viewer.CheckCorrectModeGame(firstPlayer);

			return  new Player(computerName,computerModeGame);
		}
	}
}