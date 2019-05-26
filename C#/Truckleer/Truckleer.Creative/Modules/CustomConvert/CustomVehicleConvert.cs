using Google.Cloud.Firestore;
using System;

namespace Truckleer.Modules.CustomConvert
{
    class CustomVehicleConvert : IFirestoreConverter<Vehicle>
    {
        public Vehicle FromFirestore(object value)
        {
            return new VehicleService().FindOne(Convert.ToString(value));
        }

        public object ToFirestore(Vehicle value) => value.Id;
    }
}