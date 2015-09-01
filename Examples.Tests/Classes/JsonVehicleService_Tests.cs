using Examples.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Tests.Classes
{
	[TestClass]
	public class JsonVehicleService_Tests
	{
		[TestInitialize]
		public void Setup()
		{
			var sampleDB = JsonConvert.DeserializeObject<Vehicles>(Sampledata.VehiclesJson);
			//_vehicleService = new JsonVehicleService(sampleDB);
			//The JsonVehicleService can NOT have any 'if', 'for', 'foreach', or 'while' statements
			//you must use 'where', 'select', 'selectmany', 'union' with lambas
		}

		private IVehicleService _vehicleService;

		[TestMethod]
		public void SimpleService_JSON_ReadCar()
		{
			//arrange


			//act
			var result = _vehicleService.ReadCar("Accord");

			//assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void SimpleService_JSON_ReadCar_DoesntExist()
		{
			//arrange


			//act
			var result = _vehicleService.ReadPlane("Camery");

			//assert
			Assert.IsNull(result);
		}

		[TestMethod]
		public void SimpleService_JSON_ReadPlane()
		{
			//arrange


			//act
			var result = _vehicleService.ReadPlane("Boeing 747");

			//assert
			Assert.IsNotNull(result);
		}

		[TestMethod]
		public void SimpleService_JSON_ReadPlane_DoesntExist()
		{
			//arrange


			//act
			var result = _vehicleService.ReadPlane("F-22 Raptor");

			//assert
			Assert.IsNull(result);
		}

		[TestMethod]
		public void SimpleService_JSON_ReadAllCars()
		{
			//arrange


			//act
			var result = _vehicleService.ReadAllCars();

			//assert
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Any());
		}

		[TestMethod]
		public void SimpleService_JSON_ReadAllPlanes()
		{
			//arrange


			//act
			var result = _vehicleService.ReadAllPlanes();

			//assert
			Assert.IsNotNull(result);
			Assert.IsTrue(result.Any());
		}

		[TestMethod]
		public void SimpleService_JSON_ReadAllManufacturers()
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
