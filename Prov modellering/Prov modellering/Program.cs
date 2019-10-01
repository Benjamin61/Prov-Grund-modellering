using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_modellering
{
	class Program
	{
		static void Main(string[] args)
		{
			
			Console.WriteLine("Välkommen till bokaffären");
			Console.WriteLine("Var vänlig och fyll i ditt namn");
			Kund Kund = new Kund();
			Kund.Customername = Console.ReadLine();
			Kund.Welcome();
			Console.ReadKey();
			Books Info = new Books();
			Info.printInfo();

			Console.ReadKey();
			Books cursed = new Books();
			cursed.isCursed();
			Console.ReadKey();
		}
	}
}
