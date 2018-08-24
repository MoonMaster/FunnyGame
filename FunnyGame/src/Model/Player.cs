using System.Collections.Generic;

namespace FunnyGame.Model
{
	public class Player
	{
		public string PlayerName { get; private set; }
		public int[] SetNumber { get; private set; }
		public  List<int> ConceivedNumbersPlayer { get; private set; } 

		public Player(string playerName, int[] setNumber)
		{
			PlayerName = playerName;
			SetNumber = setNumber;
			ConceivedNumbersPlayer = new List<int>();
		}
	}
}