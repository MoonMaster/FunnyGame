using FunnyGame.Model;
using NUnit.Framework;

namespace FunnyGameUnitTest.tests
{
	[TestFixture]
	class GamerTests
	{

		
		[Ignore("Not used this test")]
		public void Init()
		{
			
		}

	
		[TestCase("1")]
		public void GetLastNumberGamer(string number)
		{
			Player testGamer = new Player("tester");

			int numberTestCase = int.Parse(number);

			testGamer.ConceivedNumbersPlayer.Add(numberTestCase);

			int lastElement = testGamer.ConceivedNumbersPlayer[0];

			Assert.AreEqual(numberTestCase,lastElement);
			
		}
	}
}
