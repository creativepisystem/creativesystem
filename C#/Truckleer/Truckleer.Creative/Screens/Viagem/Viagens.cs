using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;

namespace Truckleer.Creative
{
    public partial class Viagens : UserControl
    {
        private DriverService driverService;
        private TripService tripService;
        private VehicleService vehicleService;
        private RouteService routeService;
        private List<Route> routes;
        private List<Driver> drivers;
        private List<Vehicle> vehicles;
        public Viagens()
        {
            InitializeComponent();
            routeService = new RouteService();
            driverService = new DriverService();
            tripService = new TripService();
            vehicleService = new VehicleService();
        }

        private void Viagens_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            driverWorker.RunWorkerAsync();
            routeWorker.RunWorkerAsync();
            vehicleWorker.RunWorkerAsync();
        }

        private void SaveTrip(object sender, DoWorkEventArgs e)
        {

        }

        private void SaveTripFinish(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void GetVehicles(object sender, DoWorkEventArgs e)
        {
            e.Result = vehicleService.FindAll();
        }
        private void GetVehiclesFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            vehicles = (List<Vehicle>)e.Result;
            vehicles.ForEach((vehicle) =>
            {
                BoxVehicle.Items.Add($"{vehicle.License_plate}");
            });
        }

        private void GetRoutes(object sender, DoWorkEventArgs e)
        {
            e.Result = routeService.FindAll();
        }
        private void GetRoutesFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            routes = (List<Route>)e.Result;
            routes.ForEach((route) =>
            {
                BoxRoute.Items.Add($"{route.Origin}-{route.Destination}");
            });
        }

        private void GetDrivers(object sender, DoWorkEventArgs e)
        {
            e.Result = driverService.FindAll();
        }

        private void GetDriversFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            drivers = (List<Driver>)e.Result;
            drivers.ForEach((driver) =>
            {
                BoxDriver.Items.Add($"{driver.Name}");
            });
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

        }
    }
}
