﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;
using Truckleer.Creative.Screens.CustomEvent;

namespace Truckleer.Creative.Screens.Viagem
{
    public partial class ListarViagens : UserControl
    {
        public ChangeScreenEvent<List<Trip>> ChangeScreenEvent { get; set; }
        private TripService tripService;
        private List<Trip> trips = new List<Trip>();
        
        public ListarViagens()
        {
            InitializeComponent();
            tripService = new TripService();
        }

        public void UpdateList()
        {
            ProgressBar.Visible = true;

            RemoveTripList();

            tripListWorker.RunWorkerAsync();
        }

        private void ButtonCadastro_Click(object sender, EventArgs e)
        {
            tripListWorker.RunWorkerAsync();
        }

        private void ListarViagens_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            tripListWorker.RunWorkerAsync();
        }

        private void FilterTrip(object sender, DoWorkEventArgs e)
        {
            e.Result = tripService.FindAll();
        }

        private void FilterTripFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar.Visible = false;
            trips = (List<Trip>)e.Result;
            FlowTrip.Controls.Clear();
            for (int i = 0; i < trips.Count; i++)
                FlowTrip.Controls.Add(new CustomTripList(i, trips[i]));
        }

        private void RemoveTripList()
        {
            for (int i = FlowTrip.Controls.Count - 1; i > -1; i--)
            {
                if (FlowTrip.Controls[i].GetType() == typeof(CustomTripList))
                {
                    FlowTrip.Controls.RemoveAt(i);
                }
            }
        }
    }
}
