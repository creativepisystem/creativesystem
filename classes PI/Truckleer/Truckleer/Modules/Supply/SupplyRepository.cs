﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    class SupplyRepository
    {
        //Collection reference property
        readonly CollectionReference Reference;
        //Constructor Class
        DriverService DriverService;
        VehicleService VehicleService;
        RouteService RouteService;
        TripService TripService;
        public SupplyRepository()
        {
            //Create firestore connection
            ConnectionFirestore coon = new ConnectionFirestore();
            //Initializate Reference
            Reference = coon.Db.Collection("supplys");

            DriverService = new DriverService();
            VehicleService = new VehicleService();
            RouteService = new RouteService();
            TripService = new TripService();
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
                string Route = queryResult.GetValue<string>("route");
                if (Route != null)
                    us.Route = RouteService.FindOne(Route);
                us.Vehicle = VehicleService.FindOne(queryResult.GetValue<string>("vehicle"));
                us.Driver = DriverService.FindOne(queryResult.GetValue<string>("driver"));
                us.Trip = TripService.FindOne(queryResult.GetValue<string>("travel"));
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
                string Route = DocRef.GetValue<string>("route");
                if (Route != null)
                    us.Route = RouteService.FindOne(Route);
                us.Vehicle = VehicleService.FindOne(DocRef.GetValue<string>("vehicle"));
                us.Driver = DriverService.FindOne(DocRef.GetValue<string>("driver"));
                us.Trip = TripService.FindOne(DocRef.GetValue<string>("travel"));
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
                DocumentReference snapshot = await Reference.AddAsync(supply.ToObject());
                //return a bool if is successful
                return snapshot.Id != null;
            }
            else
            {
                //update supply and merge values
                WriteResult snapshot = await Reference.Document(supply.Id).SetAsync(supply.ToObject(), SetOptions.MergeAll);
                //return a bool if is successful
                return snapshot.UpdateTime != null;
            }
        }
        async public Task<List<Supply>> Filter(SupplyFilter supplyFilter)
        {
            //Create a list of supplys
            List<Supply> supplys = new List<Supply>();

            Console.WriteLine(supplyFilter.driver != null);
            Query query = Reference;
            
            query = query.WhereGreaterThanOrEqualTo("date", DateUtil.DateTimeToTimeStamp(supplyFilter.startAt)).OrderByDescending("date");
            //query = query.WhereLessThan("date", DateUtil.DateTimeToTimeStamp(supplyFilter.endAt));
            if (supplyFilter.driver != null)
                query = query.WhereEqualTo("driver", supplyFilter.driver.Id);
            if (supplyFilter.route != null)
                query = query.WhereEqualTo("route", supplyFilter.route.Id);
            if (supplyFilter.trip != null)
                query = query.WhereEqualTo("travel", supplyFilter.trip.id);
            if (supplyFilter.vehicle != null)
                query = query.WhereEqualTo("vehicle", supplyFilter.vehicle.id);

            QuerySnapshot snapshot = await query
                .GetSnapshotAsync();

            //Pass all Documents
            foreach (DocumentSnapshot queryResult in snapshot.Documents)
            {
                //Convert Document in a Supply class
                Supply us = queryResult.ConvertTo<Supply>();
                //Set Id of supply
                us.Id = queryResult.Id;
                string Route = null;
                try
                {
                    Route = queryResult.GetValue<string>("route");
               
                
                if (Route != null)
                    us.Route = RouteService.FindOne(Route);
                us.Vehicle = VehicleService.FindOne(queryResult.GetValue<string>("vehicle"));
                us.Driver = DriverService.FindOne(queryResult.GetValue<string>("driver"));
                us.Trip = TripService.FindOne(queryResult.GetValue<string>("travel"));
                }
                catch { }
                //Add supply to list
                supplys.Add(us);
            }
            return supplys;
        }
    }
}
