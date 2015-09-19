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
        //
        // GET: /Vehicle/
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Read(string name)
		{
			//MVC
			//Model = vehicle
			//Controller = VehicleController with action read
			//View = read view
			
			//query the database for vehicle with vechile.name == name
			Car vehicle = new Car() { Name = "Porshe", Cost = "100000" };

			//validate vehicle
			
			//query database for other vechile data
			vehicle.Manufacturer = new Manufacturer() { Name = "Porshe" };

			//


			return View(vehicle);
		}

		public ActionResult Create(string name)
		{
			return View();
		}
	}
}