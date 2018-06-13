using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	public class FirstClass : IDeliveryDriver
	{
		//properties
		public string Name { get; } = "Postal Service (1st Class)";


		//methods
		public double CalculateRate(int distance, double weight)
		{
			double rate = 0.0;

			if(weight >= 0 && weight <= 2)
			{
				rate = distance * 0.035;
			}
			else if(weight >= 3 && weight <= 8)
			{
				rate = distance * 0.040;
			}
			else if(weight >= 9 && weight <= 15)
			{
				rate = distance * 0.047;
			}
			else if(weight >= 16 && weight <= 63) // 48
			{
				rate = distance * 0.195;
			}
			else if(weight >= 64 && weight <= 143) // 128
			{
				rate = distance * 0.450;
			}
			else if(weight >= 144)
			{
				rate = distance * 0.500;
			}


			return rate;
		}
	}
}
