using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Truckleer.Modules;
using Message = Truckleer.Modules.Message;

namespace Truckleer.Creative
{
    public partial class Abastecimento : UserControl
    {
        private Supply Supply;
        private RouteService routeService;
        private DriverService driverService;
        private TripService tripService;
        private VehicleService vehicleService;
        private SupplyService supplyService;
        private List<Route> routes;
        private List<Driver> drivers;
        private List<Trip> trips;
        private List<Vehicle> vehicles;
        

        public Abastecimento(Supply supply)
        {
            if(supply != null)
            {
                Supply = supply;
            }
            else
            {
                Supply = new Supply();
            }
            routeService = new RouteService();
            driverService = new DriverService();
            tripService = new TripService();
            vehicleService = new VehicleService();
            supplyService = new SupplyService();
            InitializeComponent();
           
        }

        private void Abastecimento_Load(object sender, EventArgs e)
        {
            if(Supply == null)
                ClearFields();
            this.Dock = DockStyle.Fill;
            driverWorker.RunWorkerAsync();
            routeWorker.RunWorkerAsync();
            vehicleWorker.RunWorkerAsync();
            tripWorker.RunWorkerAsync();
        }
        
        //Call Dashboard
        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ButtonSave.Enabled = false;
            Supply.Date = DateSupply.Value;
            if(BoxVehicle.SelectedIndex> -1)
                Supply.Vehicle = vehicles[BoxVehicle.SelectedIndex];
            if (BoxVehicle.SelectedIndex > -1)
                Supply.Trip = trips[BoxTrip.SelectedIndex];
            if (BoxVehicle.SelectedIndex > -1)
                Supply.Route = routes[BoxRoute.SelectedIndex];
            if (BoxVehicle.SelectedIndex > -1)
                Supply.Driver = drivers[BoxDriver.SelectedIndex];
            if(!string.IsNullOrEmpty(TextLiters.Text))
                Supply.Liters = Convert.ToSingle(TextLiters.Text);

            if (!string.IsNullOrEmpty(TextKm.Text))
                Supply.Current_Km = Convert.ToSingle(TextKm.Text);

            if (!string.IsNullOrEmpty(TextPrice.Text))
                Supply.Price = Convert.ToSingle(TextPrice.Text);

            if (!string.IsNullOrEmpty(TextLiters.Text) && !string.IsNullOrEmpty(TextPrice.Text))
                Supply.Total = Supply.Liters * Supply.Price;

            if (!string.IsNullOrEmpty(TextStation.Text))
                Supply.Station = TextStation.Text;

            Message message = Supply.IsValid();
            if(message.Type == MessageType.ERROR)
            {
                MessageBox.Show(message.MessageText);
                ButtonSave.Enabled = true;
                Cursor = Cursors.Default;
            }
            else
            {
                
                supplyWorker.RunWorkerAsync();
               
            }
            
        }

        private void BoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void GetDrivers(object sender, DoWorkEventArgs e)
        {
            e.Result = driverService.FindAll();
        }

        private void LitersTextChange(object sender, EventArgs e) {
            TextLiters.Text = RemoveLetters(TextLiters.Text);
            if (!string.IsNullOrEmpty(TextLiters.Text) && !string.IsNullOrEmpty(TextPrice.Text))
                LabelResult.Text = $"R$  {string.Format("{0:0.00}", Convert.ToSingle(TextLiters.Text) * Convert.ToSingle(TextPrice.Text))}";
            else
                LabelResult.Text = "R$  0,00";
        }
        private void KmTextChange(object sender, EventArgs e)
        {

            TextKm.Text = RemoveLetters(TextKm.Text);
            TextKm.Select(TextKm.Text.Length, 0);
        }
        private void PriceTextChange(object sender, EventArgs e)
        {
            TextPrice.Text = RemoveLetters(TextPrice.Text);
            TextPrice.Select(TextPrice.Text.Length, 0);
            if (!string.IsNullOrEmpty(TextLiters.Text) && !string.IsNullOrEmpty(TextPrice.Text))
                LabelResult.Text = $"R$  {string.Format("{0:0.00}", Convert.ToSingle(TextLiters.Text) * Convert.ToSingle(TextPrice.Text))}";
            else
                LabelResult.Text = "R$  0,00";
        }
        private void GetDriversFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            drivers = (List<Driver>)e.Result;
            drivers.ForEach((driver) =>
            {
                BoxDriver.Items.Add($"{driver.Name}");
            });
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
        private void GetTrips(object sender, DoWorkEventArgs e)
        {
            e.Result = tripService.FindAll();
        }
        private void GetTripsFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            trips = (List<Trip>)e.Result;
            trips.ForEach((trip) =>
            {
                BoxTrip.Items.Add($"{trip.Name}");
            });
        }

        private void SaveSupply(object sender, DoWorkEventArgs e)
        {
            e.Result = supplyService.Save(Supply);
        }
        private void SaveSupplyFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            bool isSave = (bool)e.Result;
            if (isSave)
            {
                MessageBox.Show("Abastecimento Salvo com Sucesso");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Erro ao Salvar o abastecimento");
            }
            ButtonSave.Enabled = true;
            Cursor = Cursors.Default;
        }
        
        private string RemoveLetters(string text)
        {
            int cont = 0;
            foreach(char c in text)
            {
                if (!char.IsDigit(c) && c != '.' && c != ',')
                {
                    text = text.Remove(text.IndexOf(c));
                }
                if(c == ',')
                {
                    cont++;
                }
            }
            if (cont>0)
            {
                text = text.Replace(".", "");
                if (cont > 1)
                    text = text.Remove(text.LastIndexOf(','));

            }
            else
            {
                text = text.Replace(".", ",");
            }
            return text;
        }
        private void ClearFields()
        {
            DateSupply.Value = DateTime.Now;
            BoxVehicle.SelectedIndex = -1;
            BoxTrip.SelectedIndex = -1;
            BoxRoute.SelectedIndex = -1;
            BoxDriver.SelectedIndex = -1;
            TextLiters.Text = "";
            TextKm.Text = "";
            TextPrice.Text = "";
            TextStation.Text = "";
            LabelResult.Text = "";
        }
    }
}
