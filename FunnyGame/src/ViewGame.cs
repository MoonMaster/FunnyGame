using System;

namespace FunnyGame
{
	public class ViewGame
	{
		private readonly string[] optionsGame =
		{
			"[o] - Odd",
			"[e] - Even"
		};

		public Person InitGameInformation()
		{
			string gamerName;
			bool gameModeGamer = false;
			bool stopChoice = false;

			Console.WriteLine("Welcome to Funny Game. What is your name?");
			gamerName = Console.ReadLine();

			while (true)
			{
				showArray(this.optionsGame);
				Console.WriteLine("Your Choice: ");
				var choiceGamer = Console.ReadKey();
				if (choiceGamer.Key == ConsoleKey.Escape)
				{
					break;
				}
				switch (choiceGamer.KeyChar)
				{
					case 'o':
						gameModeGamer = true;
						stopChoice = true;
						break;
					case 'e':
						gameModeGamer = false;
						stopChoice = true;
						break;
					default: 
						Console.Write("\n Error!");
						break;
				}

				if (stopChoice) 
					break;
			}
			var gamerPerson = new Person(gamerName,gameModeGamer);
			return gamerPerson;
		}

		private void showArray(string[] arrayStrings)
		{
			foreach (string itemOfArr in arrayStrings)
			{
				Console.WriteLine();
				Console.WriteLine(itemOfArr);
			}
		}
		
	}
}