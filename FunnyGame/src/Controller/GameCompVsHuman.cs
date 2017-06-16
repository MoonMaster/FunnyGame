using System;
using FunnyGame.Interface;
using FunnyGame.Model;
using FunnyGame.View;

namespace FunnyGame.Controller
{
	public class GameCompVsHuman : IGameMode
	{
		private static Random rnd = new Random();

		public void Play()
		{
			GameViewerSequenceGame viewerGame = new GameViewerSequenceGame();

			string playerName = viewerGame.GetCorrectPlayerName();

			Player playerOne = new Player(playerName);

			int[] modeGame = viewerGame.GetCorrectModeGame(playerOne);

			playerOne.SetNumber = modeGame;

			Player secondPlayer = new Player("Computer");

			Game gamer = new Game(playerOne, secondPlayer);

			GameSimulationCompVsHuman gameSimulation = new GameSimulationCompVsHuman(gamer, viewerGame);

			gameSimulation.StartGame();



		}
	}
}