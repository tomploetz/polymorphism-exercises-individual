using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostageCalculator.Classes
{
	public class SPUFourD : IDeliveryDriver
	{
		//properties
		public string Name { get; } = "SPU (4-Day Ground)";


		//methods
		public double CalculateRate(int distance, double weight)
		{
			double lbs = weight / 16;
			return (lbs * 0.0050) * distance;
		}
	}
}
