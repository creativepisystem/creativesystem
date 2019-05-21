using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules.CustomConvert
{
    class CustomFloatConvert : IFirestoreConverter<float>
    {
        public float FromFirestore(object value)
        {
            if (value == null)
                return 0f;
            return Convert.ToSingle(value);
        }
        public object ToFirestore(float value) => value;
        
    }
}
