using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    public static class DateUtil
    {
        public static long DateTimeToTimeStamp(DateTime? ts)
        { 
            if (!ts.HasValue) return ((DateTimeOffset)DateTime.Now).ToUnixTimeMilliseconds();
            else return ((DateTimeOffset)ts.Value.ToLocalTime()).ToUnixTimeMilliseconds();
        }
        public static DateTime TimeStampToDateTime(long javaTimeStamp)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc).AddMilliseconds(javaTimeStamp).ToLocalTime();
        }
    }
}
