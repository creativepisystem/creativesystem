using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Truckleer.Modules
{
    [FirestoreData]
    class Trip : IModule
    {
        public Trip()
        {
        }

        private string id { get; set; }
        [FirestoreProperty]
        private DateTime date { get; set; }
        [FirestoreProperty]
        private string name { get; set; }
        private Route route { get; set; }
        private Driver driver { get; set; }
        [FirestoreProperty]
        private bool status { get; set; }
        private Vehicle vehicle { get; set; }

        public Message IsValid()
        {
            throw new NotImplementedException();
        }

        public dynamic ToObject()
        {
            throw new NotImplementedException();
        }
    }
}
