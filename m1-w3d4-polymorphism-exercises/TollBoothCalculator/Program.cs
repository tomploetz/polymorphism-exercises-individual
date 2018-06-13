using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TollBoothCalculator.Classes;

namespace TollBoothCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
			Random rnd = new Random();
			List<IVehicle> vehicles = new List<IVehicle>();
			Tank tom = new Tank("Tank");
			Car car1 = new Car(true, "Car");
			Car car2 = new Car(false, "Car");
			Truck truck1 = new Truck(6, "Truck");
			Truck truck2 = new Truck(4, "Truck");
			Truck truck3 = new Truck(8, "Truck");

			int totalDistance = 0;
			int totalTolls = 0;

			vehicles.Add(tom);
			vehicles.Add(car1);
			vehicles.Add(car2);
			vehicles.Add(truck1);
			vehicles.Add(truck2);
			vehicles.Add(truck3);

			Console.WriteLine("\n{0, -30}{1, -30}", "Vehicle", "Distance Traveled", "Toll $");
			foreach(var vehicle in vehicles)
			{
				int distance = rnd.Next(10, 240);
				totalDistance += distance;
				Console.WriteLine("{0, -30}{1, -30}", vehicle.Type, distance, vehicle.CalculateToll(distance).ToString("c"));
				totalTolls += (int)vehicle.CalculateToll(distance);
			}

			Console.WriteLine();
			Console.WriteLine("Total distance: " + totalDistance);
			Console.WriteLine("Total toll revenue: " + totalTolls.ToString("c"));

			Console.ReadKey();
        }
    }
}
