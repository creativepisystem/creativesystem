using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truckleer.Creative
{
    public partial class Truckleer : Form
    {
        Abastecimento supply = new Abastecimento();
        Dashboard dash = new Dashboard();
        Motorista driver = new Motorista();
        Veiculos vehicle = new Veiculos();
        Rotas route = new Rotas();
        Manutencao maintence = new Manutencao();
        Viagens trip = new Viagens();

        public Truckleer()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            truckleerContainer.Controls.Clear();
            truckleerContainer.Controls.Add(dash);
            dash.BringToFront();
        }

        private void btnSupply_Click(object sender, EventArgs e)
        {
            truckleerContainer.Controls.Clear();
            truckleerContainer.Controls.Add(supply);
            supply.BringToFront();
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            truckleerContainer.Controls.Clear();
            truckleerContainer.Controls.Add(driver);
            driver.BringToFront();
        }

        private void btnVehicle_Click(object sender, EventArgs e)
        {
            truckleerContainer.Controls.Clear();
            truckleerContainer.Controls.Add(vehicle);
            vehicle.BringToFront();
        }

        private void btnRoute_Click(object sender, EventArgs e)
        {
            truckleerContainer.Controls.Clear();
            truckleerContainer.Controls.Add(route);
            route.BringToFront();
        }

        private void btnMaintence_Click(object sender, EventArgs e)
        {
            truckleerContainer.Controls.Clear();
            truckleerContainer.Controls.Add(maintence);
            maintence.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            truckleerContainer.Controls.Clear();
            truckleerContainer.Controls.Add(trip);
            trip.BringToFront();
        }
    }
}
