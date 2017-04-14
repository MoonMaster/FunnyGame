using System.Windows;
using FunnyGame.Interface;

namespace FunnyGameWPF.ViewModels
{
	/// <summary>
	/// Interaction logic for NameForm.xaml
	/// </summary>
	public partial class NameForm : Window, IGameMode
	{
		public NameForm()
		{
			InitializeComponent();
		}

		public void Play()
		{
			
		}
	}
}
