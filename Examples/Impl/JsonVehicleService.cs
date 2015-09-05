using System.IO;
using System.Xml.Serialization;
using Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Examples.Classes
{
    public class JsonVehicleService : IVehicleService
    {
        public JsonVehicleService(string jsonInput) // I google that, this represents an Json document. " JObject "
        {

            _carList = JsonConvert.DeserializeObject<List<Car>>(jsonInput);
            _planeList = JsonConvert.DeserializeObject<List<Plane>>(jsonInput);
        }

        private List<Car> _carList;
        private List<Plane> _planeList; 

        public Vehicles ReadAllVehicles() // Do I need ti impelemt this one also?
        {
            throw new NotImplementedException();
        }

        //The JsonVehicleService can NOT have any 'if', 'for', 'foreach', or 'while' statements
        //you must use 'where', 'select', 'selectmany', 'union' with lambas
        public Car ReadCar(string carName)
        {
            return _carList.SingleOrDefault(x => x.Name == carName);
        }

        public Plane ReadPlane(string planeName)
        {
            return _planeList.SingleOrDefault(x => x.Name == planeName);
        }

        public List<Car> ReadAllCars()
        {
            return _carList.SelectMany(name => name.Name, <Car>);
        }

        public List<Plane> ReadAllPlanes()
        {
            return _carList.SelectMany(name => name.Name, <Car>);
        }

        public List<string> ReadAllManufacturers()
        {
            throw new NotImplementedException();
        }
    }
}
