using Examples.Classes;
using Examples.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examples.Tests.Classes
{
	[TestClass]
	public class XmlVehicleService_Tests
	{
		[TestInitialize]
		public void Setup()
		{
			var sampleDB = XDocument.Parse(Sampledata.Vehicles);
			_vehicleService = new XmlVehicleService(sampleDB);
		}

		private IVehicleService _vehicleService;

		[TestMethod]
		public void SimpleService_ReadCar()
		{
			//arrange


			//act
			var result = _vehicleService.ReadCar("Accord");

			//assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void SimpleService_ReadCar_DoesntExist()
		{
			//arrange


			//act
			var result = _vehicleService.ReadCar("Camery");

			//assert
			Assert.IsNull(result);
		}

		[TestMethod]
		public void SimpleService_ReadPlane()
		{
			//arrange


			//act
			var result = _vehicleService.ReadPlane("Boeing 747");

			//assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void SimpleService_ReadPlane_DoesntExist()
		{
			//arrange


			//act
			var result = _vehicleService.ReadPlane("F-22 Raptor");

			//assert
			Assert.IsNull(result);
		}

		[TestMethod]
		public void SimpleService_ReadAllCars()
		{
			//arrange


			//act
			var result = _vehicleService.ReadAllCars();

			//assert
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Any());
		}

		[TestMethod]
		public void SimpleService_ReadAllPlanes()
		{
			//arrange


			//act
			var result = _vehicleService.ReadAllPlanes();

			//assert
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Any());
		}

		[TestMethod]
		public void SimpleService_ReadAllManufacturers()
		{
			//arrange


			//act
			var result = _vehicleService.ReadAllManufacturers();

			//assert
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Any());
		}
	}
}
