using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostageCalculator.Classes;

namespace PostageCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.Write("Please enter the weight of the package: ");
			double weight = Double.Parse(Console.ReadLine());

			Console.Write("(P)ounds or (O)unces? ");
			string unit = Console.ReadLine().ToLower();
			if(unit == "p")
			{
				weight *= 16;
			}

			Console.Write("What distance will it be traveling? ");
			int distance = Int32.Parse(Console.ReadLine());

			List<IDeliveryDriver> rates = new List<IDeliveryDriver>();
			FirstClass firstClass = new FirstClass();
			SecondClass secondClass = new SecondClass();
			ThirdClass thirdClass = new ThirdClass();
			FedEx fedEx = new FedEx();
			SPUFourD fourD = new SPUFourD();
			SPUTwoD twoD = new SPUTwoD();
			SPUNextD nextD = new SPUNextD();

			rates.Add(firstClass);
			rates.Add(secondClass);
			rates.Add(thirdClass);
			rates.Add(fedEx);
			rates.Add(fourD);
			rates.Add(twoD);
			rates.Add(nextD);

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("\n{0, -30}{1, -30}", "Delivery Method", "$ cost");
			Console.WriteLine("-------------------------------------");

			foreach(var rate in rates)
			{
				Console.WriteLine("{0, -30}{1, -30}", rate.Name, rate.CalculateRate(distance, weight).ToString("c"));
			}
			
			Console.ReadKey();
        }
    }
}
