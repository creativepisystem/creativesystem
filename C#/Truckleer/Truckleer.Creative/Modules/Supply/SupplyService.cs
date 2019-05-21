
using System.Collections.Generic;

namespace Truckleer.Modules
{
    public class SupplyService
    {
        //Supply repository property
        readonly SupplyRepository repository;
        //Class constructor
        public SupplyService()
        {
            //initializate supply repository property
            repository = new SupplyRepository();
        }
        //Method to findAll supplys
        public List<Supply> FindAll()
        {
            return repository.FindAll().Result;
        }
        //Method to find one specific supply by id
        public Supply FindOne(string Id)
        {
            return repository.Find(Id).Result;
        }
        //Method to Save or Update supply
        public bool Save(Supply supply)
        {
            return repository.Save(supply).Result;
        }
    }
}

