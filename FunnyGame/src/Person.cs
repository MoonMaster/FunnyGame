namespace FunnyGame
{
	public class Person
	{
		private string PersonName { get; set; }
		private bool ModeGame { get; set;}

		public Person(string personName, bool modeGame)
		{
			this.PersonName = personName;
			this.ModeGame = modeGame;
		}
	}
}