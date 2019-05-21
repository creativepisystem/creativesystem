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
            TripService = new TripService();
            RouteService = new RouteService();
        }

        public string id { get; set; }
        [FirestoreProperty]
        public DateTime date { get; set; }
        public Driver driver { get; set; }
        public Vehicle vehicle { get; set; }
        public Route route { get; set; }
        [FirestoreProperty]
        public float liters { get; set; }
        [FirestoreProperty]
        public float total { get; set; }
        [FirestoreProperty]
        public float current_Km { get; set; }
        [FirestoreProperty]
        public string station { get; set; }
        [FirestoreProperty]
        public float price { get; set; }
        public Trip trip { get; set; }

        public Message IsValid()
        {
            if (date == null || date > new DateTime())
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A data é inválida!"
                };
            
            if (total < 0 )
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O total é inválido!"
                };
            if (current_Km <1)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O km é inválido!"
                };
            if (station == null || station.Length < 2 || station.Length > 30)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O posto deve conter entre 2 e 30 caracteres!"
                };
            if (price < 0 || price> 10)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O preço é inválido!"
                };
            if (trip == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A Viagem é obrigatória!"
                };
            if (driver == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O Motorista é obrigatório!"
                };
            if (vehicle == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O Veículo é obrigatório!"
                };
            if (liters < 0 || liters > vehicle.tank_capacity)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "Quantidade litros inválido!"
                };
            if (route != null)
            {
                if (RouteService.FindOne(route.id) == null)
                {
                    return new Message()
                    {
                        Type = MessageType.ERROR,
                        MessageText = "A rota é inválida!"
                    };
                }
            }
            if (DriverService.FindOne(driver.id) == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O Motorista é inválido!"
                };
            if (VehicleService.FindOne(vehicle.id) == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O veículo é inválido!"
                };
            if (TripService.FindOne(trip.id) == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A viagem é inválida!"
                };

            return new Message()
            {
                Type = MessageType.VALID,
                MessageText = "O abstecimento é válido!"
            };
        }

        public dynamic ToObject()
        {
            dynamic us = new ExpandoObject();

            if (date != null)
                us.date = date;
            if (liters < 0)
                us.liters = liters;
            if (total < 0)
                us.total = total;
            if (current_Km < 0)
                us.current_Km = current_Km;
            if (station != null)
                us.station = station;
            if (price < 0)
                us.price = price;
            if (trip != null)
                us.trip = trip.id;
            if (driver != null)
                us.driver = driver.id;
            if (vehicle != null)
                us.vehicle = vehicle.id;
            if (route != null)
                us.route = route.id;
            
            return us;
        }
    }
}
