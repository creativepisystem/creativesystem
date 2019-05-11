using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Api.Classes;

namespace Truckleer.Creative
{
    public partial class Truckleer : Form
    {
        Dashboard dash = new Dashboard();
        Abastecimento supply = new Abastecimento();
        ListarAbastecimentos listSupply = new ListarAbastecimentos();
        Veiculos vehicle = new Veiculos();
        ListarVeiculos listVehicle = new ListarVeiculos();
        Motorista driver = new Motorista();
        ListarMotoristas listDriver = new ListarMotoristas();
        Rotas route = new Rotas();
        ListarRotas listRoute = new ListarRotas();
        Manutencao maintence = new Manutencao();
        ListarManutencao listMaintece = new ListarManutencao();
        Viagens trip = new Viagens();

        public Truckleer()
        {
            InitializeComponent();

            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(dash);
            dash.BringToFront();

            /*Serializer<Driver> driving = new Serializer<Driver>("Zyh5fy3SMfu7mDrkpNWr");
            MessageBox.Show(driving.ToString());*/
        }


        public void SplashStart() { }
        

        bool menuIsCollapsed = false;
        private void TimerMenu_Tick(object sender, EventArgs e)
        {
            if (menuIsCollapsed)
            {
                OpenSideMenu();
                sideBarMenu.Width += 10;
                if (sideBarMenu.Size.Width == sideBarMenu.MaximumSize.Width)
                {
                    timerMenu.Stop();
                    menuIsCollapsed = false;
                }
            }
            else
            {                
                sideBarMenu.Width -= 10;
                if (sideBarMenu.Size.Width == sideBarMenu.MinimumSize.Width)
                {
                    timerMenu.Stop();
                    CloseSideMenu();
                    menuIsCollapsed = true;
                }
                
            }

        }

        // Animation Supply Menu 
        bool supplyIsCollapsed = true;
        private void SupplyTimer_Tick(object sender, EventArgs e)
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
        private void VehicleTimer_Tick(object sender, EventArgs e)
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
        private void DriverTimer_Tick(object sender, EventArgs e)
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
        private void RouteTimer_Tick(object sender, EventArgs e)
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
        private void MaintenceTimer_Tick(object sender, EventArgs e)
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
        private void TripTimer_Tick(object sender, EventArgs e)
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
        public void Uncolor()
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
            btnAbastecer.BackColor = Color.FromArgb(90, 90, 90);
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
        public void CloseMenu()
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

        private void CloseSideMenu()
        {
            btnDash.Text = "";
            btnAbastecimento.Text = "";
            btnAbastecimento.BackgroundImage = null;
            btnVeiculo.Text = "";
            btnVeiculo.BackgroundImage = null;
            btnDriver.Text = "";
            btnDriver.BackgroundImage = null;
            btnRoutes.Text = "";
            btnRoutes.BackgroundImage = null;
            btnMaintence.Text = "";
            btnMaintence.BackgroundImage = null;
            btnTrip.Text = "";
            btnTrip.BackgroundImage = null;
            CloseMenu();
        }

        private void OpenSideMenu()
        {
            timerSideMenu.Start();
            btnDash.Text = "Dashboard";
            btnAbastecimento.Text = "Abastecimento";
            btnAbastecimento.BackgroundImage = Properties.Resources.iconArrowUp;
            btnVeiculo.Text = "Veículo";
            btnVeiculo.BackgroundImage = Properties.Resources.iconArrowUp;
            btnDriver.Text = "Motorista";
            btnDriver.BackgroundImage = Properties.Resources.iconArrowUp;
            btnRoutes.Text = "Rotas";
            btnRoutes.BackgroundImage = Properties.Resources.iconArrowUp;
            btnMaintence.Text = "Manutenção";
            btnMaintence.BackgroundImage = Properties.Resources.iconArrowUp;
            btnTrip.Text = "Viagem";
            btnTrip.BackgroundImage = Properties.Resources.iconArrowUp;

        }

        public void BackImageUp(Button botao)
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

        private void BtnDash_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(dash);
            dash.BringToFront();

            //Close Other Panels
            CloseMenu();

            // Unset Colors
            Uncolor();
            BackImageDown();
            btnDash.BackColor = Color.FromArgb(25, 137, 186);

        }

        private void BtnAbastecimento_Click(object sender, EventArgs e)
        {
            supplyTimer.Start();
            OpenSideMenu();

            //Close others panels
            CloseMenu();
            BackImageDown();
            BackImageUp(btnAbastecimento);

        }

