using Examples.Classes;
using Examples.Interfaces;
using Examples.Models;
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

		//
		// GET: /Vehicle/
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Read(string name)
		{
			var vehicle = _vehicleService.ReadAllVehicles().FirstOrDefault(v => v.Name == name);

			if (vehicle == null)
			{
				//throw new Exception("cannot find vehicle");
				return Redirect("Error");
			}

			return View(vehicle);
		}

		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}


		[HttpPost]
		public ActionResult Create(string name, string cost, string type)
		{
			//save new vehicle to db
			IVehicle vehicle;
			if (type == "Car")
			{
				vehicle = new Car() { Name = name, Cost = cost };
			}
			else if (type == "Plane")
			{
				vehicle = new Plane() { Name = name, Cost = cost };
			}
			else
			{
				throw new ArgumentException("type not supported");
			}

			_vehicleService.Create(vehicle);

			return RedirectToAction("Read", new { name = name });
		}
	}
}