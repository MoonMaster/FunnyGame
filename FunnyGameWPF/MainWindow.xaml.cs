using System.Windows;
using FunnyGame.Controller;
using FunnyGame.Helper;
using FunnyGame.Model;
using FunnyGameWPF.Controller;

namespace FunnyGameWPF
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void StartGame_Click(object sender, RoutedEventArgs e)
		{
			var valueInputName = InputUserName.Text;
			
			if (!GameCheckedHelper.IsValidUserName(valueInputName))
			{
				MessageBox.Show("Некорректное имя", "Ошибка при вводе имени", MessageBoxButton.OK, MessageBoxImage.Error);
				InputUserName.Text = string.Empty;
			}
			var modeGame = OModeGame.IsChecked == true ? 0 : 1;

			Player firstPlayer = new Player(valueInputName, modeGame == 0 ? new[] { 1, 2, 3 } : new[] { 4, 5, 6, 7, 8, 9 });
			Player secondPlayer = new Player("Computer");

			Game gameSimulation = new Game(firstPlayer,secondPlayer);
			GameEmulation gameEmulation = new GameEmulation();

			
		}

	}
}
