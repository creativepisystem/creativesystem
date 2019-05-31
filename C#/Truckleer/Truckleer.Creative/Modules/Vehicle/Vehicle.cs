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

        public string Id { get; set; }
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
        public VehicleColor? Color { get; set; }
        [FirestoreProperty("renavam")]
        public string Renavam { get; set; }
        [FirestoreProperty("chassi")]
        public string Chassi { get; set; }

        public Message IsValid()
        {
            if (License_plate == null )
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Placa do veiculo Incorreta!a plca deve conter entre 6 e 8 caracteres"
                };
            if (License_plate.Length < 6 || License_plate.Length > 8)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Placa do veiculo Incorreta!a plca deve conter entre 6 e 8 caracteres"
                };
            if (Model == null )
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O modelo deve conter entre 3 e 20 caracteres"
                };
            if (Model.Length < 3 || Model.Length > 20)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O modelo deve conter entre 3 e 20 caracteres"
                };
            if (Brand == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A marca deve conter entre 3 e 20 caracteres"
                };
            if (Model.Length < 3 || Model.Length > 20)
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
            if (Fab_Year < 1900 || Fab_Year > DateTime.Now.Year)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Ano de fabricação é inválido!"
                };
            if (Mod_Year < 1900 || Mod_Year > DateTime.Now.Year)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Ano do Modelo é inválido!"
                };
            if (Renavam != null)
                if(Renavam.Length != 11)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Renavam inválido!"
                };
            if (Chassi != null)
                if (Chassi.Length != 17)
                return new Message()
                {
                    Type = MessageType.ERROR,
                        MessageText = "Erro!Chassi inválido!"
                };
            
            if(Color == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Erro!Cor inválida!"
                };
            return new Message()
            {
                Type = MessageType.VALID,
                MessageText = "O veículo é valido!"
            };
        }
        public bool FindById(Vehicle vehicle)
        {
            return Id == vehicle.Id;
        }
    }

}
