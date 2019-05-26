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
    public class Supply : IModule
    {
        readonly DriverService DriverService;
        readonly VehicleService VehicleService;
        readonly RouteService RouteService;
        readonly TripService TripService;
        public Supply()
        {
            DriverService = new DriverService();
            VehicleService = new VehicleService();
            RouteService = new RouteService();
            TripService = new TripService();
            Liters = -1;
        }
        
        public string Id{ get; set; }

        [FirestoreProperty(Name = "date", ConverterType = typeof(CustomDateTimeConvert))]
        public DateTime Date { get; set; }
        [FirestoreProperty(Name = "driver", ConverterType = typeof(CustomDriverConvert))]
        public Driver Driver { get; set; }
        [FirestoreProperty(Name = "vehicle", ConverterType = typeof(CustomVehicleConvert))]
        public Vehicle Vehicle { get; set; }
        [FirestoreProperty(Name = "route", ConverterType = typeof(CustomRouteConvert))]
        public Route Route { get; set; }
        [FirestoreProperty(Name = "liters", ConverterType = typeof(CustomFloatConvert))]
        public float Liters { get; set; }
        [FirestoreProperty(Name = "total", ConverterType = typeof(CustomFloatConvert))]
        public float Total { get; set; }
        [FirestoreProperty(Name = "current_km", ConverterType = typeof(CustomFloatConvert))]
        public float Current_Km { get; set; }
        [FirestoreProperty("station")]
        public string Station { get; set; }
        [FirestoreProperty(Name = "price", ConverterType = typeof(CustomFloatConvert))]
        public float Price { get; set; }
        [FirestoreProperty(Name = "travel", ConverterType = typeof(CustomTripConvert))]
        public Trip Trip { get; set; }

        public Message IsValid()
        {
            if (Date == null || Date >DateTime.Now)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A data é inválida!"
                };
            
            if (Total <= 0 )
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O total é inválido!"
                };
            if (Current_Km <1)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O km é inválido!"
                };
            if (Station == null || Station.Length < 2 || Station.Length > 30)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O posto deve conter entre 2 e 30 caracteres!"
                };
            if (Price <= 0 || Price> 10)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O preço é inválido!"
                };
            if (Trip == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A Viagem é obrigatória!"
                };
            if (Driver == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O Motorista é obrigatório!"
                };
            if (Vehicle == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O Veículo é obrigatório!"
                };
            if (Liters <= 0 || Liters > Vehicle.Tank_capacity)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Quantidade litros inválido!"
                };
            //if (Route != null)
            //{
            //    if (RouteService.FindOne(Route.Id) == null)
            //    {
            //        return new Message()
            //        {
            //            Type = MessageType.ERROR,
            //            MessageText = "A rota é inválida!"
            //        };
            //    }
            //}
            //if (DriverService.FindOne(Driver.Id) == null)
            //    return new Message()
            //    {
            //        Type = MessageType.ERROR,
            //        MessageText = "O Motorista é inválido!"
            //    };
            //if (VehicleService.FindOne(Vehicle.Id) == null)
            //    return new Message()
            //    {
            //        Type = MessageType.ERROR,
            //        MessageText = "O veículo é inválido!"
            //    };
            //if (TripService.FindOne(Trip.Id) == null)
            //    return new Message()
            //    {
            //        Type = MessageType.ERROR,
            //        MessageText = "A viagem é inválida!"
            //    };

            return new Message()
            {
                Type = MessageType.VALID,
                MessageText = "O abstecimento é válido!"
            };
        }

    }
}
