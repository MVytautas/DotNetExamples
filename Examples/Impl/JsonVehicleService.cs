using System.IO;
using System.Xml.Serialization;
using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Examples.Classes
{
    public class JsonVehicleService : IVehicleService
    {
		public JsonVehicleService(Vehicles vehicles) // I google that, this represents an Json document. " JObject "
        {
			_vehicles = vehicles;
        }

		private Vehicles _vehicles; 

        public Vehicles ReadAllVehicles() // Do I need ti impelemt this one also?
        {
			return _vehicles;
        }

        public Car ReadCar(string carName)
        {
			return _vehicles.cars.FirstOrDefault(x => x.Name == carName);
        }

        public Plane ReadPlane(string planeName)
        {
			return _vehicles.planes.FirstOrDefault(x => x.Name == planeName);
        }

        public List<Car> ReadAllCars()
        {
			return _vehicles.cars;
        }

        public List<Plane> ReadAllPlanes()
        {
			return _vehicles.planes;
        }

        public List<String> ReadAllManufacturers()
        {
			var results = new List<String>();

			results.AddRange(_vehicles.cars.Select(c => c.Manufacturer));

			results.AddRange(_vehicles.planes.Select(c => c.Manufacturer));

			return results;
        }
    }
}
