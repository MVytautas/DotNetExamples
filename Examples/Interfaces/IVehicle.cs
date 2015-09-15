using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Interfaces
{
	public interface IVehicle
	{
		string Name { get; set; }

		string Cost { get; set; }

		int Passengers { get; set; }

		int ManufacturerID { get; set; }
		Manufacturer Manufacturer { get; set; }
	}
}
