using Google.Cloud.Firestore;

namespace Truckleer.Modules.CustomConvert
{
    class CustomTripStatusConvert : IFirestoreConverter<TripStatus>
    {
        public TripStatus FromFirestore(object value)
        {
            switch (value)
            {
                case "Aberta":
                    return TripStatus.ABERTA;
                case "Concluida":
                    return TripStatus.FECHADA;
                default:
                    return TripStatus.FECHADA;
            }
        }

        public object ToFirestore(TripStatus value)
        {
            switch (value) {
                case TripStatus.ABERTA:
                    return "Aberta";
                case TripStatus.FECHADA:
                    return "Concluida";
                default:
                    return TripStatus.FECHADA;
            }
        }
    }
}
