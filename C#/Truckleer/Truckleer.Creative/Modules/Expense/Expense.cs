using Google.Cloud.Firestore;
using Truckleer.Modules.CustomConvert;

namespace Truckleer.Modules
{
    [FirestoreData]
    public class Expense : IModule
    {
        public Expense()
        {

        }

        public string Id { get; set; }
        [FirestoreProperty("type")]
        public string Type { get; set; }
        [FirestoreProperty(Name = "driver", ConverterType = typeof(CustomDriverConvert))]
        public Driver Driver { get; set; }
        [FirestoreProperty(Name = "travel", ConverterType = typeof(CustomTripConvert))]
        public Trip Trip { get; set; }
        [FirestoreProperty(Name = "value", ConverterType = typeof(CustomFloatConvert))]
        public float Value { get; set; }
        [FirestoreProperty("obs")]
        public string Obs { get; set; }

        public Message IsValid()
        {
            throw new System.NotImplementedException();
        }
    }
}
