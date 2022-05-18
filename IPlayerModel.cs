using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	internal interface IPlayerModel
	{
		Guid Id { get; }
		string Name { get; set; }
	}
}
