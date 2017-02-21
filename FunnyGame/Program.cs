using NLog;

namespace FunnyGame
{
	class Program
	{
		private static readonly Logger logger = LogManager.GetCurrentClassLogger();
		static void Main(string[] args)
		{
			logger.Info("The Game started");
			GameController game = new GameController();
			game.Run();
			logger.Info("The Game end");
		}
	}
}
