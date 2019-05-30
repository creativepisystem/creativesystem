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
            if (Type.Length < 2 || Type.Length > 30)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro! O tipo deve Conter de 2 a 30 caracteres!"
                };
            if (Value < 0)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro! O valor não pode ser negativo!"
                };
            if (Trip == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A viagem é obrigatória!"
                };
            if (Driver == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O motorista é obrigatório!"
                };
            if (Obs != null)
                if(Obs.Length< 2 && Obs.Length > 100)
                    return new Message()
                    {
                        Type = MessageType.ERROR,
                        MessageText = "A Observação de conter de 2 a 100 caracteres"
                    };
            return new Message()
            {
                Type = MessageType.VALID,
                MessageText = "Despesa é valida"
            };
        }
    }
}