        private void BtnAbastecer_Click(object sender, EventArgs e)
        {
            //Call the supply Panel
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(supply);
            supply.BringToFront();


            // Unset Colors
            Uncolor();
            btnAbastecimento.BackColor = Color.FromArgb(25, 137, 186);
            btnAbastecer.BackColor = Color.Gray;

        }

        private void BtnListAbastecimentos_Click(object sender, EventArgs e)
        {
            //Call the supply Panel
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(listSupply);
            listSupply.BringToFront();

            // Unset Colors
            Uncolor();
            btnAbastecimento.BackColor = Color.FromArgb(25, 137, 186);
            btnListAbastecimentos.BackColor = Color.Gray;
        }

        private void BtnVeiculo_Click(object sender, EventArgs e)
        {
            vehicleTimer.Start();
            OpenSideMenu();

            //Close others panels
            CloseMenu();
            BackImageDown();
            BackImageUp(btnVeiculo);
        }

        private void BtnMakeVehicle_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(vehicle);
            vehicle.BringToFront();

            // Unset Colors
            Uncolor();
            btnVeiculo.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeVehicle.BackColor = Color.Gray;
        }

        private void BtnListVehicle_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(listVehicle);
            listVehicle.BringToFront();

            // Unset Colors
            Uncolor();
            btnVeiculo.BackColor = Color.FromArgb(25, 137, 186);
            btnListVehicle.BackColor = Color.Gray;
        }

        private void BtnDriver_Click_1(object sender, EventArgs e)
        {
            driverTimer.Start();
            OpenSideMenu();

            //Close Others Panels
            CloseMenu();
            BackImageDown();
            BackImageUp(btnDriver);

        }

        private void BtnMakeDriver_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(driver);
            driver.BringToFront();

            // Unset Colors
            Uncolor();
            btnDriver.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeDriver.BackColor = Color.Gray;

        }

        private void BtnListDrivers_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(listDriver);
            listDriver.BringToFront();

            // Unset Colors
            Uncolor();
            btnDriver.BackColor = Color.FromArgb(25, 137, 186);
            btnListDrivers.BackColor = Color.Gray;

        }

        private void BtnRoutes_Click(object sender, EventArgs e)
        {
            routeTimer.Start();
            OpenSideMenu();

            //Close Others Panels
            CloseMenu();
            BackImageDown();
            BackImageUp(btnRoutes);
        }

        private void BtnMakeRoute_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(route);
            route.BringToFront();

            // Unset Colors
            Uncolor();
            btnRoutes.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeRoute.BackColor = Color.Gray;
        }

        private void BtnListRoutes_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(listRoute);
            listRoute.BringToFront();

            // Unset Colors
            Uncolor();
            btnRoutes.BackColor = Color.FromArgb(25, 137, 186);
            btnListRoutes.BackColor = Color.Gray;
        }

        private void BtnMaintence_Click(object sender, EventArgs e)
        {
            maintenceTimer.Start();
            OpenSideMenu();

            //Close Others Panels
            CloseMenu();
            BackImageDown();
            BackImageUp(btnMaintence);
        }

        private void BtnMakeMaintence_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(maintence);
            maintence.BringToFront();

            // Unset Colors
            Uncolor();
            btnMaintence.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeMaintence.BackColor = Color.Gray;
        }

        private void BtnListMaintence_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(listMaintece);
            listMaintece.BringToFront();

            // Unset Colors
            Uncolor();
            btnMaintence.BackColor = Color.FromArgb(25, 137, 186);
            btnListMaintence.BackColor = Color.Gray;
        }

        private void BtnAlertMaintence_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnTrip_Click(object sender, EventArgs e)
        {
            tripTimer.Start();
            OpenSideMenu();

            //Close Others Panels
            CloseMenu();
            BackImageDown();
            BackImageUp(btnTrip);

        }

        private void BtnMakeTrip_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(trip);
            trip.BringToFront();

            //Unset Colors
            Uncolor();
            btnTrip.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeTrip.BackColor = Color.Gray;
        }

        private void BtnListTrip_Click_1(object sender, EventArgs e)
        {

        }

        private void TimerSideMenu_Tick(object sender, EventArgs e)
        {
            sideBarMenu.Width += 10;
            if (sideBarMenu.Size.Width == sideBarMenu.MaximumSize.Width)
            {
                timerSideMenu.Stop();
                menuIsCollapsed = false;
            }
        }

        private void HamburguerMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();            
        }

        private void LoadScreen_Tick(object sender, EventArgs e)
        {

        }
    }
}
