using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    class VehicleService
    {
        //Vehicle repository property
        readonly VehicleRepository repository;
        //Class constructor
        public VehicleService()
        {
            //initializate vehicle repository property
            repository = new VehicleRepository();
        }
        //Method to findAll vehicles
        public List<Vehicle> FindAll()
        {
            return repository.FindAll().Result;
        }
        //Method to find one specific vehicle by id
        public Vehicle FindOne(string Id)
        {
            return repository.Find(Id).Result;
        }
        //Method to Save or Update vehicle
        public bool Save(Vehicle vehicle)
        {
            return repository.Save(vehicle).Result;
        }
    }
}
