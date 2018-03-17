using System.Collections.Generic;

namespace FunnyGame.Model
{
	public class Player
	{
		/// <summary>
		/// Player name of user
		/// </summary>
		private string _playerName;
		/// <summary>
		/// How number choice player
		/// </summary>
		private bool _isOddestNumber;

		public string PlayerName
		{
			get
			{
				return _playerName;
			}
		}

		public bool IsOddestNumber
		{
			get
			{
				return _isOddestNumber;
			}
			set
			{
				this._isOddestNumber = value;
			}
		}

		public Player(string playerName)
		{
			_playerName = playerName;
		}

		
	}
}