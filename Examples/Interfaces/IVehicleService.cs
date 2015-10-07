using Examples.Interfaces;
using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examples
{
	public interface IVehicleService
	{
		Vehicles ReadAllVehicles();
		
		Car ReadCar(String carName);
		Plane ReadPlane(String planeName);
		
		List<Car> ReadAllCars();
		List<Plane> ReadAllPlanes();

		List<Manufacturer> ReadAllManufacturers();

		void Create(IVehicle vechile);
		//void Delete(IVehicle vechile);)
	}
}
