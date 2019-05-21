using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Truckleer.Modules.CustomConvert
{
    class CustomDateTimeConvert : IFirestoreConverter<DateTime>
    {
        public DateTime FromFirestore(object value) => DateUtil.TimeStampToDateTime((long) value);
        public object ToFirestore(DateTime value) => DateUtil.DateTimeToTimeStamp(value);
    }
}
