using System.Windows;
using FunnyGame.Controller;
using FunnyGameWPF.Controls;

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

		private void Start_Click(object sender, RoutedEventArgs e)
		{
			GameEmulation gameEmulation = new GameEmulation();
			if (ModeGame.IsChecked == true)
			{
				gameEmulation.Execute(new SettingGame());
				Hide();
			}
			else
			{
				MessageBox.Show("Неверное значение", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
			}
		}
		
		private void ExitGame_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}
