using Examples.Classes;
using Examples.Interfaces;
using Examples.Models;
using Examples.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Examples.Web.Controllers
{
	public class VehicleController : Controller
	{
		public VehicleController()
		{
			if (_vehicleService == null)
				_vehicleService = new JsonVehicleService(new Vehicles() { new Car() { Name = "Accord", Cost = "$30,000" } });
		}

		private static JsonVehicleService _vehicleService;

		//List of vehicle
		public ActionResult Index()
		{
			var model = _vehicleService.ReadAllVehicles().Select(v => new VehicleModel(v)).ToList();
			return View(model);
		}

		public ActionResult Read(string name)
		{
			var vehicle = _vehicleService.ReadAllVehicles().FirstOrDefault(v => v.Name == name);

			if (vehicle == null)
			{
				//throw new Exception("cannot find vehicle");
				return Redirect("Error");
			}

			var model = new VehicleModel(vehicle);

			return View(model);
		}

		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}


		[HttpPost]
		public ActionResult Create(VehicleModel model)
		{
			//save new vehicle to db
			IVehicle vehicle;

			switch (model.Type)
			{
				case "Car":
					vehicle = new Car() { Name = model.Name, Cost = model.Cost };
					break;
				case "Plane":
					vehicle = new Plane() { Name = model.Name, Cost = model.Cost };
					break;
				default:
					throw new ArgumentException("type not supported");
			}

			_vehicleService.Create(vehicle);

			return RedirectToAction("Read", new { name = model.Name });
		}

		public ActionResult Edit(VehicleModel model)
		{
			throw new NotImplementedException();
		}

		public ActionResult Delete()
		{
			throw new NotImplementedException();
		}
	}
}