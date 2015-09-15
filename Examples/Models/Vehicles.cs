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
		//TODO: add properties // DONE
	    public String Cost { get; set; }
	    public String Manufacturer { get; set; }
	    public Int32 Passengers { get; set; }
	    public Int32 Weight { get; set; }
	    public String Color { get; set; }

	    public abstract void Ride(string location);

	    public abstract void Fly(string location);
	}

	public partial class Car : Vehicle
	{
		//TODO: make Car implement Vehicle
		public int Wheels { get; set; }

	    public override void Ride(string location)
	    {
	        // ride
	    }

	}


	public partial class Plane : Vehicle
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

	    public override void Fly(string location)
	    {
	        // fly
	    }

	}

    public class Honda : Car
    {
        public override void Ride(string location)
        {
            base.Ride(location);
        }
    }

    public class Boeing : Plane
    {
        public override void Fly(string location)
        {
            base.Fly(location);
        }
    }




}
