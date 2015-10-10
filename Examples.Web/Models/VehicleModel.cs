using Examples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Examples.Web.Models
{
	public class VehicleModel
	{
		public VehicleModel()
		{

		}

		public VehicleModel(IVehicle vehicle)
		{
			Name = vehicle.Name;
			Cost = vehicle.Cost;
		}
		
		public String Name { get; set; }
		public String Cost { get; set; }
		public String Type { get; set; }
	}
}