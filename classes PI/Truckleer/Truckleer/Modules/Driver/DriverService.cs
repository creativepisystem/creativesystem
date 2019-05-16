using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    class DriverService
    {
        //Driver repository property
        readonly DriverRepository repository;
        //Class constructor
        public DriverService()
        {
            //initializate driver repository property
            repository = new DriverRepository();
        }
        //Method to findAll drivers
        public List<Driver> FindAll()
        {
            return repository.FindAll().Result;
        }
        //Method to find one specific driver by id
        public Driver FindOne(string Id)
        {
            return repository.Find(Id).Result;
        }
        //Method to Save or Update driver
        public bool Save(Driver driver)
        {
            return repository.Save(driver).Result;
        }
    }
}
