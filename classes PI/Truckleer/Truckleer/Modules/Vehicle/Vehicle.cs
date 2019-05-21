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
    public class Vehicle : IModule
    {
        public Vehicle() { }

        public string id { get; set; }
        [FirestoreProperty("license_plate")]
        public string License_plate { get; set; }
        [FirestoreProperty("model")]
        public string Model { get; set; }
        [FirestoreProperty("brand")]
        public string Brand { get; set; }
        [FirestoreProperty("tank_capacity")]
        public int Tank_capacity { get; set; }
        [FirestoreProperty("fab_Year")]
        public int Fab_Year { get; set; }
        [FirestoreProperty("mod_Year")]
        public int Mod_Year { get; set; }
        [FirestoreProperty("color")]
        public VehicleColor Color { get; set; }
        [FirestoreProperty("renavam")]
        public string Renavam { get; set; }
        [FirestoreProperty("chassi")]
        public string Chassi { get; set; }

        public Message IsValid()
        {
            if (License_plate == null || License_plate.Length < 7 || License_plate.Length > 8)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Placa do veiculo Incorreta!a plca deve conter entre 7 e 8 caracteres"
                };
            if (Model == null || Model.Length < 3 || Model.Length > 20)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O modelo deve conter entre 3 e 20 caracteres"
                };
            if (Brand == null || Model.Length < 3 || Model.Length > 20)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A marca deve conter entre 3 e 20 caracteres"
                };
            if (Tank_capacity < 1 || Tank_capacity > 10000)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Capacidade do tanque incorreta"
                };
            if (Fab_Year < 1900 || Fab_Year > new DateTime().Year)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Ano de fabricação é inválido!"
                };
            if (Mod_Year < 1900 || Mod_Year > new DateTime().Year)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Ano do Modelo é inválido!"
                };
            if (Renavam != null && Renavam.Length != 11)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Renavam inválido!"
                };
            if (Chassi != null && Renavam.Length != 17)
                return new Message()
                {
                    Type = MessageType.ERROR,
                        MessageText = "Erro!Chassi inválido!"
                };

            return new Message()
            {
                Type = MessageType.VALID,
                MessageText = "O veículo é valido!"
            };
        }

        public dynamic ToObject()
        {
            dynamic us = new ExpandoObject();
            if (id != null)
                us.id = id;
            if (License_plate != null)
                us.license_plate = License_plate;
            if (Model != null)
                us.model = Model;
            if (Brand != null)
                us.brand = Brand;
            if (Tank_capacity >0)
                us.tank_capacity = Tank_capacity;
            if (Fab_Year >0)
                us.fab_Year = Fab_Year;
            if (Mod_Year > 0)
                us.mod_Year = Mod_Year;
            if (Color >0)
                us.color = Color;
            if (Renavam != null)
                us.renavam = Renavam;
            if (Chassi != null)
                us.chassi = Chassi;
            return us;
        }
    }

}
