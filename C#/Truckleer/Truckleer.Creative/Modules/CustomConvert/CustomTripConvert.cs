using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules.CustomConvert
{
    class CustomTripConvert : IFirestoreConverter<Trip>
    {
        public Trip FromFirestore(object value)
        {
            return new TripService().FindOne(Convert.ToString(value));
        }

        public object ToFirestore(Trip value) => value.Id;
    }
}