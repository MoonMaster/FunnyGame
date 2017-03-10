using System.Collections.Generic;
using System.Runtime.Serialization;

namespace FunnyGame.Model
{
	public class Player
	{
		public string PlayerName { get; set; }
		public int[] SetNumber { get; set; }
		public  List<int> ConceivedNumbersPlayer { get; set; } 

		public Player(string playerName, int[] setNumber)
		{
			PlayerName = playerName;
			SetNumber = setNumber;
			ConceivedNumbersPlayer = new List<int>();
		}
		public Player(string playerName)
		{
			PlayerName = playerName;
			ConceivedNumbersPlayer = new List<int>();
		}
	}
}