using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TollBoothCalculator.Classes;

namespace Exercises.Tests
{
	[TestClass]
	public class TollBoothTests
	{
		[TestMethod]
		public void CalculateToll()
		{
			Tank tom = new Tank("Tank");
			Car car1 = new Car(true, "Car");
			Car car2 = new Car(false, "Car");
			Truck truck1 = new Truck(6, "Truck");
			Truck truck2 = new Truck(4, "Truck");
			Truck truck3 = new Truck(8, "Truck");

			Assert.AreEqual(0, tom.CalculateToll(300));
			Assert.AreEqual(5.68, car1.CalculateToll(234));
			Assert.AreEqual(2.94, car2.CalculateToll(147));
			Assert.AreEqual(5.895, truck1.CalculateToll(131));
			Assert.AreEqual(6.88, truck2.CalculateToll(172));
			Assert.AreEqual(6.048, truck3.CalculateToll(126));
		}
	}
}
