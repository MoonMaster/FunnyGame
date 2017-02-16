using System;
using System.Linq;

namespace FunnyGame
{
	public class ViewGame
	{
		private readonly string[] optionsGame =
		{
			"[o] - first part {1,2,3}",
			"[e] - second part {4,5,6,7,8,9}"
		};

		public Person InitGameInformation()
		{
			bool isOddGamerChoice = false;
			bool stopChoice = false;

			Console.WriteLine("Welcome to Funny Game. What is your name?");
			string gamerName = Console.ReadLine();

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
						isOddGamerChoice = true;
						stopChoice = true;
						break;
					case 'e':
						isOddGamerChoice = false;
						stopChoice = true;
						break;
					default: 
						Console.Write("\n Error!");
						break;
				}

				if (stopChoice) 
					break;
			}
			var gamerPerson = new Person(gamerName, isOddGamerChoice);
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


		public void playFunnyGame(Person gamerPerson, int counter)
		{
			Random rnd = new Random();
			int count = 0;
			while (count < counter)
			{
				Console.WriteLine(gamerPerson.PersonName + " Input your number: ");
				int numberGame = Convert.ToInt16(Console.ReadLine());
				Console.Write("Computer is number ");
				int numberComp = rnd.Next(0, 100);
				Console.WriteLine(numberComp);
				int multipleRes = numberGame*numberComp;
				Console.WriteLine("Multiply " + multipleRes);
				int firstDigits = checkFirstDigital(multipleRes);
				if (firstDigits == 0)
				{
					Console.WriteLine("Continuo game. DRAW");
				}
				else if (Enumerable.Range(1, 3).Contains(firstDigits) && gamerPerson.ModeGame)
				{
					Console.WriteLine("The gamer " + gamerPerson.PersonName.ToUpper() + " is WIN");
				}
				else
				{
					Console.WriteLine("The Computer is Win");
				}
				count++;
			}
			Console.ReadKey();
		}

		private int checkFirstDigital(int numbr)
		{
			int result = Math.Abs(numbr);
			while (result >= 10)
			{
				result /= 10;
			}
			return result;
		}
	}
}