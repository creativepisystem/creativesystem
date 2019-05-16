﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Truckleer.Api.Classes
{
<<<<<<< HEAD
    public class Trip
=======
    [FirestoreData]
    class Trip
>>>>>>> f58830a559ae3e4f27f47af6f936eb3a068d0a9b
    {
        public Trip()
        {
        }

        private string id { get; set; }
        [FirestoreProperty]
        private DateTime date { get; set; }
        [FirestoreProperty]
        private string name { get; set; }
        [FirestoreProperty]
        private Route route { get; set; }
        private Driver driver { get; set; }
        [FirestoreProperty]
        private bool status { get; set; }
        private Vehicle vehicle { get; set; }
    }
}
