using System;

namespace FunnyGame.Interface
{
	public interface IGameBeginViewer
	{
		ConsoleKeyInfo GetChoicePlayer();
		void WelcomeMessage();

	}
}