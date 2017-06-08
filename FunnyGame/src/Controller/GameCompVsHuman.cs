﻿using System;
using FunnyGame.Helper;
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
			
			SimulationGame(gamer, viewerGame);
			
			

		}
		#region Private Region

		private void SimulationGame(Game gameUser, GameViewerSequenceGame viewerGame)
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