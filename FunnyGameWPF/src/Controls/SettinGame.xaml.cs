using System.Windows;
using FunnyGame.Helper;
using FunnyGame.Interface;

namespace FunnyGameWPF.Controls
{
	/// <summary>
	/// Interaction logic for NameForm.xaml
	/// </summary>
	public partial class SettingGame : Window, IGameMode
	{
		public string UserNameGame { get; set; }
		public int[] ModeGame { get; set; }

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
			UserNameGame = InputUserName.Text;
			if (!GameCheckedHelper.IsValidUserName(UserNameGame))
			{
				MessageBox.Show("Неверное значение", "Error", MessageBoxButton.OK, MessageBoxImage.Information);
				InputUserName.Text = string.Empty;
			}
			ModeGame = OmodeGame.IsChecked == true ? new int[] {1,2,3} : new int[] {4,5,6,7,8,9};

		}
	}
}
