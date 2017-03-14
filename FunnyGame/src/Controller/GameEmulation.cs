using System;
using FunnyGame.Interface;

namespace FunnyGame.Controller
{
	public class GameEmulation
	{
		public void Execute(IGameMode gameMode)
		{
			Console.Clear();
			gameMode.Play();
		}
	}
}