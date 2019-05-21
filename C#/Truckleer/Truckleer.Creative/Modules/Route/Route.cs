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
        public string id { get; set; }
        [FirestoreProperty]
        public string origin { get; set; }
        [FirestoreProperty]
        public string destination { get; set; }
        [FirestoreProperty]
        public List <string> stops { get; set; }

        //Convert route to dynamic object
        public dynamic ToObject()
        {
            //Initializate us
            dynamic us = new ExpandoObject();

            //verify properties and set in dynamic object
            if (origin != null)
                us.origin = origin;
            if (stops != null)
                us.stops = stops;
            if (destination != null)
                us.destination = destination;
            //return us
            return us;
        }
        public Message IsValid()
        {
            //Check if has a origin and the length
            if (origin == null || origin.Length < 2 || origin.Length > 100)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A origem deve conter no mínimo 2 e no máximo 100 letras!"
                };
            //Check if has a destination and the length
            if (destination == null || destination.Length < 2 || destination.Length > 100)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O destino deve conter no mínimo 2 e no máximo 100 letras!"
                };
            if(stops != null)
                foreach(string city in stops)
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
