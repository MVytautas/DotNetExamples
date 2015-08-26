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
		Car ReadCar(String carName);
		Plane ReadPlane(String planeName);
		
		List<Car> ReadAllCars();
		List<Plane> ReadAllPlanes();
		
		List<String> ReadAllManufacturers();
	}
}
