using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_modellering
{
	class Kund
	{
		public string Customername;
		public int Money;


		public void Welcome()
		{
			Console.WriteLine("Hej och välkommen till affären " + Customername);
		}
	}
}
