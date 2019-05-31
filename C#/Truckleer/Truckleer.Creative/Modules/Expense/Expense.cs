using Google.Cloud.Firestore;
using System;
using Truckleer.Modules.CustomConvert;

namespace Truckleer.Modules
{
    [FirestoreData]
    public class Expense : IModule
    {
        public Expense()
        {
            Value = -1;
        }

        public string Id { get; set; }
        [FirestoreProperty(Name = "date", ConverterType = typeof(CustomDateTimeConvert))]
        public DateTime Date { get; set; }
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
            if(Type == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro! O tipo deve Conter de 2 a 30 caracteres!"
                };

            if (Type.Length < 2 || Type.Length > 30)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro! O tipo deve Conter de 2 a 30 caracteres!"
                };
            if (Date == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro! Data incorreta!"
                };

            if (Date > DateTime.Now)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro! Data incorreta!"
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
        public bool FindById(Expense expense)
        {
            return Id == expense.Id;
        }
    }
}
