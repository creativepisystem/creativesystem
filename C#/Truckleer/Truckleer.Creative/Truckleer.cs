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
            truckleerCallcontainer.Controls.Add(dash);
            dash.BringToFront();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    
        private void supplyTimer_Tick(object sender, EventArgs e)
        {
            bool supplyIsCollapsed = true;

            if (supplyIsCollapsed)
            {
                groupSupply.Height += 10;
                if(groupSupply.Size.Height == groupSupply.MaximumSize.Height)
                {
                    supplyTimer.Stop();
                    supplyIsCollapsed = false;
                }
            }
            else
            {
                groupSupply.Height -= 10;
                if(groupSupply.Size.Height == groupSupply.MinimumSize.Height)
                {
                    supplyTimer.Stop();
                    supplyIsCollapsed = true;
                }
            }
        }

        private void vehicleTimer_Tick(object sender, EventArgs e)
        {
            bool vehicleIsCollapsed = true;

            if (vehicleIsCollapsed)
            {
                groupVehicle.Height += 10;
                if (groupVehicle.Size.Height == groupVehicle.MaximumSize.Height)
                {
                    vehicleTimer.Stop();
                    vehicleIsCollapsed = false;
                }
            }
            else
            {
                groupVehicle.Height -= 10;
                if (groupVehicle.Size.Height == groupVehicle.MinimumSize.Height)
                {
                    vehicleTimer.Stop();
                    vehicleIsCollapsed = true;
                }
            }
        }

        private void driverTimer_Tick(object sender, EventArgs e)
        {
            bool driverIsCollapsed = true;

            if (driverIsCollapsed)
            {
                groupDriver.Height += 10;
                if (groupDriver.Size.Height == groupDriver.MaximumSize.Height)
                {
                    driverTimer.Stop();
                    driverIsCollapsed = false;
                }
            }
            else
            {
                groupDriver.Height -= 10;
                if (groupDriver.Size.Height == groupDriver.MinimumSize.Height)
                {
                    driverTimer.Stop();
                    driverIsCollapsed = true;
                }
            }
        }

        private void routeTimer_Tick(object sender, EventArgs e)
        {
            bool routeIsCollapsed = true;

            if (routeIsCollapsed)
            {
                groupRoute.Height += 10;
                if (groupRoute.Size.Height == groupRoute.MaximumSize.Height)
                {
                    routeTimer.Stop();
                    routeIsCollapsed = false;
                }
            }
            else
            {
                groupRoute.Height -= 10;
                if (groupRoute.Size.Height == groupRoute.MinimumSize.Height)
                {
                    routeTimer.Stop();
                    routeIsCollapsed = true;
                }
            }
        }

        private void maintenceTimer_Tick(object sender, EventArgs e)
        {
            bool maintenceIsCollapsed = true;

            if (maintenceIsCollapsed)
            {
                groupMaintence.Height += 10;
                if (groupMaintence.Size.Height == groupMaintence.MaximumSize.Height)
                {
                    maintenceTimer.Stop();
                    maintenceIsCollapsed = false;
                }
            }
            else
            {
                groupMaintence.Height -= 10;
                if (groupMaintence.Size.Height == groupMaintence.MinimumSize.Height)
                {
                    maintenceTimer.Stop();
                    maintenceIsCollapsed = true;
                }
            }
        }

        private void tripTimer_Tick(object sender, EventArgs e)
        {
            bool tripIsCollapsed = true;

            if (tripIsCollapsed)
            {
                groupTrip.Height += 10;
                if (groupTrip.Size.Height == groupTrip.MaximumSize.Height)
                {
                    tripTimer.Stop();
                    tripIsCollapsed = false;
                }
            }
            else
            {
                groupTrip.Height -= 10;
                if (groupTrip.Size.Height == groupTrip.MinimumSize.Height)
                {
                    tripTimer.Stop();
                    tripIsCollapsed = true;
                }
            }
        }

        private void btnAbastecimento_Click(object sender, EventArgs e)
        {
            supplyTimer.Start();

            //Close others panels
            groupVehicle.Size = groupVehicle.MinimumSize;
            groupDriver.Size = groupDriver.MinimumSize;
            groupRoute.Size = groupRoute.MinimumSize;
            groupMaintence.Size = groupMaintence.MinimumSize;
            groupTrip.Size = groupTrip.MinimumSize;
        }

        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            //Call the supply Panel
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(supply);
            supply.BringToFront();

            //Set - Unset Color
            btnAbastecer.BackColor = Color.FromArgb(25, 137, 186);
            btnDash.BackColor = Color.FromArgb(65,65,65);
            btnListAbastecimentos.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeVehicle.BackColor = Color.FromArgb(90, 90, 90);
            btnListVehicle.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeDriver.BackColor = Color.FromArgb(90, 90, 90);
            btnListDrivers.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeRoute.BackColor = Color.FromArgb(90, 90, 90);
            btnListRoutes.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeMaintence.BackColor = Color.FromArgb(90, 90, 90);
            btnListMaintence.BackColor = Color.FromArgb(90, 90, 90);
            btnAlertMaintence.BackColor = Color.FromArgb(90, 90, 90);


        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(dash);
            dash.BringToFront();

            //Close Other Panels
            groupSupply.Size = groupSupply.MinimumSize;
            groupVehicle.Size = groupVehicle.MinimumSize;
            groupDriver.Size = groupDriver.MinimumSize;
            groupRoute.Size = groupRoute.MinimumSize;
            groupMaintence.Size = groupMaintence.MinimumSize;
            groupTrip.Size = groupTrip.MinimumSize;

            //Set - Unset Color
            btnDash.BackColor = Color.FromArgb(25, 137, 186);
            btnAbastecer.BackColor = Color.FromArgb(90,90,90);
            btnListAbastecimentos.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeVehicle.BackColor = Color.FromArgb(90, 90, 90);
            btnListVehicle.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeDriver.BackColor = Color.FromArgb(90, 90, 90);
            btnListDrivers.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeRoute.BackColor = Color.FromArgb(90, 90, 90);
            btnListRoutes.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeMaintence.BackColor = Color.FromArgb(90, 90, 90);
            btnListMaintence.BackColor = Color.FromArgb(90, 90, 90);
            btnAlertMaintence.BackColor = Color.FromArgb(90, 90, 90);


        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            vehicleTimer.Start();

            //Close others panels
            groupSupply.Size = groupSupply.MinimumSize;
            groupDriver.Size = groupDriver.MinimumSize;
            groupRoute.Size = groupRoute.MinimumSize;
            groupMaintence.Size = groupMaintence.MinimumSize;
            groupTrip.Size = groupTrip.MinimumSize;
        }

        private void btnMakeVehicle_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(vehicle);
            vehicle.BringToFront();

            //Set - Unset Color
            btnMakeVehicle.BackColor = Color.FromArgb(25, 137, 186);
            btnAbastecer.BackColor = Color.FromArgb(90,90,90);
            btnListAbastecimentos.BackColor = Color.FromArgb(90, 90, 90);
            btnDash.BackColor = Color.FromArgb(65,65,65);
            btnListVehicle.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeDriver.BackColor = Color.FromArgb(90, 90, 90);
            btnListDrivers.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeRoute.BackColor = Color.FromArgb(90, 90, 90);
            btnListRoutes.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeMaintence.BackColor = Color.FromArgb(90, 90, 90);
            btnListMaintence.BackColor = Color.FromArgb(90, 90, 90);
            btnAlertMaintence.BackColor = Color.FromArgb(90, 90, 90);
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            driverTimer.Start();

            //Close Others Panels
            groupSupply.Size = groupSupply.MinimumSize;
            groupVehicle.Size = groupVehicle.MinimumSize;
            groupRoute.Size = groupRoute.MinimumSize;
            groupMaintence.Size = groupMaintence.MinimumSize;
            groupTrip.Size = groupTrip.MinimumSize;
        }

        private void btnMakeDriver_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(driver);
            driver.BringToFront();

            //Set - Unset Color
            btnMakeVehicle.BackColor = Color.FromArgb(90,90,90);
            btnAbastecer.BackColor = Color.FromArgb(90, 90, 90);
            btnListAbastecimentos.BackColor = Color.FromArgb(90, 90, 90);
            btnDash.BackColor = Color.FromArgb(65, 65, 65);
            btnListVehicle.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeDriver.BackColor = Color.FromArgb(25, 137, 186);
            btnListDrivers.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeRoute.BackColor = Color.FromArgb(90, 90, 90);
            btnListRoutes.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeMaintence.BackColor = Color.FromArgb(90, 90, 90);
            btnListMaintence.BackColor = Color.FromArgb(90, 90, 90);
            btnAlertMaintence.BackColor = Color.FromArgb(90, 90, 90);
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            routeTimer.Start();

            //Close Others Panels
            groupSupply.Size = groupSupply.MinimumSize;
            groupVehicle.Size = groupVehicle.MinimumSize;
            groupDriver.Size = groupDriver.MinimumSize;
            groupMaintence.Size = groupMaintence.MinimumSize;
            groupTrip.Size = groupTrip.MinimumSize;
        }

        private void btnMakeRoute_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(route);
            route.BringToFront();

            //Set - Unset Color
            btnMakeVehicle.BackColor = Color.FromArgb(90, 90, 90);
            btnAbastecer.BackColor = Color.FromArgb(90, 90, 90);
            btnListAbastecimentos.BackColor = Color.FromArgb(90, 90, 90);
            btnDash.BackColor = Color.FromArgb(65, 65, 65);
            btnListVehicle.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeDriver.BackColor = Color.FromArgb(90,90,90);
            btnListDrivers.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeRoute.BackColor = Color.FromArgb(25, 137, 186);
            btnListRoutes.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeMaintence.BackColor = Color.FromArgb(90, 90, 90);
            btnListMaintence.BackColor = Color.FromArgb(90, 90, 90);
            btnAlertMaintence.BackColor = Color.FromArgb(90, 90, 90);
        }

        private void btnMaintence_Click(object sender, EventArgs e)
        {
            maintenceTimer.Start();

            //Close Others Panels
            groupSupply.Size = groupSupply.MinimumSize;
            groupVehicle.Size = groupVehicle.MinimumSize;
            groupDriver.Size = groupDriver.MinimumSize;
            groupRoute.Size = groupRoute.MinimumSize;
            groupTrip.Size = groupTrip.MinimumSize;
        }

        private void btnMakeMaintence_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(maintence);
            maintence.BringToFront();

            //Set - Unset Color
            btnMakeVehicle.BackColor = Color.FromArgb(90, 90, 90);
            btnAbastecer.BackColor = Color.FromArgb(90, 90, 90);
            btnListAbastecimentos.BackColor = Color.FromArgb(90, 90, 90);
            btnDash.BackColor = Color.FromArgb(65, 65, 65);
            btnListVehicle.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeDriver.BackColor = Color.FromArgb(90, 90, 90);
            btnListDrivers.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeRoute.BackColor = Color.FromArgb(90,90,90);
            btnListRoutes.BackColor = Color.FromArgb(90, 90, 90);
            btnMakeMaintence.BackColor = Color.FromArgb(25,137,186);
            btnListMaintence.BackColor = Color.FromArgb(90, 90, 90);
            btnAlertMaintence.BackColor = Color.FromArgb(90, 90, 90);
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            tripTimer.Start();

            //Close Others Panels
            groupSupply.Size = groupSupply.MinimumSize;
            groupVehicle.Size = groupVehicle.MinimumSize;
            groupDriver.Size = groupDriver.MinimumSize;
            groupRoute.Size = groupRoute.MinimumSize;
            groupMaintence.Size = groupMaintence.MinimumSize;
        }

        private void btnMakeTrip_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(trip);
            trip.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (truckleerCallcontainer.Controls.Contains(supply))
            {
                
            }
        }
    }
}
