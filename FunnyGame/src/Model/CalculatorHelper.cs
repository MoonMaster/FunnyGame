using System;
using FunnyGame.Interface;

namespace FunnyGame.Model
{
	public class CalculatorHelper : ICalculatorHelper
	{
		public int GetFirstDigitalNumberMultiply(int firstNumber, int secondNumber)
		{
			int resultMultiply = MultiplyNumber(firstNumber, secondNumber);

			while (resultMultiply >= 10)
			{
				resultMultiply /= 10;
			}

			return resultMultiply;
		}

		private int MultiplyNumber(int firstNumber, int secondNumber)
		{
			if (firstNumber <0 || secondNumber < 0)
				throw new ArgumentException("Один из аргументов отрицательный. Проверьте вводимые значения");

			var minValue = Math.Min(firstNumber, secondNumber);

			var maxValue = Math.Max(firstNumber, secondNumber);

			if (minValue == 0 || maxValue == 0)
			{
				return 0;
			}
			else if (minValue == 1)
			{
				return maxValue;
			}

			int s = minValue >> 1;

			int halfProduct = MultiplyNumber(s, maxValue);

			if (minValue % 2 == 0)
				return halfProduct + halfProduct;

			return halfProduct + halfProduct + maxValue;
		}
	}
}