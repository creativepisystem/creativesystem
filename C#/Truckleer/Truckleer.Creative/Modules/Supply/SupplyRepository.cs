using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truckleer.Modules
{
    class SupplyRepository
    {
        //Collection reference property
        readonly CollectionReference Reference;
        //Constructor Class
        public SupplyRepository()
        {
            //Create firestore connection
            ConnectionFirestore coon = new ConnectionFirestore();
            //Initializate Reference
            Reference = coon.Db.Collection("supplys");
        }

        //Method for get All supplys
        async public Task<List<Supply>> FindAll()
        {
            //Create a list of supplys
            List<Supply> supplys = new List<Supply>();
            //Create a Query without any filter
            QuerySnapshot snapshot = await Reference.GetSnapshotAsync();

            //Pass all Documents
            foreach (DocumentSnapshot queryResult in snapshot.Documents)
            {
                //Convert Document in a Supply class
                Supply us = queryResult.ConvertTo<Supply>();
                //Set Id of supply
                us.Id = queryResult.Id;
                //Add supply to list
                supplys.Add(us);
            }
            //Return List
            return supplys;
        }
        //Method for find One supply by Id
        async public Task<Supply> Find(string Id)
        {
            //Create a Document Reference with Id like /supplys/Id_value
            DocumentSnapshot DocRef = await Reference.Document(Id).GetSnapshotAsync();
            //Initializate a supply  with null value
            Supply us = null;
            //Check if document exists
            if (DocRef.Exists)
            {
                //Convert document to a Supply class
                us = DocRef.ConvertTo<Supply>();
                //Set Id of supply
                us.Id = DocRef.Id;
            }
            //Return supply
            return us;
        }
        //Method for save or update Supply
        async public Task<bool> Save(Supply supply)
        {
            //Check if supply exisit
            if (supply.Id == null)//If not exist
            {
                //Create new supply
                DocumentReference snapshot = await Reference.AddAsync(supply);
                //return a bool if is successful
                return snapshot.Id != null;
            }
            else
            {
                //update supply and merge values
                WriteResult snapshot = await Reference.Document(supply.Id).SetAsync(supply, SetOptions.MergeAll);
                //return a bool if is successful
                return snapshot.UpdateTime != null;
            }
        }
        async public Task<List<Supply>> Filter(SupplyFilter supplyFilter)
        {
            //Create a list of supplys
            List<Supply> supplys = new List<Supply>();

            Console.WriteLine(supplyFilter.Driver != null);
            Query query = Reference;
            
            query = query.WhereGreaterThanOrEqualTo("date", DateUtil.DateTimeToTimeStamp(supplyFilter.StartAt)).OrderByDescending("date");
            query = query.WhereLessThan("date", DateUtil.DateTimeToTimeStamp(supplyFilter.EndAt));
            if (supplyFilter.Driver != null)
                query = query.WhereEqualTo("driver", supplyFilter.Driver.Id);
            if (supplyFilter.Route != null)
                query = query.WhereEqualTo("route", supplyFilter.Route.Id);
            if (supplyFilter.Trip != null)
                query = query.WhereEqualTo("travel", supplyFilter.Trip.Id);
            if (supplyFilter.Vehicle != null)
                query = query.WhereEqualTo("vehicle", supplyFilter.Vehicle.Id);

            QuerySnapshot snapshot = await query
                .GetSnapshotAsync();

            //Pass all Documents
            foreach (DocumentSnapshot queryResult in snapshot.Documents)
            {
                //Convert Document in a Supply class
                Supply us = queryResult.ConvertTo<Supply>();
                //Set Id of supply
                us.Id = queryResult.Id;
                //Add supply to list
                supplys.Add(us);
            }
            return supplys;
        }
    }
}
