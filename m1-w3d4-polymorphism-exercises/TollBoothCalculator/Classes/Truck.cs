using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
	public class Truck : IVehicle
	{
		//properties
		public int NumberOfAxles { get; }
		public string Type { get; }
		

		//constructor
		public Truck(int numberOfAxles, string type)
		{
			NumberOfAxles = numberOfAxles;
			Type = type;
		}


		//methods
		public double CalculateToll(int distance)
		{
			double toll = 0.00;

			if(NumberOfAxles == 4)
			{
				toll = distance * 0.040;
			}
			else if(NumberOfAxles == 6)
			{
				toll = distance * 0.045;
			}
			else if(NumberOfAxles >= 8)
			{
				toll = distance * 0.048;
			}

			return toll;
		}
	}
}
