using System.Windows;
using FunnyGame.Helper;
using FunnyGame.Interface;
using FunnyGame.Model;

namespace FunnyGameWPF.Controls
{
	/// <summary>
	/// Interaction logic for NameForm.xaml
	/// </summary>
	public partial class SettingGame : Window, IGameMode
	{
		
		public SettingGame()
		{
			InitializeComponent();
		}

		public void Play()
		{
			this.Show();
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Close();
			
		}

		private void StartGame_Click(object sender, RoutedEventArgs e)
		{
			var userName = InputUserName.Text;
			if (!GameCheckedHelper.IsValidUserName(userName))
			{
				MessageBox.Show("Неверное значение", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
				InputUserName.Text = string.Empty;
			}
			Player playerOne = new Player(userName, OmodeGame.IsChecked == true ? new int[] {1, 2, 3} : new[] {4, 5, 6, 7, 8, 9});
			Player playerTwo = new Player("Computer",new[] { 1, 2, 3 });

			Game gameSimulation = new Game(playerOne, playerTwo);

			GameSimulation simulation = new GameSimulation(gameSimulation);
		}
	}
}
