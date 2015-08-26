using Microsoft.VisualStudio.TestTools.UnitTesting;
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
			//var sampleDB = <json data>;
			//_vehicleService = new JsonVehicleService(sampleDB);
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
	}
}
