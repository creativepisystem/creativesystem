﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Api.Classes
{
<<<<<<< HEAD
    public class Vehicle
=======
    [FirestoreData]
    class Vehicle
>>>>>>> f58830a559ae3e4f27f47af6f936eb3a068d0a9b
    {
        public Vehicle()
        {

        }

        private string id { get; set; }
        [FirestoreProperty]
        private string license_plate { get; set; }
        [FirestoreProperty]
        private string model { get; set; }
        [FirestoreProperty]
        private string brand { get; set; }
        [FirestoreProperty]
        private int tank_capacity { get; set; }
        [FirestoreProperty]
        private int fab_Year { get; set; }
        [FirestoreProperty]
        private int mod_Year { get; set; }
        [FirestoreProperty]
        private string color { get; set; }
        [FirestoreProperty]
        private int renavam { get; set; }
        [FirestoreProperty]
        private string chassi { get; set; }
    }
}
