using Google.Cloud.Firestore;
using System;

namespace Truckleer.Modules.CustomConvert
{
    class CustomCnhTypeConvert : IFirestoreConverter<CnhType>
    {
        public CnhType FromFirestore(object value)
        {
            switch (Convert.ToString(value))
            {
                case "A":
                    return CnhType.A;
                case "B":
                    return CnhType.B;
                case "C":
                    return CnhType.C;
                case "D":
                    return CnhType.D;
                default :
                    return CnhType.E;
            }
        }

        public object ToFirestore(CnhType value)
        {
            switch (value)
            {
                case CnhType.A:
                    return "A";
                case CnhType.B:
                    return "B";
                case CnhType.C:
                    return "C";
                case CnhType.D:
                    return "D";
                default:
                    return "E";
            }
        }
    }
}
