﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TollBoothCalculator.Classes
{
	public interface IVehicle
	{
		//properties
		string Type { get; }


		//methods
		double CalculateToll(int distance);
	}
}
