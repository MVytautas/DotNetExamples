using Examples.Interfaces;
using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Impl
{
	public class ManufacturerRepository : IManufacturerRepository
	{
		public ManufacturerRepository(Vehicles vehicles, List<Manufacturer> manufacturers)
		{
			_vehicles = vehicles;
			_manufacturers = manufacturers;
		}

		private Vehicles _vehicles;
		private List<Manufacturer> _manufacturers;

		//TODO: Complete Implementation



		public List<Manufacturer> ReadAll()
		{
			return _manufacturers;
		}

		public Manufacturer Read(int id)
		{
			return _manufacturers.Where(m => m.ID == id).FirstOrDefault();
		}

		public Manufacturer Read(string name)
		{
            return _manufacturers.Where(m => m.Name == name).FirstOrDefault();
		}

		public Manufacturer Read(IVehicle vehicle)
		{
            return _manufacturers.Where(m => m.Name == vehicle.Name).FirstOrDefault();
		}

		public List<Manufacturer> Read(VehicleType type)
		{
            //vehicleType = _vehicles.Where()
            return _manufacturers.Where(m => m.TypesOfVehicles == type).ToList();
		}

		public List<Manufacturer> ReadLessThanPassengers(int passengers)
		{
            var passengersFiler = _vehicles.Where(x => x.Name).Select(x => x.Passengers > 4).FirstOrDefault();
            return _manufacturers.Where(m => m.Name == passengersFiler).ToList();
		}

		public List<Manufacturer> ReadLessThanCost(int cost)
		{
            return _manufacturers.Where(m => m.Name == _vehicles.Where(x => x.Name).Select(x => x.Cost > 40000)).ToList();
		}

		public List<string> ReadLocations(VehicleType type)
		{
            return _manufacturers.Where(m => m.Location).ToList();
		}

		public List<string> ReadLocationsLessThanPassengers(int passengers)
		{
            manufacturerName = _manufacturers.Where(m => m.Name == _vehicles.Where(x => x.Name).Select(x => x.Passengers > 4)).ToList();
            return _manufacturers.Where(m => m.Location && manufacturerName).ToList();
		}

		public List<string> ReadLocationsLessThanCost(int cost)
		{
            manufacturerName = _manufacturers.Where(m => m.Name == _vehicles.Where(x => x.Name).Select(x => x.Cost > 40000)).ToList();
            return _manufacturers.Where(m => m.Location && manufacturerName).ToList();
		}

		public List<IVehicle> ReadVehiclesProduced(Manufacturer manufacturer)
		{
            return _vehicles.Where(m => m.Manufacturer == manufacturer).ToList();
		}

	}
}
