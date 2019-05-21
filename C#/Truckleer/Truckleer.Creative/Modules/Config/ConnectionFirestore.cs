using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    class ConnectionFirestore
    {
        public FirestoreDb Db { get; }
        public ConnectionFirestore()
        {
            Db = FirestoreDb.Create("creative-external-supply");
        }
    }
}
