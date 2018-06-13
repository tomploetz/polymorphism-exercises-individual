using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PostageCalculator.Classes;

namespace Exercises.Tests
{
	[TestClass]
	public class PostageCalculatorTests
	{
		[TestMethod]
		public void CalculateRate()
		{
			FirstClass _firstClass = new FirstClass();
			SecondClass _secondClass = new SecondClass();
			ThirdClass _thirdClass = new ThirdClass();
			FedEx _fedEx = new FedEx();
			SPUFourD _fourD = new SPUFourD();
			SPUTwoD _twoD = new SPUTwoD();
			SPUNextD _nextD = new SPUNextD();

			//first class
			Assert.AreEqual(0.035, _firstClass.CalculateRate(1, 1), "Input: _firstClass.CalculateRate(1, 1)");
			Assert.AreEqual(0.040, _firstClass.CalculateRate(1, 3), "Input: _firstClass.CalculateRate(1, 3)");
			Assert.AreEqual(0.047, _firstClass.CalculateRate(1, 9), "Input: _firstClass.CalculateRate(1, 9)");
			Assert.AreEqual(0.195, _firstClass.CalculateRate(1, 16), "Input: _firstClass.CalculateRate(1, 1)");
			Assert.AreEqual(0.450, _firstClass.CalculateRate(1, 64), "Input: _firstClass.CalculateRate(1, 1)");
			Assert.AreEqual(0.500, _firstClass.CalculateRate(1, 144), "Input: _firstClass.CalculateRate(1, 1)");

			//second class
			Assert.AreEqual(0.0035, _secondClass.CalculateRate(1, 1), "Input: _secondClass.CalculateRate(1, 1)");
			Assert.AreEqual(0.0040, _secondClass.CalculateRate(1, 3), "Input: _secondClass.CalculateRate(1, 3)");
			Assert.AreEqual(0.0047, _secondClass.CalculateRate(1, 9), "Input: _secondClass.CalculateRate(1, 9)");
			Assert.AreEqual(0.0195, _secondClass.CalculateRate(1, 16), "Input: _secondClass.CalculateRate(1, 16)");
			Assert.AreEqual(0.0450, _secondClass.CalculateRate(1, 64), "Input: _secondClass.CalculateRate(1, 64)");
			Assert.AreEqual(0.0500, _secondClass.CalculateRate(1, 144), "Input: _secondClass.CalculateRate(1, 144)");

			//third class
			Assert.AreEqual(0.0020, _thirdClass.CalculateRate(1, 1), "Input: _thirdClass.CalculateRate(1, 1)");
			Assert.AreEqual(0.0022, _thirdClass.CalculateRate(1, 3), "Input: _thirdClass.CalculateRate(1, 3)");
			Assert.AreEqual(0.0024, _thirdClass.CalculateRate(1, 9), "Input: _thirdClass.CalculateRate(1, 9)");
			Assert.AreEqual(0.0150, _thirdClass.CalculateRate(1, 16), "Input: _thirdClass.CalculateRate(1, 16)");
			Assert.AreEqual(0.0160, _thirdClass.CalculateRate(1, 64), "Input: _thirdClass.CalculateRate(1, 64)");
			Assert.AreEqual(0.0170, _thirdClass.CalculateRate(1, 144), "Input: _thirdClass.CalculateRate(1, 144)");

			//fedex
			Assert.AreEqual(20.00, _fedEx.CalculateRate(1, 16), "Input: _fedEx.CalculateRate(1, 16)");
			Assert.AreEqual(23.00, _fedEx.CalculateRate(1, 64), "Input: _fedEx.CalculateRate(1, 64)");
			Assert.AreEqual(25.00, _fedEx.CalculateRate(501, 16), "Input: _fedEx.CalculateRate(501, 16)");
			Assert.AreEqual(28.00, _fedEx.CalculateRate(505, 50), "Input: _fedEx.CalculateRate(505, 50)");
			

			//spu four day
			Assert.AreEqual("$0.02", _fourD.CalculateRate(10, 5).ToString("c"), "Input: _fourD.CalculateRate(10, 5)");
			Assert.AreEqual(.25, _fourD.CalculateRate(10, 80), "Input: _fourD.CalculateRate(10, 80)");

			//spu two day
			Assert.AreEqual("$0.16", _twoD.CalculateRate(10, 5).ToString("c"), "Input: _twoD.CalculateRate(10, 5)");
			Assert.AreEqual(2.50, _twoD.CalculateRate(10, 80), "Input: _twoD.CalculateRate(10, 80)");

			//spu next day
			Assert.AreEqual("$0.23", _nextD.CalculateRate(10, 5).ToString("c"), "Input: _nextD.CalculateRate(10, 5)");
			Assert.AreEqual(3.75, _nextD.CalculateRate(10, 80), "Input: _nextD.CalculateRate(10, 80)");
		}
	}
}
