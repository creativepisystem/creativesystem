using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules.CustomConvert
{
    class CustomDriverConvert : IFirestoreConverter<Driver>
    {
        public Driver FromFirestore(object value)
        {
            return new DriverService().FindOne(Convert.ToString(value));
        }

        public object ToFirestore(Driver value) => value.Id;
    }
}
