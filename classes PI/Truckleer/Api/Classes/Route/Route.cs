using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Api.Classes
{
    [FirestoreData]
    class Route
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
