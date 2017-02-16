using NLog;

namespace FunnyGame
{
	class Program
	{
		private static Logger logger = LogManager.GetCurrentClassLogger();
		static void Main(string[] args)
		{
			logger.Info("The Game is start");
			GameController game = new GameController();
			game.Run();
			logger.Info("The Game is end");
		}
	}
}
