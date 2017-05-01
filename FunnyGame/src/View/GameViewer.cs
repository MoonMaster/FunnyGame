using System;
using System.Linq;

namespace FunnyGame.View
{
	public abstract class GameViewer
	{
		protected string[] Options;
		public virtual void ShowMenu()
		{
			Options.ToList().ForEach(Console.WriteLine);
		}

		public virtual void ShowMessage(string message)
		{
			Console.WriteLine(message);
		}
	}
}