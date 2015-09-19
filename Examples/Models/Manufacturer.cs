using Examples.Interfaces;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Models
{
	public class Manufacturer
	{
		public int ID { get; set; }
		public String Name { get; set; }
		public VehicleType TypesOfVehicles { get; set; }
		public String Location { get; set; }

		public List<IVehicle> VehicleProduces { get; set; }
	}

	[JsonConverter(typeof(StringEnumConverter))]
	public enum VehicleType
	{
		Car,
		Plane,
		Boat
	}
}
