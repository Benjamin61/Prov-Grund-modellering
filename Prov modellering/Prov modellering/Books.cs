using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_modellering
{
	 public class Books
	{
		public int Generator;
		public string findOut;
		public int price;
		public string[] bookname = { "Berts äventyr", "Skräckens skräck", "Julio och romeiett" };

		public string[] rarity = {"Common", "Rare", "Legendary" };
		public string[] category = { "KidBook", "ScaryStuff", "Romance" };
		bool cursed = false;

		public void generator()
		{
			Random generator = new Random();
			  int Generator = generator.Next(4);
		}
		public void printInfo()
		{
			
			string bookanswer = bookname[Generator];
			string rarityanswer = rarity[Generator];
			string categoryanswer = category[Generator];

			Console.WriteLine("En bok som skulle rekomenderas till dig är:");
			Console.WriteLine(bookanswer);
			Console.WriteLine("Det är en " + categoryanswer);
			Console.WriteLine("Och dess rarity är: " + rarityanswer);
			Console.WriteLine("Klicka enter för att komma vidare");
		}

		public void isCursed()
		{
			Random generator = new Random();
			Console.WriteLine("Det finns en 1 på 5 chans att det bok är cursed. Efter denna text kommer det visa sig om boken är cursed eller ej");
			int CursedGenerator = generator.Next(1, 6);
			if (CursedGenerator == 1)
			{
				Console.WriteLine("Din bok är Cursed!!");
			}
			else
			{
				Console.WriteLine("Din bok är inte Cursed!!!");
			}

			
		}
		/*public void PrintInfo()
		{
			
			while (i < -1)
			{
				string bookanswer = bookname[generator];
				Console.WriteLine("Bokens namn är" +bookanswer );
				i++;
			}
			Console.WriteLine();
		}*/

	}
}
