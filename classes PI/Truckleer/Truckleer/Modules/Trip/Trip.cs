using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truckleer.Modules.CustomConvert;

namespace Truckleer.Modules
{
    [FirestoreData]
    public class Trip : IModule
    {
        readonly DriverService DriverService;
        readonly VehicleService VehicleService;
        readonly RouteService RouteService;
        public Trip()
        {
            DriverService = new DriverService();
            VehicleService = new VehicleService();
            RouteService = new RouteService();
        }

        public string Id { get; set; }
        [FirestoreProperty(Name = "date", ConverterType = typeof(CustomDateTimeConvert))]
        public DateTime Date { get; set; }
        [FirestoreProperty("name")]
        public string Name { get; set; }
        [FirestoreProperty(Name = "route", ConverterType = typeof(CustomRouteConvert))]
        public Route Route { get; set; }
        [FirestoreProperty(Name = "driver", ConverterType = typeof(CustomDriverConvert))]
        public Driver Driver { get; set; }
        [FirestoreProperty(Name ="status", ConverterType = typeof(CustomTripStatusConvert))]
        public TripStatus Status { get; set; }
        [FirestoreProperty(Name = "vehicle", ConverterType = typeof(CustomVehicleConvert))]
        public Vehicle Vehicle { get; set; }

        public Message IsValid()
        {
            if (Date == null || Date < new DateTime() )
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A data é inválida!"
                };
            if (Name == null || Name.Length <2 || Name.Length> 30)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A nome é invalida!O nome deve conter entre 2 e 30 caracteres!"
                };
            if (!(Status.GetType() == typeof(TripStatus)))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O status da viagem é inválido!"
                };

            if (Driver == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O Motorista é obrigatótio!"
                };
            if (Vehicle == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O Veículo é obrigatório!"
                };
            if (Route != null)
            {
                if(RouteService.FindOne(Route.Id) == null)
                {
                    return new Message()
                    {
                        Type = MessageType.ERROR,
                        MessageText = "A rota é inválida!"
                    };
                }
            }
            if(DriverService.FindOne(Driver.Id) == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O Motorista é inválido!"
                };
            if (VehicleService.FindOne(Vehicle.Id) == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O veículo é inválido!"
                };
            return new Message()
            {
                Type = MessageType.VALID,
                MessageText = "A viagem é válida!"
            };
        }
    }
}
