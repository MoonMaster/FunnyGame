using System;

namespace FunnyGame.View
{
	public abstract class Presentor
	{
		protected string[] Options;
		public virtual void ShowMenu()
		{
			foreach (var itemOptions in Options)
			{
				Console.WriteLine(itemOptions);
			}
		}
	}
}