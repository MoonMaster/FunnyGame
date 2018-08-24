namespace FunnyGame.Model
{
	public class Game
	{
		public Player FirstPlayer { get; private set; }
		public Player SecondPlayer { get; private set; }

		public Game(Player firstPlayer, Player secondPlayer)
		{
			FirstPlayer = firstPlayer;
			SecondPlayer = secondPlayer;
		}
	}
}