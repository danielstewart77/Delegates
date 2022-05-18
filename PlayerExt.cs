using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	/// <summary>
	/// Extends the PlayerModel Class with some print methods
	/// </summary>
	public static class PlayerExt
	{
		public static void PrintName(this PlayerModel pl)
		{

			Console.WriteLine($"Ext - Player name: {pl.Name}");
		}
		public static void PrintId(this PlayerModel pl)
		{
			Console.WriteLine($"Ext - Player name: {pl.Id}");
		}
		public static void PrintNameAndId(this PlayerModel pl)
		{
			Console.WriteLine($"Ext - Player name: {pl.Name} Player id: {pl.Id}"); ;
		}
	}
}
