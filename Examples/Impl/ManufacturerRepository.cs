using System.Data;
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
			return _manufacturers.FirstOrDefault(m => m.ID == id);
		}

		public Manufacturer Read(string name)
		{
            return _manufacturers.FirstOrDefault(m => m.Name == name);
		}

		public Manufacturer Read(IVehicle vehicle)
		{
            return _manufacturers.FirstOrDefault(m => m.Name == vehicle.Name);
		}

		public List<Manufacturer> Read(VehicleType type)
		{
            //vehicleType = _vehicles.Where()
            return _manufacturers.Where(m => m.TypesOfVehicles == type).ToList();
		}

		public List<Manufacturer> ReadLessThanPassengers(int passengers)
		{
            var veciclesFiler = _vehicles.Where(x => x.Passengers > passengers).Select(x => x.Name).FirstOrDefault();
            return _manufacturers.Where(m => m.VehicleProduces.Any(v => veciclesFiler.Contains(v.Name)) == true).ToList();
		}

		public List<Manufacturer> ReadLessThanCost(int cost)
		{
            //return _manufacturers.Where(m => m.Name == _vehicles.Where(x => x.Name).Select(x => x.Cost > 40000)).ToList();
            throw new NotImplementedException();
		}

		public List<string> ReadLocations(VehicleType type)
		{
            //return _manufacturers.Where(m => m.Location).ToList();
            throw new NotImplementedException();
		}

		public List<string> ReadLocationsLessThanPassengers(int passengers)
		{
            return _manufacturers.Where(m => _vehicles.Any(x => x.Passengers < passengers && x.ManufacturerID == m.ID )).Select(m => m.Location).ToList(); 
            //return _manufacturers.Where(manufacturerName).ToList();
		    //throw new NotImplementedException();
		}

		public List<string> ReadLocationsLessThanCost(int cost)
		{
            //var manufacturerName = _manufacturers.Where(m => m.Name == _vehicles.Where(x => x.Name).Select(x => x.Cost > 40000)).ToList();
            //return _manufacturers.Where(m => m.Location && manufacturerName).ToList();
            throw new NotImplementedException();
		}

		public List<IVehicle> ReadVehiclesProduced(Manufacturer manufacturer)
		{
            return _vehicles.Where(m => m.Manufacturer == manufacturer).ToList();
		}

	}
}
