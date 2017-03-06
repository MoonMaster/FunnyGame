using System;
using System.Collections.Generic;
using System.Linq;

namespace FunnyGame.Model
{
	public class Statistics
	{
		public static List<int> winsEMode = new List<int>();
		public static List<int> winsOMode = new List<int>();

		public void SetStatistics(int mode)
		{
			if (mode >= 1 && mode <= 3)
			{
				winsOMode.Add(1);
				winsEMode.Add(0);
			}
			if (mode >= 4 && mode <= 9)
			{
				winsOMode.Add(0);
				winsEMode.Add(1);
			}
			else
			{
				winsOMode.Add(0);
				winsEMode.Add(0);
			}
		}

		public void PrintStatistics()
		{
			var countRoundGame = winsOMode.Count * 1.0;

			double countEMode = (winsEMode.Sum() * 1.0) / countRoundGame;

			double countOMode = (winsOMode.Sum() * 1.0) / countRoundGame;

			Console.WriteLine("The Probably EMode {0} \t The Probably OMode {1}. Total Round: {2}", countEMode, countOMode, countRoundGame);

		}
	}
}