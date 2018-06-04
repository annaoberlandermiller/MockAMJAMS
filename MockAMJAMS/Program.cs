using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAMJAMS
{
	class Program
	{
		static void Main(string[] args)
		{
			Accused BoweBergdahl = new Accused();
			BoweBergdahl.Name = "Bowe Bergdahl";
			BoweBergdahl.Social = "123-456-7890";
			BoweBergdahl.Rank = "Sergeant";
			BoweBergdahl.Base = "Fort Richardson";

			Console.Write("Name:  {0}  Rank:  {1}  SSN:  {2}  Base:  {3}", BoweBergdahl.Name, BoweBergdahl.Rank, BoweBergdahl.Social, BoweBergdahl.Base);
		}
	}
}



