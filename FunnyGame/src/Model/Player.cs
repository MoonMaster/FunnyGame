using System.Collections.Generic;

namespace FunnyGame.Model
{
	public class Player
	{
		public string PlayerName { get; set; }
		private int[] SetNumber
        {
            get;set;
           
        }
		public  List<int> ConceivedNumbersPlayer { get; set; } 

		public Player(string playerName, int[] setNumber)
		{
			PlayerName = playerName;
			this.SetNumber = setNumber;
			ConceivedNumbersPlayer = new List<int>();
		}

        public int[] GetSetNumber()
        {
            return this.SetNumber;
        }
	}
}