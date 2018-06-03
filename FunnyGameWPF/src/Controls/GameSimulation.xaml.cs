using System;
using System.Linq;
using System.Text;
using System.Windows;
using FunnyGame.Model;

namespace FunnyGameWPF.Controls
{
	/// <summary>
	/// Interaction logic for GameSimulation.xaml
	/// </summary>
	public partial class GameSimulation : Window
	{
		public Game Gamer { get; private set; }
		private static Random rnd = new Random();
		public GameSimulation(Game game)
		{
			InitializeComponent();
			InputName.DataContext = game;
			Show();
			Gamer = game;
			//InputName.DataContext = game;
			/*string str = InputName.Content.ToString();
			StringBuilder strBuilder = new StringBuilder(str);
			strBuilder.Append(" ");
			strBuilder.Append(Gamer.FirstPlayer.PlayerName);
			InputName.Content = strBuilder.ToString();*/
		}

		private void Run_Click(object sender, RoutedEventArgs e)
		{
			//int playerNumber = Convert.ToInt32(InputNumber.Text);
			//int oppontNumber = rnd.Next(0, 100);
			//ComputerNumb.Content = oppontNumber;

			//int multiplyResult = GameCheckedHelper.MultiplyNumber(playerNumber, oppontNumber);

			//if (multiplyResult == 0)
			//{
			//	MessageBox.Show("Draw", "Result Game", MessageBoxButton.OK, MessageBoxImage.Information);
			//}
			//else if (Gamer.FirstPlayer.SetNumber.Contains(multiplyResult))
			//{
			//	StringBuilder str = new StringBuilder("The Gamer ");
			//	str.Append(Gamer.FirstPlayer.PlayerName);
			//	str.Append(" is Win");
			//	MessageBox.Show(str.ToString(), "Result Game", MessageBoxButton.OK, MessageBoxImage.Information);
			//}
			//else
			//{
			//	StringBuilder str = new StringBuilder("The Gamer ");
			//	str.Append(Gamer.SecondPlayer.PlayerName);
			//	str.Append(" is Win");
			//	MessageBox.Show(str.ToString(), "Result Game", MessageBoxButton.OK, MessageBoxImage.Information);
			//}

			//InputNumber.Text = string.Empty;
			//ComputerNumb.Content = string.Empty;
		}
	}
}
