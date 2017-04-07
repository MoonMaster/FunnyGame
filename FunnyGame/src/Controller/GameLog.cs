using NLog;

namespace FunnyGame.Controller
{
	public class GameLog
	{
		private static Logger logger = LogManager.GetLogger("FunnyGame");

		public static void WriteMessage(string message, string type = "info")
		{
			switch (type.ToUpper())
			{
				case "INFO":
					logger.Info(message);
					break;
				case "DEBUG":
					logger.Debug(message);
					break;
				case "ERROR":
					logger.Error(message);
					break;
				default:
					logger.Warn(message);
					break;
			}
		}
	}
}