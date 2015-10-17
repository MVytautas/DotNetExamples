using Examples.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Models
{
    //public partial class Vehicles : List<IVehicle>
    //{
    //    //TODO: update planes and cars 'get' and 'set' to read and add from the base list
    //    public List<Plane> planes { get; set; }

    //    public List<Car> cars { get; set; }
    //}

	public partial class Vehicles : List<IVehicle>
	{
		//TODO: update planes and cars 'get' and 'set' to read and add from the base list
		public List<Plane> planes
		{
			get
			{
				return this.Where(v => v is Plane).Select(v => (Plane)v).ToList();
			}
		}

		public List<Car> cars
		{
			get
			{
				return this.Where(v => v is Car).Select(v => (Car)v).ToList();
			}
		}
	}

	public abstract class Vehicle : IVehicle
	{
		//TODO: add properties // DONE
		public string Name { get; set; }
		public String Cost { get; set; } // Another class do not let me to change to int type
		// public String Manufacturer { get; set; }
		public Int32 ManufacturerID { get; set; }
		public Int32 Passengers { get; set; }
		public Int32 Weight { get; set; }
		public String Color { get; set; }

		public abstract void Move(string location);



		public Manufacturer Manufacturer { get; set; }
	}



	public class Car : Vehicle
	{
		//TODO: make Car implement Vehicle


		public int Wheels { get; set; }

		public override void Move(string location)
		{
			// ride
		}

	}


	public class Plane : Vehicle
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

		public override void Move(string location)
		{
			// fly
		}

	}
	// LIST of vehicles
	public class Honda : Car
	{
		public override void Move(string location)
		{
			base.Move(location);
		}
	}

	public class Boeing : Plane
	{
		public override void Move(string location)
		{
			base.Move(location);
		}
	}




}
