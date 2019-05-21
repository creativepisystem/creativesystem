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
        public Vehicle()
        {
        }

        public string id { get; set; }
        [FirestoreProperty]
        public string license_plate { get; set; }
        [FirestoreProperty]
        public string model { get; set; }
        [FirestoreProperty]
        public string brand { get; set; }
        [FirestoreProperty]
        public int tank_capacity { get; set; }
        [FirestoreProperty]
        public int fab_Year { get; set; }
        [FirestoreProperty]
        public int mod_Year { get; set; }
        [FirestoreProperty]
        public VehicleColor color { get; set; }
        [FirestoreProperty]
        public string renavam { get; set; }
        [FirestoreProperty]
        public string chassi { get; set; }

        public Message IsValid()
        {
            if (license_plate == null || license_plate.Length < 7 || license_plate.Length > 8)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Placa do veiculo Incorreta!a plca deve conter entre 7 e 8 caracteres"
                };
            if (model == null || model.Length < 3 || model.Length > 20)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O modelo deve conter entre 3 e 20 caracteres"
                };
            if (brand == null || model.Length < 3 || model.Length > 20)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A marca deve conter entre 3 e 20 caracteres"
                };
            if (tank_capacity < 1 || tank_capacity > 10000)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Capacidade do tanque incorreta"
                };
            if (fab_Year < 1900 || fab_Year > new DateTime().Year)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Ano de fabricação é inválido!"
                };
            if (mod_Year < 1900 || mod_Year > new DateTime().Year)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Ano do Modelo é inválido!"
                };
            if (renavam != null && renavam.Length != 11)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Renavam inválido!"
                };
            if (chassi != null && renavam.Length != 17)
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
            if (license_plate != null)
                us.license_plate = license_plate;
            if (model != null)
                us.model = model;
            if (brand != null)
                us.brand = brand;
            if (tank_capacity >0)
                us.tank_capacity = tank_capacity;
            if (fab_Year >0)
                us.fab_Year = fab_Year;
            if (mod_Year > 0)
                us.mod_Year = mod_Year;
            if (color >0)
                us.color = color;
            if (renavam != null)
                us.renavam = renavam;
            if (chassi != null)
                us.chassi = chassi;
            return us;
        }
    }

}
