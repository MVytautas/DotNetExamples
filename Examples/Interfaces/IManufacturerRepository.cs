using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Interfaces
{
	public interface IManufacturerRepository
	{
		List<Manufacturer> ReadAll();
		Manufacturer Read(Int32 id);
		Manufacturer Read(String name);
		Manufacturer Read(IVehicle vehicle);
		List<Manufacturer> Read(VehicleType type);

		List<Manufacturer> ReadLessThanPassengers(Int32 passengers);
		List<Manufacturer> ReadLessThanCost(Int32 cost);

		List<String> ReadLocations(VehicleType type);
		List<String> ReadLocationsLessThanPassengers(Int32 passengers);
		List<String> ReadLocationsLessThanCost(Int32 cost);
		
		List<IVehicle> ReadVehiclesProduced(Manufacturer manufacturer);
	}
}
