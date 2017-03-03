namespace FunnyGame.Model
{
	public class Player
	{
		public string PlayerName { get; set; }
		public int[] SetNumber { get; set; }

		public Player(string playerName, int[] setNumber)
		{
			PlayerName = playerName;
			SetNumber = setNumber;
		}
		public Player(string playerName)
		{
			PlayerName = playerName;
		}
	}
}