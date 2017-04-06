using System.Windows;
using FunnyGame.Interface;

namespace FunnyGameWPF.Controller
{
	public class GameStart : Window, IGameMode
	{
		public void Play()
		{
			MessageBox.Show("Test", "Test", MessageBoxButton.OK, MessageBoxImage.Information);
		}
	}
}