using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules.CustomConvert
{
    class CustomRouteConvert : IFirestoreConverter<Route>
    {
        public Route FromFirestore(object value)
        {
            if (value == null)
                return new Route() {
                    Origin ="",
                    Destination = "",
                    Stops = new List<string>()
                };
            return new RouteService().FindOne(Convert.ToString(value));
        }

        public object ToFirestore(Route value) {
            if (value == null)
                return FieldValue.Delete;
            return value.Id;

        }
    }
}
