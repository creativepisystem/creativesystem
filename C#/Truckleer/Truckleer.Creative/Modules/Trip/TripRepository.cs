using Google.Cloud.Firestore;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Truckleer.Modules
{
    class TripRepository
    {
        //Collection reference property
        readonly CollectionReference Reference;
        //Constructor Class
        public TripRepository()
        {
            //Create firestore connection
            ConnectionFirestore coon = new ConnectionFirestore();
            //Initializate Reference
            Reference = coon.Db.Collection("travels");
        }

        //Method for get All trips
        async public Task<List<Trip>> FindAll()
        {
            //Create a list of trips
            List<Trip> trips = new List<Trip>();
            //Create a Query without any filter
            QuerySnapshot snapshot = await Reference.GetSnapshotAsync();

            //Pass all Documents
            foreach (DocumentSnapshot queryResult in snapshot.Documents)
            {
                //Convert Document in a Trip class
                Trip us = queryResult.ConvertTo<Trip>();
                //Set id of trip
                us.Id = queryResult.Id;
                //Add trip to list
                trips.Add(us);
            }
            //Return List
            return trips;
        }
        //Method for find One trip by Id
        async public Task<Trip> Find(string Id)
        {
            //Create a Document Reference with id like /trips/id_value
            DocumentSnapshot DocRef = await Reference.Document(Id).GetSnapshotAsync();
            //Initializate a trip  with null value
            Trip us = null;
            //Check if document exists
            if (DocRef.Exists)
            {
                //Convert document to a Trip class
                us = DocRef.ConvertTo<Trip>();
                //Set id of trip
                us.Id = DocRef.Id;
            }
            //Return trip
            return us;
        }
        //Method for save or update Trip
        async public Task<bool> Save(Trip trip)
        {
            //Check if trip exisit
            if (trip.Id == null)//If not exist
            {
                //Create new trip
                DocumentReference snapshot = await Reference.AddAsync(trip);
                //return a bool if is successful
                return snapshot.Id != null;
            }
            else
            {
                //update trip and merge values
                WriteResult snapshot = await Reference.Document(trip.Id).SetAsync(trip, SetOptions.MergeAll);
                //return a bool if is successful
                return snapshot.UpdateTime != null;
            }
        }
        //Method for filter Trip
        async public Task<List<Trip>> Filter(TripFilter tripFilter)
        {
            List<Trip> trips = new List<Trip>();

            return trips;
        }
    }
}
