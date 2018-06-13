using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
	public class Tank : IVehicle
	{
		//properties
		public string Type { get; }


		//constructor
		public Tank(string type)
		{
			Type = type;
		}


		//methods
		public double CalculateToll(int distance)
		{
			double toll = distance * 0.00;

			return toll;
		}
	}
}
