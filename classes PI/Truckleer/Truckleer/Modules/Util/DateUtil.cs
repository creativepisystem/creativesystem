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
    }
}
