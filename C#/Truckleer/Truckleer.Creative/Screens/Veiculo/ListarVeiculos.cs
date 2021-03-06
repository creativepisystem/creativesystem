﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Creative.Screens.Veiculo;
using Truckleer.Modules;
using Truckleer.Creative.Screens.CustomEvent;

namespace Truckleer.Creative
{
    public partial class ListarVeiculos : UserControl
    {
        public ChangeScreenEvent<List<Vehicle>> ChangeScreenEvent { get; set; }
        private VehicleService vehicleService;
        private List<Vehicle> vehicles = new List<Vehicle>();

        public ListarVeiculos()
        {
            InitializeComponent();
            vehicleService = new VehicleService();
        }

        private void ListarVeiculos_Load_1(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            vehicleListWorker.RunWorkerAsync();
        }

        public void UpdateList()
        {
            ProgressBar.Visible = true;

            RemoveVehicleList();

            vehicleListWorker.RunWorkerAsync();
        }

        bool isCollapsed = false;
        private void Filtro_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                filter.Height += 10;
                if(filter.Size.Height == filter.MaximumSize.Height)
                {
                    filtro.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                filter.Height -= 10;
                if(filter.Size.Height == filter.MinimumSize.Height)
                {
                    filtro.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            filtro.Start();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            vehicleListWorker.RunWorkerAsync();
        }

        private void FilterVehicle(object sender, DoWorkEventArgs e)
        {
            e.Result = vehicleService.FindAll();
            for (int i = 0; i <= 100; i++)
                vehicleListWorker.ReportProgress(i);
        }

        private void FilterVehicleProgress(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void FilterVehicleFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar.Visible = false;
            vehicles = (List<Vehicle>)e.Result;
            FlowVehiclePanel.Controls.Clear();
            for (int i = 0; i < vehicles.Count; i++)
                FlowVehiclePanel.Controls.Add(new CustomVehicleList(i, vehicles[i]));
        }

        private void RemoveVehicleList()
        {
            for (int i = FlowVehiclePanel.Controls.Count - 1; i > -1; i--)
            {
                if (FlowVehiclePanel.Controls[i].GetType() == typeof(CustomVehicleList))
                {
                    FlowVehiclePanel.Controls.RemoveAt(i);
                }
            }
        }
    }
}
