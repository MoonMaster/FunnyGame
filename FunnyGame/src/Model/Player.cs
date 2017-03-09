using System.Runtime.Serialization;

namespace FunnyGame.Model
{
	[DataContract]
	public class Player
	{
		[DataMember]
		public string PlayerName { get; set; }
		[DataMember]
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