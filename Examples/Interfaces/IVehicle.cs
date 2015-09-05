using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Interfaces
{
	public interface IVehicle
	{
		public string Name { get; set; }

		public string Cost { get; set; }

		public int Passengers { get; set; }

		public string Manufacturer { get; set; }
	}
}
