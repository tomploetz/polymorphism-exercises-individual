using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	public class SPUNextD : IDeliveryDriver
	{
		//properties
		public string Name { get; } = "SPU (Next-Day)";


		//methods
		public double CalculateRate(int distance, double weight)
		{
			double lbs = weight / 16;
			return (lbs * 0.075) * distance;
		}
	}
}
