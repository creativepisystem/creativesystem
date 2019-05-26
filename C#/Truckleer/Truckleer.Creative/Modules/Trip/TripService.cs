using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    public class TripService
    {
        //Trip repository property
        readonly TripRepository repository;
        //Class constructor
        public TripService()
        {
            //initializate trip repository property
            repository = new TripRepository();
        }
        //Method to findAll trips
        public List<Trip> FindAll()
        {
            return repository.FindAll().Result;
        }
        //Method to find one specific trip by id
        public Trip FindOne(string Id)
        {
            return repository.Find(Id).Result;
        }
        //Method to Save or Update trip
        public bool Save(Trip trip)
        {
            return repository.Save(trip).Result;
        }
    }
}
