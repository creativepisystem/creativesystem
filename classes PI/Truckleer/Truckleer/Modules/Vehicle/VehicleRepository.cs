using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    class VehicleRepository
    {
        //Collection reference property
        readonly CollectionReference Reference;
        //Constructor Class
        public VehicleRepository()
        {
            //Create firestore connection
            ConnectionFirestore coon = new ConnectionFirestore();
            //Initializate Reference
            Reference = coon.Db.Collection("vehicles");
        }

        //Method for get All vehicles
        async public Task<List<Vehicle>> FindAll()
        {
            //Create a list of vehicles
            List<Vehicle> vehicles = new List<Vehicle>();
            //Create a Query without any filter
            QuerySnapshot snapshot = await Reference.GetSnapshotAsync();

            //Pass all Documents
            foreach (DocumentSnapshot queryResult in snapshot.Documents)
            {
                //Convert Document in a Vehicle class
                Vehicle us = queryResult.ConvertTo<Vehicle>();
                //Set id of vehicle
                us.Id = queryResult.Id;
                //Add vehicle to list
                vehicles.Add(us);
            }
            //Return List
            return vehicles;
        }
        //Method for find One vehicle by Id
        async public Task<Vehicle> Find(string Id)
        {
            //Create a Document Reference with id like /vehicles/id_value
            DocumentSnapshot DocRef = await Reference.Document(Id).GetSnapshotAsync();
            //Initializate a vehicle  with null value
            Vehicle us = null;
            //Check if document exists
            if (DocRef.Exists)
            {
                //Convert document to a Vehicle class
                us = DocRef.ConvertTo<Vehicle>();
                //Set id of vehicle
                us.Id = DocRef.Id;
            }
            //Return vehicle
            return us;
        }
        //Method for save or update Vehicle
        async public Task<bool> Save(Vehicle vehicle)
        {
            //Check if vehicle exisit
            if (vehicle.Id == null)//If not exist
            {
                //Create new vehicle
                DocumentReference snapshot = await Reference.AddAsync(vehicle);
                //return a bool if is successful
                return snapshot.Id != null;
            }
            else
            {
                //update vehicle and merge values
                WriteResult snapshot = await Reference.Document(vehicle.Id).SetAsync(vehicle, SetOptions.MergeAll);
                //return a bool if is successful
                return snapshot.UpdateTime != null;
            }
        }
    }
}
