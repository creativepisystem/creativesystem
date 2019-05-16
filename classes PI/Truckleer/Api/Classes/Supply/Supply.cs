using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Truckleer.Api.Classes
{
    [FirestoreData]
    class Supply
    {
        public Supply()
        {
        }

        public string id { get; set; }
        [FirestoreProperty]
        public DateTime date { get; set; }
        public Driver driver { get; set; }
        public Vehicle vehicle { get; set; }
        public Route route { get; set; }
        [FirestoreProperty]
        public float liters { get; set; }
        [FirestoreProperty]
        public decimal total { get; set; }
        [FirestoreProperty]
        public float current_Km { get; set; }
        [FirestoreProperty]
        public string station { get; set; }
        [FirestoreProperty]
        public decimal price { get; set; }
        public Trip trip { get; set; }
    }
}
