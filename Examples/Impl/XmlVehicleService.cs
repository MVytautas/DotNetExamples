using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examples.Classes
{
	public class XmlVehicleService : IVehicleService
	{
		public XmlVehicleService(XDocument doc)
		{
			_doc = doc;
		}

		private XDocument _doc;


		public Car ReadCar(string carName)
		{
			var elm = _doc
				.Element("vehicles")
				.Element("cars")
				.Elements("car")
				.Where(e => e.Element("name").Value == carName)
				.FirstOrDefault();
			if (elm != null)
			{
				var car = new Car();
				car.Cost = elm.Element("cost").Value;
				car.Manufacturer = elm.Element("manufacturer").Value;
				car.Name = carName;
				car.Passengers = Convert.ToInt32(elm.Element("passengers").Value);
				car.Wheels = Convert.ToInt32(elm.Element("wheels").Value);
				return car;
			}
			else
			{
				return null;
			}
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

		public Vehicles ReadAllVehicles()
		{
			
			throw new NotImplementedException();
		}
	}
}
