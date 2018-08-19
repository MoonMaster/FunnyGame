namespace FunnyGame.Interface
{
	public interface IUserValidation
	{
		bool IsValidateUserName(string userName);

		bool IsValidateChoiceModeGame(string choiceModeGame);
	}
}