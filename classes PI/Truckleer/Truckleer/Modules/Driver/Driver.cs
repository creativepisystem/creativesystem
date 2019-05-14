using Google.Cloud.Firestore;
using System;

namespace Truckleer.Modules
{
    [FirestoreData]
    class Driver : IModule
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
        public string cnh_number { get; set; }
        [FirestoreProperty]
        public DateTime birth_date { get; set; }
        [FirestoreProperty]
        public string phone { get; set; }
        [FirestoreProperty]
        public string email { get; set; }
        [FirestoreProperty]
        public DateTime cnh_expiration { get; set; }
        [FirestoreProperty]
        public string photo { get; set; }
        [FirestoreProperty]
        public string obs { get; set; }
        public User user { get; set; }

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
