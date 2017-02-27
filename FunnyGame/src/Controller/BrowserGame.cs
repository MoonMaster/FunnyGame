using System;
using FunnyGame.Interface;

namespace FunnyGame.Controller
{
	public class BrowserGame
	{
		public void Execute(IGameMode gameMode)
		{
			Console.Clear();
			gameMode.Play();
		}
	}
}