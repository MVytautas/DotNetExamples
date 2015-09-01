using System.IO;
using System.Xml.Serialization;
using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examples.Classes
{
	public  class XmlVehicleService : IVehicleService
	{
		public XmlVehicleService(XDocument doc)
		{
			_doc = doc;
		}

		private XDocument _doc;


		public Car ReadCar(string carName)
		{
			var elm = _doc
				.Element("vehicles")
				.Element("cars")
				.Elements("car")
				.Where(e => e.Element("name").Value == carName)
				.FirstOrDefault();
			if (elm != null)
			{
				var car = new Car();
				car.Cost = elm.Element("cost").Value;
				car.Manufacturer = elm.Element("manufacturer").Value;
				car.Name = carName;
				car.Passengers = Convert.ToInt32(elm.Element("passengers").Value);
				car.Wheels = Convert.ToInt32(elm.Element("wheels").Value);
				return car;
			}
			else
			{
				return null;
			}
		}

        public Plane ReadPlane(string planeName)
        {
            // just simple declaration of elm = _doc?
            var elm =
                _doc.Element("vehicles")
                    .Element("planes")
                    .Elements("plane")
                    .Where(x => x.Element("name").Value == planeName)
                    .FirstOrDefault();

            if (elm != null)
            {
                var plane = new Plane();
                plane.Cost = elm.Element("cost").Value;
                plane.Manufacturer = elm.Element("manufacturer").Value;
                plane.Name = planeName;
                plane.Passengers = Convert.ToInt32(elm.Element("passengers").Value);
                plane.Engines = Convert.ToInt32(elm.Element("engines").Value);
                return plane;
            }
            else
            {
                return null;
            }
        }

	    public List<Car> ReadAllCars()
	    {
	        throw new NotImplementedException();
	    }

	    //public List<Car> ReadAllCars()
        //{
        //    throw new NotImplementedException();
        //}

	    //public Plane ReadPlane(string planeName)
        //{
        //    throw new NotImplementedException();
        //}

	    public List<Car> ReadAllCars(string cars)
	    {
	        var elm =
	            _doc.Element("vehicles")
	                .Element("cars")
	                .Elements("car")
	                .Where(x => x.Element("name").Value == cars)
	                .ToList();

	        if (elm != null)
	        {
	            var carstring =
	                _doc.Element("vehicles")
	                    .Element("cars").ToString().FromXML<List<Car>>();


                var s = new XmlSerializer(typeof(List<Car>));
                using (var reader = new StringReader(carstring))
                {
                    return (List<Car>)s.Deserialize(reader);
                   
                }

	            //    var car = new Car();
	            //    foreach (var car in elm)
	            //    {
	            //        car.Name = cars;
	            //    }
	            //    return car;
	            //}
	            //else
	            //{
	            //    return null;
	            //}

	        }
            return null;
	    }

	    //public List<Car> ReadAllCars()
        //{
        //    throw new NotImplementedException();
        //}

		public List<Plane> ReadAllPlanes()
		{
			throw new NotImplementedException();
		}

		public List<string> ReadAllManufacturers()
		{
			throw new NotImplementedException();
		}

		public Vehicles ReadAllVehicles()
		{
			
			throw new NotImplementedException();
		}

       
	}

    public static class Exstensions
    {
        public static string ToXml(this object obj)
        {
            var s = new XmlSerializer(obj.GetType());
            using (var writer = new StringWriter())
            {
                s.Serialize(writer, obj);
                return writer.ToString();
            }
        }

        public static T FromXml<T>(this string data)
        {
            var s = new XmlSerializer(typeof(T));
            using (var reader = new StringReader(data))
            {
                object obj = s.Deserialize(reader);
                return (T)obj;
            }
        }
    }
}
