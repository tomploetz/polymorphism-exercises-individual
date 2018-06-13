using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	public class SecondClass : IDeliveryDriver
	{
		//properties
		public string Name { get; } = "Postal Service (2nd Class)";


		//methods
		public double CalculateRate(int distance, double weight)
		{
			double rate = 0.0;

			if (weight >= 0 && weight <= 2)
			{
				rate = distance * 0.0035;
			}
			else if (weight >= 3 && weight <= 8)
			{
				rate = distance * 0.0040;
			}
			else if (weight >= 9 && weight <= 15)
			{
				rate = distance * 0.0047;
			}
			else if (weight >= 16 && weight <= 63) // 48
			{
				rate = distance * 0.0195;
			}
			else if (weight >= 64 && weight <= 143) // 128
			{
				rate = distance * 0.0450;
			}
			else if (weight >= 144)
			{
				rate = distance * 0.0500;
			}


			return rate;
		}
	}
}
