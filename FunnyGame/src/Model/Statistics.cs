using System;
using System.Collections.Generic;
using System.Linq;

namespace FunnyGame.Model
{
	public class Statistics
	{
		public static List<string> Stat = new List<string>();
		/* O_Mode = {1,2,3}
		 * E_mode = {4,5,6,7,8,9}
		 * DRAW = {0}
		*/
		public void SetStatistics(int mode)
		{
			if (mode == 0)
			{
				Stat.Add("DRAW");
			}
			if (mode >= 1 && mode <= 3)
			{
				Stat.Add("O_Mode");
			}
			else
			{
				Stat.Add("E_Mode");
			}
		}

		public void PrintStatistics()
		{
			var countItem = Stat.Count() *1.0;
			double countEmode = Stat.Count(item => item == "E_Mode") * 1.0;
			double countOmode = Stat.Count(item => item == "O_Mode")*1.0;

			Console.WriteLine("Probability E Mode = {0}", countEmode/countItem);
			Console.WriteLine("Probability O Mode = {0}", countOmode/countItem);
			Console.WriteLine("Count Round = {0}", (int)countItem);
		}
	}
}