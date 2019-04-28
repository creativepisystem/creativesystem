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

        // Animation Supply Menu 
        bool supplyIsCollapsed = true;
        private void supplyTimer_Tick(object sender, EventArgs e)
        {
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

        // Animation Vehicle Menu
        bool vehicleIsCollapsed = true;
        private void vehicleTimer_Tick(object sender, EventArgs e)
        {
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

        // Animation Driver Menu
        bool driverIsCollapsed = true;
        private void driverTimer_Tick(object sender, EventArgs e)
        {
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

        // Animation Route Menu
        bool routeIsCollapsed = true;
        private void routeTimer_Tick(object sender, EventArgs e)
        {
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

        // Animation Maintence Menu
        bool maintenceIsCollapsed = true;
        private void maintenceTimer_Tick(object sender, EventArgs e)
        {
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
        
        // Animation Trip Menu
        bool tripIsCollapsed = true;
        private void tripTimer_Tick(object sender, EventArgs e)
        {
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

        // Method Remove Buttons Color
        public void uncolor()
        {
            // Main Menus
            btnDash.BackColor = Color.FromArgb(64, 64, 64);
            btnAbastecimento.BackColor = Color.FromArgb(64, 64, 64);
            btnDriver.BackColor = Color.FromArgb(64, 64, 64);
            btnRoutes.BackColor = Color.FromArgb(64, 64, 64);
            btnMaintence.BackColor = Color.FromArgb(64, 64, 64);
            btnTrip.BackColor = Color.FromArgb(64, 64, 64);
            btnVeiculo.BackColor = Color.FromArgb(64, 64, 64);

            // Submenus
            btnAbastecer.BackColor = Color.Gray;
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

        // Method Close Menus
        public void closeMenu()
        {
            supplyIsCollapsed = true;
            vehicleIsCollapsed = true;
            driverIsCollapsed = true;
            routeIsCollapsed = true;
            maintenceIsCollapsed = true;
            tripIsCollapsed = true;
            groupSupply.Size = groupSupply.MinimumSize;
            groupVehicle.Size = groupVehicle.MinimumSize;
            groupDriver.Size = groupDriver.MinimumSize;
            groupRoute.Size = groupRoute.MinimumSize;
            groupMaintence.Size = groupMaintence.MinimumSize;
            groupTrip.Size = groupTrip.MinimumSize;
        }

        public void backImageUp(Button botao)
        {
            Image up = Properties.Resources.iconArrowUp;
            botao.BackgroundImage = up;
        }

        public void BackImageDown()
        {
            Image down = Properties.Resources.iconArrowDown;
            btnAbastecimento.BackgroundImage = down;
            btnVeiculo.BackgroundImage = down;
            btnDriver.BackgroundImage = down;
            btnRoutes.BackgroundImage = down;
            btnMaintence.BackgroundImage = down;
            btnTrip.BackgroundImage = down;
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(dash);
            dash.BringToFront();

            //Close Other Panels
            closeMenu();

            // Unset Colors
            uncolor();
            btnDash.BackColor = Color.FromArgb(25, 137, 186);
        }

        private void btnAbastecimento_Click(object sender, EventArgs e)
        {
            supplyTimer.Start();

            //Close others panels
            closeMenu();
            BackImageDown();
            backImageUp(btnAbastecimento);
        }

        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            //Call the supply Panel
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(supply);
            supply.BringToFront();

            
            // Unset Colors
            uncolor();
            btnAbastecimento.BackColor = Color.FromArgb(25, 137, 186);
            btnAbastecer.BackColor = Color.Gray;
        }

        private void btnVeiculo_Click(object sender, EventArgs e)
        {
            vehicleTimer.Start();

            //Close others panels
            closeMenu();
            BackImageDown();
            backImageUp(btnVeiculo);
        }

        private void btnMakeVehicle_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(vehicle);
            vehicle.BringToFront();

            // Unset Colors
            uncolor();
            btnVeiculo.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeVehicle.BackColor = Color.Gray;
        }

        private void btnDriver_Click(object sender, EventArgs e)
        {
            driverTimer.Start();

            //Close Others Panels
            closeMenu();
            BackImageDown();
            backImageUp(btnDriver);
        }

        private void btnMakeDriver_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(driver);
            driver.BringToFront();

            // Unset Colors
            uncolor();
            btnDriver.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeDriver.BackColor = Color.Gray;
        }

        private void btnRoutes_Click(object sender, EventArgs e)
        {
            routeTimer.Start();

            //Close Others Panels
            closeMenu();
            BackImageDown();
            backImageUp(btnRoutes);
        }

        private void btnMakeRoute_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(route);
            route.BringToFront();

            // Unset Colors
            uncolor();
            btnRoutes.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeRoute.BackColor = Color.Gray;
        }

        private void btnMaintence_Click(object sender, EventArgs e)
        {
            maintenceTimer.Start();

            //Close Others Panels
            closeMenu();
            BackImageDown();
            backImageUp(btnMaintence);
        }

        private void btnMakeMaintence_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(maintence);
            maintence.BringToFront();

            // Unset Colors
            uncolor();
            btnMaintence.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeMaintence.BackColor = Color.Gray;
        }

        private void btnTrip_Click(object sender, EventArgs e)
        {
            tripTimer.Start();

            //Close Others Panels
            closeMenu();
            BackImageDown();
            backImageUp(btnTrip);
        }

        private void btnMakeTrip_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(trip);
            trip.BringToFront();

            //Unset Colors
            uncolor();
            btnTrip.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeTrip.BackColor = Color.Gray;
        }
    }
}
