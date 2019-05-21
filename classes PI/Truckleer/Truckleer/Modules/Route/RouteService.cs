using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    class RouteService
    {
        //Route repository property
        readonly RouteRepository repository;
        //Class constructor
        public RouteService()
        {
            //initializate route repository property
            repository = new RouteRepository();
        }
        //Method to findAll routes
        public List<Route> FindAll()
        {
            return repository.FindAll().Result;
        }
        //Method to find one specific route by id
        public Route FindOne(string Id)
        {
            return repository.Find(Id).Result;
        }
        //Method to Save or Update route
        public bool Save(Route route)
        {
            return repository.Save(route).Result;
        }
    }
}
