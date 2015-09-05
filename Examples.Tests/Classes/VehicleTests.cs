using Examples.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Tests.Classes
{
	[TestClass]
	public class VehicleTests
	{
		//TODO: all tests should pass
		
		[TestMethod]
		public void ReadPlane()
		{
			//Arrange
			var vehicles = new Vehicles() { new Plane { Name = "Boeing 747", Cost = "$50 million", Engines = 4, Manufacturer = "Boeing", Passengers = 500 } };

			//Act
			var plane = vehicles.planes.FirstOrDefault();

			//Assert
			Assert.IsNotNull(plane);
			Assert.AreEqual(plane.Name, "Boeing 747");
			Assert.AreEqual(plane.Manufacturer, "Boeing");
			Assert.AreEqual(plane.Cost, "$50 million");
			Assert.AreEqual(plane.Passengers, 500);
			Assert.AreEqual(plane.Engines, 4);
		}

		[TestMethod]
		public void ReadCar()
		{
			//Arrange
			var vehicles = new Vehicles() { new Car { Name = "Prius", Manufacturer = "Toyota", Cost = "$40,000", Passengers = 5, Wheels = 4 } };

			//Act
			var car = vehicles.cars.FirstOrDefault();

			//Assert
			Assert.IsNotNull(car);
			Assert.AreEqual(car.Name, "Prius");
			Assert.AreEqual(car.Manufacturer, "Toyota");
			Assert.AreEqual(car.Cost, "$40,000");
			Assert.AreEqual(car.Passengers, 5);
			Assert.AreEqual(car.Wheels, 4);
		}

		[TestMethod]
		public void AddCar()
		{
			//Arrange
			var vehicles = new Vehicles();
			var car = new Car { Name = "Prius", Manufacturer = "Toyota" };

			//Act
			vehicles.cars.Add(car);

			//Assert
			Assert.AreEqual(vehicles.Count, 1);
		}

		[TestMethod]
		public void AddPlane()
		{
			//Arrange
			var vehicles = new Vehicles();
			var plane = new Plane { Name = "Boeing 747" };

			//Act
			vehicles.planes.Add(plane);

			//Assert
			Assert.AreEqual(vehicles.Count, 1);
		}

		[TestMethod]
		public void AddVehicle()
		{
			//Arrange
			var vehicles = new Vehicles();
			var plane = new Plane { Name = "Boeing 747" };
			var car = new Car { Name = "Prius", Manufacturer = "Toyota" };

			//Act
			vehicles.Add(plane);
			vehicles.Add(car);

			//Assert
			Assert.AreEqual(vehicles.Count, 1);
		}
	}
}
