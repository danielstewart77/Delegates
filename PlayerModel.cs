using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	public class PlayerModel : IPlayerModel
	{
		private readonly Guid _id = Guid.NewGuid();
		public Guid Id { get { return _id; } }
		public string Name { get; set; }

		public delegate void PrintPlayerInfo(PlayerModel p);
		public PlayerModel() { }

		public PlayerModel(string name)
		{
			Name = name;
		}

		/// <summary>
		/// Accepts a print method and a PlayerModel to be printed
		/// </summary>
		/// <param name="printPlayer"></param>
		/// <param name="player"></param>
		public void Print(PrintPlayerInfo printPlayer, PlayerModel player) 
		{
			printPlayer(player);
		}

		
	}
}
