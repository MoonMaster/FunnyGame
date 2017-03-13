using NLog;

namespace FunnyGame.Controller
{
	public class GameLog
	{
		private static Logger logger = LogManager.GetLogger("FunnyGame");

		public static void WriteMessage(string message, string type = "info")
		{
			switch (type)
			{
				case "info":
					logger.Info(message);
					break;
				case "debug":
					logger.Debug(message);
					break;
				case "error":
					logger.Error(message);
					break;
				default:
					logger.Warn(message);
					break;
			}
		}
	}
}