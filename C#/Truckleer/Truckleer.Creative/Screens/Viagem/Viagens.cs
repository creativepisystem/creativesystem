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
using Message = Truckleer.Modules.Message;

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
        private Trip Trip;
        public Viagens()
        {
            InitializeComponent();
            routeService = new RouteService();
            driverService = new DriverService();
            tripService = new TripService();
            vehicleService = new VehicleService();
            Trip = new Trip();
        }

        private void Viagens_Load(object sender, EventArgs e)
        {
            ClearFields();
            this.Dock = DockStyle.Fill;
            driverWorker.RunWorkerAsync();
            routeWorker.RunWorkerAsync();
            vehicleWorker.RunWorkerAsync();
        }

        private void SaveTrip(object sender, DoWorkEventArgs e)
        {
            e.Result = tripService.Save(Trip);
        }

        private void SaveTripFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            bool isSave = (bool)e.Result;
            if (isSave)
            {
                MessageBox.Show("Viagem Salvo com Sucesso");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Erro ao Salvar o viagem");
            }
            ButtonSave.Enabled = true;
            Cursor = Cursors.Default;
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
            Cursor = Cursors.WaitCursor;
            ButtonSave.Enabled = false;
            Trip.Date = Date.Value;
            if (!string.IsNullOrEmpty(TxtName.Text))
                Trip.Name = TxtName.Text;
            if (BoxRoute.SelectedIndex > -1)
                Trip.Route = routes[BoxRoute.SelectedIndex];
            if (BoxDriver.SelectedIndex > -1)
                Trip.Driver = drivers[BoxDriver.SelectedIndex];
            if (BoxVehicle.SelectedIndex > -1)
                Trip.Vehicle = vehicles[BoxVehicle.SelectedIndex];
            Trip.Status = TripStatus.ABERTA;
            Message message = Trip.IsValid();
            if (message.Type == MessageType.ERROR)
            {
                Cursor = Cursors.Default;
                ButtonSave.Enabled = true;
                MessageBox.Show(message.MessageText);
            }
            else
            {
                tripWorker.RunWorkerAsync();
            }
        }
        private void ClearFields()
        {
            Date.Value = DateTime.Now;
            BoxDriver.Items.Clear();
            BoxRoute.Items.Clear();
            BoxVehicle.Items.Clear();
            TxtName.Name = "";
        }
    }
}
