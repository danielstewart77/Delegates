using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	public class Program
	{
		static void Main(string[] args)
		{
			PlayerModel p1 = new PlayerModel();
			p1.Name = "Daniel";
			//p1.Print(PrintPlayerName, p1);
			//p1.Print(PrintPlayerNameId, p1);

			p1.PrintName();
			p1.PrintId();
			p1.PrintNameAndId();

			Console.ReadKey();
		}

		private static void PrintPlayerName(PlayerModel pl)
		{
			Console.WriteLine($"player name is: {pl.Name}");
		}

		private static void PrintPlayerNameId(PlayerModel pl)
		{
			Console.WriteLine($"player name is: {pl.Name}");
			Console.WriteLine($"player id is: {pl.Id}");
		}
	}
}
