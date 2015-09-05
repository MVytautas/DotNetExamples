using Examples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Models
{
	public partial class Vehicles : List<IVehicle>
	{
		//TODO: update planes and cars 'get' and 'set' to read and add from the base list
		public List<Plane> planes { get; set; }

		public List<Car> cars { get; set; }
	}

	public abstract class Vehicle : IVehicle
	{
		//TODO: add properties
	}

	public partial class Car
	{
		//TODO: make Car implement Vehicle
		public int Wheels { get; set; }

	}


	public partial class Plane
	{
		//TODO: make Plane implement Vehicle

		private int _engines;

		public int Engines
		{
			get
			{
				return _engines;
			}
			set
			{
				_engines = value;
			}
		}

	}






}
