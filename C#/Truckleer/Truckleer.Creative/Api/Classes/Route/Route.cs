﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Api.Classes
{
<<<<<<< HEAD
    public class Route
=======
    [FirestoreData]
    class Route
>>>>>>> f58830a559ae3e4f27f47af6f936eb3a068d0a9b
    {
        //Constructor
        public Route()
        {
        }

        //Atributes
        private string id { get; set; }
        [FirestoreProperty]
        private string origin { get; set; }
        [FirestoreProperty]
        private string destination { get; set; }
        [FirestoreProperty]
        private List <string> stops { get; set; }
    }
}
