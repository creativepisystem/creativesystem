using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Truckleer.Modules;
namespace Truckleer
{
    class Program
    {
        static void Main(string[] args)
        {
            UserService userService = new UserService();
            RouteService routeService = new RouteService();
            DriverService driverService = new DriverService();
            VehicleService vehicleService = new VehicleService();
            TripService tripService = new TripService();
            SupplyService supplyService = new SupplyService();

            userService.FindAll();
            routeService.FindAll();
            driverService.FindAll();
            vehicleService.FindAll();
            tripService.FindAll();
            supplyService.FindAll();

            Console.ReadKey();
        }
    }
}
