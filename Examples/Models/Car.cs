using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Models
{
	public partial class Vehicles
	{

		public List<Plane> planes { get; set; }

		public List<Car> cars { get; set; }
	}

	public partial class Car
	{

		public string Name { get; set; }


		public string Cost { get; set; }


		public int Passengers { get; set; }


		public int Wheels { get; set; }


		public string Manufacturer { get; set; }
	}


	public partial class Plane
	{

		private string _name;

		private string _cost;

		private int _passengers;

		private int _engines;

		private string _manufacturer;


		public string Name
		{
			get
			{
				return _name;
			}
			set
			{
				_name = value;
			}
		}


		public string Cost
		{
			get
			{
				return _cost;
			}
			set
			{
				_cost = value;
			}
		}


		public int Passengers
		{
			get
			{
				return _passengers;
			}
			set
			{
				_passengers = value;
			}
		}


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


		public string Manufacturer
		{
			get
			{
				return _manufacturer;
			}
			set
			{
				_manufacturer = value;
			}
		}
	}






}
