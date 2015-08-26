using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examples.Classes
{
	public class VehicleService : IVehicleService
	{
		public VehicleService(XDocument doc)
		{
			_doc = doc;
		}

		private XDocument _doc;

		public Car ReadCar(string carName)
		{
			throw new NotImplementedException();
		}

		public Plane ReadPlane(string planeName)
		{
			throw new NotImplementedException();
		}

		public List<Car> ReadAllCars()
		{
			throw new NotImplementedException();
		}

		public List<Plane> ReadAllPlanes()
		{
			throw new NotImplementedException();
		}

		public List<string> ReadAllManufacturers()
		{
			throw new NotImplementedException();
		}
	}
}
