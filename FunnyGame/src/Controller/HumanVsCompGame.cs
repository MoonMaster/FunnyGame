using System;
using FunnyGame.Interface;
using FunnyGame.Model;
using FunnyGame.View;

namespace FunnyGame.Controller
{
	public class HumanVsCompGame : GenerateUser, IGameMode
	{
		public void Play()
		{

			Random rnd = new Random();

			var viewer = new GameViewerSequenceGame();

			Player firstPlayer = GenerateCorrectPlayer();

			Player computerPlayer = GenerateCorrectComputerPlayer(firstPlayer);

			Game game = new Game(firstPlayer,computerPlayer);

			while (viewer.IsExit())
			{
				int firstNumber = viewer.GetNumberPlayer(game.FirstPlayer);

				game.FirstPlayer.ConceivedNumbersPlayer.Add(firstNumber);

				int secondNumber = rnd.Next(10000);

				game.SecondPlayer.ConceivedNumbersPlayer.Add(secondNumber);

				int result = viewer.MultiplyResultPlayer(game);

				viewer.ShowMessageForWinRound(result,game);
			}
		}
	}
}