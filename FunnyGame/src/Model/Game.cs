namespace FunnyGame.Model
{
	public class Game
	{
		public Player FirstPlayer { get; set; }
		public Player SecondPlayer { get; set; }

		public Game(Player firstPlayer, Player secondPlayer)
		{
			FirstPlayer = firstPlayer;
			SecondPlayer = secondPlayer;
		}
	}
}