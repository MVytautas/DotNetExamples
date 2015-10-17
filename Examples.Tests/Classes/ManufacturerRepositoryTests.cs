using Examples.Impl;
using Examples.Interfaces;
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
	public class ManufacturerRepositoryTests
	{
		[TestInitialize]
		public void Setup()
		{
			//var sampleDB = JsonConvert.DeserializeObject<Vehicles>(Sampledata.VehiclesJson);

			var sampleManufactures = JsonConvert.DeserializeObject<List<Manufacturer>>(Sampledata.Manufacturers);

            //var sampleDB = JsonConvert.DeserializeObject<Vehicles>(Sampledata.VehiclesJson);
            var sampleDB = new Vehicles();
            var tmp = JsonConvert.DeserializeAnonymousType(Sampledata.VehiclesJson, new { planes = new List<Plane>(), cars = new List<Car>() });
            sampleDB.AddRange(tmp.cars);
            sampleDB.AddRange(tmp.planes);

			_manufacturerRepository = new ManufacturerRepository(sampleDB, sampleManufactures);

		}

		IManufacturerRepository _manufacturerRepository;

		[TestMethod]
		public void ReadLocationsLessThanPassengers()
		{
			//Arrange

			//Act
			//read locations of manufactures that produce a vehicle that has less than 5 passaengers
			List<string> result = _manufacturerRepository.ReadLocationsLessThanPassengers(5);

			//Assert
			Assert.AreEqual(result.Count, 4);
			Assert.IsTrue(result.Contains("Japan"));
			Assert.IsTrue(result.Contains("USA"));
			Assert.IsTrue(result.Contains("Germany"));
			Assert.IsTrue(result.Contains("UK"));
		}



		[TestMethod]
		public void ReadLessThanPassengers()
		{
			//Arrange

			//Act
			//read manufactures that produce a vehicle that has less than 5 passaengers
			List<Manufacturer> result = _manufacturerRepository.ReadLessThanPassengers(5);

			//Assert
			Assert.AreEqual(result.Count, 4);
			Assert.IsTrue(result.Any(m => m.Name == "Honda"));
			Assert.IsTrue(result.Any(m => m.Name == "BMW"));
			Assert.IsTrue(result.Any(m => m.Name == "Volkswagen"));
			Assert.IsTrue(result.Any(m => m.Name == "Lockheed Martin"));
		}

		[TestMethod]
		public void ReadLessThanCost()
		{
			//Arrange

			//Act
			//read manufactures that produce a vehicle that costs less than 38,000
			List<Manufacturer> result = _manufacturerRepository.ReadLessThanCost(38000);

			//Assert
			Assert.AreEqual(result.Count, 2);
			Assert.IsTrue(result.Any(m => m.Name == "Honda"));
			Assert.IsTrue(result.Any(m => m.Name == "Volkswagen"));
		}

		[TestMethod]
		public void ReadLocationsLessThanCost()
		{
			//Arrange

			//Act
			//read locations of manufactures that produce a vehicle that costs less than $38,000
			List<string> result = _manufacturerRepository.ReadLocationsLessThanCost(38000);

			//Assert
			Assert.AreEqual(result.Count, 2);
			Assert.IsTrue(result.Contains("Japan"));
			Assert.IsTrue(result.Contains("Germany"));
		}


		[TestMethod]
		public void ReadAll()
		{
			throw new NotImplementedException();
		}

		[TestMethod]
		public void Read_By_ID()
		{
			throw new NotImplementedException();
		}

		[TestMethod]
		public void Read_By_Name()
		{
			throw new NotImplementedException();
		}

		[TestMethod]
		public void Read_By_Vehicle()
		{
			throw new NotImplementedException();
		}

		[TestMethod]
		public void Read_By_Type()
		{
			throw new NotImplementedException();
		}

		[TestMethod]
		public void ReadLocations_By_Type()
		{
			throw new NotImplementedException();
		}

		[TestMethod]
		public void ReadVehiclesProduced()
		{
			throw new NotImplementedException();
		}



	}
}
