using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Truckleer.Modules;

namespace Truckleer.Creative
{
    public partial class Dashboard : UserControl
    {
        private TripService tripService;
        private List<Trip> trips = new List<Trip>();

        public Dashboard()
        {
            InitializeComponent();
            tripService = new TripService();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            tripWorker.RunWorkerAsync();
        }

        private void GetTrip(object sender, DoWorkEventArgs e)
        {
            e.Result = tripService.FindAll();
        }

        private void GetTripFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            trips = (List<Trip>)e.Result;
        }
    }
}
