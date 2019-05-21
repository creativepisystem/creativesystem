using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truckleer.Modules
{
    [FirestoreData]
    public class Route:IModule
    {
        //Constructor
        public Route()
        {
        }

        //Atributes
        public string Id { get; set; }
        [FirestoreProperty("origin")]
        public string Origin { get; set; }
        [FirestoreProperty("destination")]
        public string Destination { get; set; }
        [FirestoreProperty("stops")]
        public List <string> Stops { get; set; }

        public Message IsValid()
        {
            //Check if has a origin and the length
            if (Origin == null || Origin.Length < 2 || Origin.Length > 100)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A origem deve conter no mínimo 2 e no máximo 100 letras!"
                };
            //Check if has a destination and the length
            if (Destination == null || Destination.Length < 2 || Destination.Length > 100)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O destino deve conter no mínimo 2 e no máximo 100 letras!"
                };
            if(Stops != null)
                foreach(string city in Stops)
                {
                    if(city == null || city.Length < 2 || city.Length > 100)
                    {
                        return new Message()
                        {
                            Type = MessageType.ERROR,
                            MessageText = $"Erro na cidade {city},a nome da cidade deve conter no mínimo 2 e no máximo 100 letras!"
                        };
                    }
                }

            //Return a valid message
            return new Message()
            {
                Type = MessageType.VALID,
                MessageText = "O rota é válido!"
            };

        }
    }
}
