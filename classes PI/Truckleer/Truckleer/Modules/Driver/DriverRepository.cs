using Google.Cloud.Firestore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    class DriverRepository
    {
        //Collection reference property
        readonly CollectionReference Reference;
        //Constructor Class
        public DriverRepository()
        {
            //Create firestore connection
            ConnectionFirestore coon = new ConnectionFirestore();
            //Initializate Reference
            Reference = coon.Db.Collection("drivers");
        }

        //Method for get All drivers
        async public Task<List<Driver>> FindAll()
        {
            //Create a list of drivers
            List<Driver> drivers = new List<Driver>();
            //Create a Query without any filter
            QuerySnapshot snapshot = await Reference.GetSnapshotAsync();

            //Pass all Documents
            foreach (DocumentSnapshot queryResult in snapshot.Documents)
            {
                //Convert Document in a Driver class
                Driver us = queryResult.ConvertTo<Driver>();
                //Set id of driver
                us.Id = queryResult.Id;
                //Add driver to list
                drivers.Add(us);
            }
            //Return List
            return drivers;
        }
        //Method for find One driver by Id
        async public Task<Driver> Find(string Id)
        {
            //Create a Document Reference with id like /drivers/id_value
            DocumentSnapshot DocRef = await Reference.Document(Id).GetSnapshotAsync();
            //Initializate a driver  with null value
            Driver us = null;
            //Check if document exists
            if (DocRef.Exists)
            {
                //Convert document to a Driver class
                us = DocRef.ConvertTo<Driver>();
                //Set id of driver
                us.Id = DocRef.Id;
            }
            //Return driver
            return us;
        }
        //Method for save or update Driver
        async public Task<bool> Save(Driver driver)
        {
            //Check if driver exisit
            if (driver.Id == null)//If not exist
            {
                //Create new driver
                DocumentReference snapshot = await Reference.AddAsync(driver);
                //return a bool if is successful
                return snapshot.Id != null;
            }
            else
            {
                //update driver and merge values
                WriteResult snapshot = await Reference.Document(driver.Id).SetAsync(driver, SetOptions.MergeAll);
                //return a bool if is successful
                return snapshot.UpdateTime != null;
            }
        }
    }
}
