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
			throw new NotImplementedException();
		}

		public Manufacturer Read(IVehicle vehicle)
		{
			throw new NotImplementedException();
		}

		public List<Manufacturer> Read(VehicleType type)
		{
			throw new NotImplementedException();
		}

		public List<Manufacturer> ReadLessThanPassengers(int passengers)
		{
			throw new NotImplementedException();
		}

		public List<Manufacturer> ReadLessThanCost(int cost)
		{
			throw new NotImplementedException();
		}

		public List<string> ReadLocations(VehicleType type)
		{
			throw new NotImplementedException();
		}

		public List<string> ReadLocationsLessThanPassengers(int passengers)
		{
			throw new NotImplementedException();
		}

		public List<string> ReadLocationsLessThanCost(int cost)
		{
			throw new NotImplementedException();
		}

		public List<IVehicle> ReadVehiclesProduced(Manufacturer manufacturer)
		{
			throw new NotImplementedException();
		}

	}
}
