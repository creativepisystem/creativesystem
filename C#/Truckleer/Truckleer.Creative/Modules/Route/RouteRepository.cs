using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    class RouteRepository
    {
        //Collection reference property
        readonly CollectionReference Reference;
        //Constructor Class
        public RouteRepository()
        {
            //Create firestore connection
            ConnectionFirestore coon = new ConnectionFirestore();
            //Initializate Reference
            Reference = coon.Db.Collection("routes");
        }

        //Method for get All routes
        async public Task<List<Route>> FindAll()
        {
            //Create a list of routes
            List<Route> routes = new List<Route>();
            //Create a Query without any filter
            QuerySnapshot snapshot = await Reference.GetSnapshotAsync();

            //Pass all Documents
            foreach (DocumentSnapshot queryResult in snapshot.Documents)
            {
                //Convert Document in a Route class
                Route us = queryResult.ConvertTo<Route>();
                //Set id of route
                us.id = queryResult.Id;
                //Add route to list
                routes.Add(us);
            }
            //Return List
            return routes;
        }
        //Method for find One route by Id
        async public Task<Route> Find(string Id)
        {
            //Create a Document Reference with id like /routes/id_value
            DocumentSnapshot DocRef = await Reference.Document(Id).GetSnapshotAsync();
            //Initializate a route  with null value
            Route us = null;
            //Check if document exists
            if (DocRef.Exists)
            {
                //Convert document to a Route class
                us = DocRef.ConvertTo<Route>();
                //Set id of route
                us.id = DocRef.Id;
            }
            //Return route
            return us;
        }
        //Method for save or update Route
        async public Task<bool> Save(Route route)
        {
            //Check if route exisit
            if (route.id == null)//If not exist
            {
                //Create new route
                DocumentReference snapshot = await Reference.AddAsync(route.ToObject());
                //return a bool if is successful
                return snapshot.Id != null;
            }
            else
            {
                //update route and merge values
                WriteResult snapshot = await Reference.Document(route.id).SetAsync(route.ToObject(), SetOptions.MergeAll);
                //return a bool if is successful
                return snapshot.UpdateTime != null;
            }
        }
    }
}