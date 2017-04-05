﻿using FunnyGame.Helper;
using NUnit.Framework;

namespace FunnyGameUnitTest.tests
{
	[TestFixture]
	public class GameCheckedTests
	{
		[TestCase("Abc")]
		[TestCase("Test")]
		public void CheckedValidUserName(string userName)
		{
			var result = GameCheckedHelper.IsValidUserName(userName);
			Assert.IsTrue(result);
		}
		[TestCase("TEst")]
		[TestCase("Abc1")]
		[TestCase("12Abc12")]
		[TestCase("ABc")]
		public void CheckUnValiedUserName(string userName)
		{
			var result = GameCheckedHelper.IsValidUserName(userName);
			Assert.IsFalse(result);
		}
		[TestCase("e")]
		[TestCase("o")]
		public void CheckedValidModeGame(string modeGame)
		{
			var result = GameCheckedHelper.IsValidInputModeGame(modeGame);
			Assert.IsTrue(result);
		}
	}
}