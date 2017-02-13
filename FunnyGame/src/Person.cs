namespace FunnyGame
{
	public class Person
	{
		private string personName { get; };
		private bool modeGame { get; };

		public Person(string personName, bool modeGame)
		{
			this.personName = personName;
			this.modeGame = modeGame;
		}


	}
}