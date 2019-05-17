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

        public string id { get; set; }
        [FirestoreProperty]
        public DateTime date { get; set; }
        [FirestoreProperty]
        public string name { get; set; }
        public Route route { get; set; }
        public Driver driver { get; set; }
        [FirestoreProperty]
        public TripStatus status { get; set; }
        public Vehicle vehicle { get; set; }

        public Message IsValid()
        {
            if (date == null || date < new DateTime() )
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A data é inválida!"
                };
            if (name == null || name.Length <2 || name.Length> 30)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "A nome é invalida!O nome deve conter entre 2 e 30 caracteres!"
                };
            if (!(status.GetType() == typeof(TripStatus)))
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O status da viagem é inválido!"
                };

            if (driver == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O Motorista é obrigatótio!"
                };
            if (vehicle == null)
                return new Message()
                {
                    Type = MessageType.ERROR,
                    MessageText = "O Veículo é obrigatório!"
                };
            if (route != null)
            {
                if(RouteService.FindOne(route.Id) == null)
                {
                    return new Message()
                    {
                        Type = MessageType.ERROR,
                        MessageText = "A rota é inválida!"
                    };
                }
            }
            if(DriverService.FindOne(driver.Id) == null)
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
            return new Message()
            {
                Type = MessageType.VALID,
                MessageText = "A viagem é válida!"
            };
        }

        public dynamic ToObject()
        {
            //Initializate us
            dynamic us = new ExpandoObject();
            if (date != null)
                us.date = date;
            if (name != null)
                us.name = name;
            if (route != null)
                us.route = route.Id;
            if (driver != null)
                us.driver = driver.Id;
            if (status.GetType() == typeof(TripStatus))
                us.status = status;
            if (vehicle != null)
                us.vehicle = vehicle.id;
            return us;
        }
    }
}
