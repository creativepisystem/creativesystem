﻿using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Api.Classes
{
<<<<<<< HEAD
    public class User
=======
    [FirestoreData]
    class User
>>>>>>> f58830a559ae3e4f27f47af6f936eb3a068d0a9b
    {
        //Constructor
        public User()
        {
        }

        //Artributes
        private string id { get; set; }
        [FirestoreProperty]
        private string login { get; set; }
        [FirestoreProperty]
        private string password { get; set; }
        [FirestoreProperty]
        private UserType type { get; set; }
        [FirestoreProperty]
        private string auth { get; set; }
        [FirestoreProperty]
        private string email { get; set; }
    
}
