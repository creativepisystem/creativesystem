﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Api.Classes
{
<<<<<<< HEAD
    public class Driver
=======
    [FirestoreData]
    class Driver
>>>>>>> f58830a559ae3e4f27f47af6f936eb3a068d0a9b
    {
        //Constructor
        public Driver()
        {
        }
        //Atributes
        public string id { get; set; }
        [FirestoreProperty]
        public string name { get; set; }
        [FirestoreProperty]
        public string cpf { get; set; }
        [FirestoreProperty]
        public string cnh { get; set; }
        [FirestoreProperty]
        public int cnh_number { get; set; }
        [FirestoreProperty]
        public DateTime birth_date { get; set; }
        [FirestoreProperty]
        public int phone { get; set; }
        [FirestoreProperty]
        public string email { get; set; }
        [FirestoreProperty]
        public DateTime cnh_expiration { get; set; }
        [FirestoreProperty]
        public string photo { get; set; }
        [FirestoreProperty]
        public string obs { get; set; }
        public User User { get; set; }
    }

}
