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
        DriverService DriverService;
        VehicleService VehicleService;
        RouteService RouteService;
        public TripRepository()
        {
            //Create firestore connection
            ConnectionFirestore coon = new ConnectionFirestore();
            //Initializate Reference
            Reference = coon.Db.Collection("travels");

            DriverService = new DriverService();
            VehicleService = new VehicleService();
            RouteService = new RouteService();
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
                us.id = queryResult.Id;
                string Route = queryResult.GetValue<string>("route");
                if (Route != null)
                    us.route = RouteService.FindOne(Route);
                us.vehicle = VehicleService.FindOne(queryResult.GetValue<string>("vehicle"));
                us.driver = DriverService.FindOne(queryResult.GetValue<string>("driver"));
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
                us.id = DocRef.Id;
                string Route = DocRef.GetValue<string>("route");
                if (Route != null)
                    us.route = RouteService.FindOne(Route);
                us.vehicle = VehicleService.FindOne(DocRef.GetValue<string>("vehicle"));
                us.driver = DriverService.FindOne(DocRef.GetValue<string>("driver"));
            }
            //Return trip
            return us;
        }
        //Method for save or update Trip
        async public Task<bool> Save(Trip trip)
        {
            //Check if trip exisit
            if (trip.id == null)//If not exist
            {
                //Create new trip
                DocumentReference snapshot = await Reference.AddAsync(trip.ToObject());
                //return a bool if is successful
                return snapshot.Id != null;
            }
            else
            {
                //update trip and merge values
                WriteResult snapshot = await Reference.Document(trip.id).SetAsync(trip.ToObject(), SetOptions.MergeAll);
                //return a bool if is successful
                return snapshot.UpdateTime != null;
            }
        }
    }
}
