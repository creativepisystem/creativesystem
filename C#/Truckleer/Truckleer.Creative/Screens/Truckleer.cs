using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Creative.Screens.Viagem;
using Truckleer.Creative.Screens.Usuario;
using Truckleer.Creative.Screens.Despesas;
using Truckleer.Creative.Screens.CustomEvent;
using Truckleer.Modules;

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
        AlertaManutencao aleratManutencao = new AlertaManutencao();
        Viagens trip = new Viagens();
        ListarViagens listTrip = new ListarViagens();
        Usuarios user = new Usuarios();
        ListarUsuarios listUser = new ListarUsuarios();
        Despesas expense = new Despesas();
        ListarDespesas listExpense = new ListarDespesas();

        Panel currentPanel;
        public Truckleer()
        {
            InitializeComponent();
            Call(dash);
            supply.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<List<Supply>>.OnChangeScreen(BtnListAbastecimentos_Click);
            listSupply.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<Supply>.OnChangeScreen(BtnAbastecer_Click);

            //expense.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<Expense>.OnChangeScreen(BtnNewCost_Click);
            //listExpense.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<List<Expense>>.OnChangeScreen(BtnListCost_Click);

            //driver.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<Driver>.OnChangeScreen(BtnMakeDriver_Click);
            //listDriver.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<List<Driver>>.OnChangeScreen(BtnListDrivers_Click);

            //route.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<Route>.OnChangeScreen(BtnMakeRoute_Click);
            //listRoute.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<List<Route>>.OnChangeScreen(BtnRoutes_Click);

            //user.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<User>.OnChangeScreen(BtnNewUser_Click);
            //listUser.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<List<User>>.OnChangeScreen(BtnListUser_Click);

            //vehicle.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<Vehicle>.OnChangeScreen(BtnMakeVehicle_Click);
            //listVehicle.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<List<Vehicle>>.OnChangeScreen(BtnListVehicle_Click);

            //trip.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<Trip>.OnChangeScreen(BtnMakeTrip_Click);
            //listTrip.ChangeScreenEvent.ChangeScreen += new ChangeScreenEvent<List<Trip>>.OnChangeScreen(BtnListTrip_Click);
        }

        bool menuIsCollapsed = false;
        public void TimerMenu_Tick(object sender, EventArgs e)
        {
            if (menuIsCollapsed)
            {
                sideBarMenu.Width += 200;
                if (sideBarMenu.Size.Width == sideBarMenu.MaximumSize.Width)
                {
                    timerMenu.Stop();
                    menuIsCollapsed = false;
                }
            }
            else
            {
                sideBarMenu.Width -= 200;
                if (sideBarMenu.Size.Width == sideBarMenu.MinimumSize.Width)
                {
                    timerMenu.Stop();
                    menuIsCollapsed = true;
                }

            }

        }

        //Method Collapse Side Menu
        bool IsCollapsed = true;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                currentPanel.Height += 10;
                if (currentPanel.Size.Height == currentPanel.MaximumSize.Height)
                {
                    timer.Stop();
                    IsCollapsed = false;
                }
            }
            else
            {
                currentPanel.Height -= 10;
                if (currentPanel.Size.Height == currentPanel.MinimumSize.Height)
                {
                    timer.Stop();
                    IsCollapsed = true;
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
            BtnUser.BackColor = Color.FromArgb(64, 64, 64);
            BtnCost.BackColor = Color.FromArgb(64, 64, 64);

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
            btnMakeTrip.BackColor = Color.FromArgb(90, 90, 90);
            btnListTrip.BackColor = Color.FromArgb(90, 90, 90);
            BtnNewUser.BackColor = Color.FromArgb(90, 90, 90);
            BtnListUser.BackColor = Color.FromArgb(90, 90, 90);
            BtnNewCost.BackColor = Color.FromArgb(90, 90, 90);
            BtnListCost.BackColor = Color.FromArgb(90, 90, 90);
        }
        //Call the UserControls
        public void Call(UserControl screen)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(screen);
            screen.BringToFront();
        }
        //Close Groups
        public void CloseGroup(UserControl group)
        {
            if (group != null)
                group.Size = group.MaximumSize;

            groupSupply.Size = groupSupply.MinimumSize;
            groupVehicle.Size = groupSupply.MinimumSize;
            groupDriver.Size = groupSupply.MinimumSize;
            groupRoute.Size = groupSupply.MinimumSize;
            groupMaintence.Size = groupSupply.MinimumSize;
            groupTrip.Size = groupSupply.MinimumSize;
            groupUser.Size = groupSupply.MinimumSize;
        }
        //Turn Background Image Up
        public void BackImageUp(Button botao)
        {
            Image up = Properties.Resources.iconArrowUp;
            botao.BackgroundImage = up;
        }

        //Button Dash Properties        
        private void BtnDash_Click(object sender, EventArgs e)
        {

            Call(dash);
            // Unset Colors
            Uncolor();
            //Call CloseGroup Function
            CloseGroup(null);
            timerSideMenu.Start();
            btnDash.BackColor = Color.FromArgb(25, 137, 186);

        }

        //Button Abastecimento Properties
        private void BtnAbastecimento_Click(object sender, EventArgs e)
        {
            //Define a value to a global variable that contains the current panel group
            currentPanel = groupSupply;
            //Test the size of the panel group, if the condition is true, it's close the group instead of, it opens
            if (groupSupply.Size.Height == groupSupply.MaximumSize.Height)
                IsCollapsed = false;
            else
                IsCollapsed = true;
            //Call the timer which close or opens the groups
            timer.Start();
            //Opens the sideBar menu when the button is clicked and the menu is collapsed
            timerSideMenu.Start();

            //Call CloseGroup Function
            CloseGroup(supply);

            BackImageUp(btnAbastecimento);

        }

        //Button Abastecer Properties
        private void BtnAbastecer_Click(object sender, EventArgs e)
        {
            
            //Call the supply Panel
            Call(supply);
            // Unset Colors
            Uncolor();
            btnAbastecimento.BackColor = Color.FromArgb(25, 137, 186);
            btnAbastecer.BackColor = Color.Gray;
            try
            {
                if (sender.GetType().Name.Contains("ChangeScreenEvent"))
                {
                    ChangeScreenEvent<Supply> changeScreenEvent = (ChangeScreenEvent<Supply>)sender;
                    supply.SetSupply(changeScreenEvent.CustomClass);
                }
            }
            catch {}

        }

        //Button Listar Abastecimentos Properties
        private void BtnListAbastecimentos_Click(object sender, EventArgs e)
        {
            if (sender.GetType().Name.Contains("ChangeScreenEvent"))
            {
                listSupply.UpdateList();
            }
            //Call the supply Panel
            Call(listSupply);
            // Unset Colors
            Uncolor();
            btnAbastecimento.BackColor = Color.FromArgb(25, 137, 186);
            btnListAbastecimentos.BackColor = Color.Gray;
        }

        //Button Veículo Properties
        private void BtnVeiculo_Click(object sender, EventArgs e)
        {
            //Define a value to a global variable that contains the current panel group
            currentPanel = groupVehicle;
            //Test the size of the panel group, if the condition is true, it's close the group instead of, it opens
            if (groupVehicle.Size.Height == groupVehicle.MaximumSize.Height)
                IsCollapsed = false;
            else
                IsCollapsed = true;
            //Call the timer which close or opens the groups
            timer.Start();
            //Opens the sideBar menu when the button is clicked and the menu is collapsed
            timerSideMenu.Start();
            //Call CloseGroup Function
            CloseGroup(vehicle);

            BackImageUp(btnVeiculo);
        }

        //Button Cadastrar Veículo Properties
        private void BtnMakeVehicle_Click(object sender, EventArgs e)
        {
            Call(vehicle);
            // Unset Colors
            Uncolor();
            btnVeiculo.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeVehicle.BackColor = Color.Gray;
        }

        //Button Listar Veículos Properties
        private void BtnListVehicle_Click(object sender, EventArgs e)
        {
            Call(listVehicle);
            // Unset Colors
            Uncolor();
            btnVeiculo.BackColor = Color.FromArgb(25, 137, 186);
            btnListVehicle.BackColor = Color.Gray;
        }

        //Button Motorista Properties
        private void BtnDriver_Click_1(object sender, EventArgs e)
        {
            //Define a value to a global variable that contains the current panel group
            currentPanel = groupDriver;
            //Test the size of the panel group, if the condition is true, it's close the group instead of, it opens
            if (groupDriver.Size.Height == groupDriver.MaximumSize.Height)
                IsCollapsed = false;
            else
                IsCollapsed = true;
            //Call the timer which close or opens the groups
            timer.Start();
            //Opens the sideBar menu when the button is clicked and the menu is collapsed
            timerSideMenu.Start();
            //Call CloseGroup Function
            CloseGroup(driver);

            BackImageUp(btnDriver);

        }

        //Button Cadastrar Motorista Properties
        private void BtnMakeDriver_Click(object sender, EventArgs e)
        {
            Call(driver);
            // Unset Colors
            Uncolor();
            btnDriver.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeDriver.BackColor = Color.Gray;

        }

        //Button Listar Motoristas Properties
        private void BtnListDrivers_Click(object sender, EventArgs e)
        {
            Call(listDriver);
            // Unset Colors
            Uncolor();
            btnDriver.BackColor = Color.FromArgb(25, 137, 186);
            btnListDrivers.BackColor = Color.Gray;

        }

        //Button Rotas Properties
        private void BtnRoutes_Click(object sender, EventArgs e)
        {
            //Define a value to a global variable that contains the current panel group
            currentPanel = groupRoute;
            //Test the size of the panel group, if the condition is true, it's close the group instead of, it opens
            if (groupRoute.Size.Height == groupRoute.MaximumSize.Height)
                IsCollapsed = false;
            else
                IsCollapsed = true;
            //Call the timer which close or opens the groups
            timer.Start();
            //Opens the sideBar menu when the button is clicked and the menu is collapsed
            timerSideMenu.Start();
            //Call CloseGroup Function
            CloseGroup(route);

            BackImageUp(btnRoutes);
        }

        //Button Cadastrar Rotas Properties
        private void BtnMakeRoute_Click(object sender, EventArgs e)
        {
            Call(route);
            // Unset Colors
            Uncolor();
            btnRoutes.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeRoute.BackColor = Color.Gray;
        }

        //Button Listar Rotas Properties
        private void BtnListRoutes_Click(object sender, EventArgs e)
        {
            Call(listRoute);
            // Unset Colors
            Uncolor();
            btnRoutes.BackColor = Color.FromArgb(25, 137, 186);
            btnListRoutes.BackColor = Color.Gray;
        }

        //Button Manutenção Properties
        private void BtnMaintence_Click(object sender, EventArgs e)
        {
            //Define a value to a global variable that contains the current panel group
            currentPanel = groupMaintence;
            //Test the size of the panel group, if the condition is true, it's close the group instead of, it opens
            if (groupMaintence.Size.Height == groupMaintence.MaximumSize.Height)
                IsCollapsed = false;
            else
                IsCollapsed = true;
            //Call the timer which close or opens the groups
            timer.Start();
            //Opens the sideBar menu when the button is clicked and the menu is collapsed
            timerSideMenu.Start();
            //Call CloseGroup Function
            CloseGroup(maintence);

            BackImageUp(btnMaintence);
        }

        //Button Cadastrar Manutenção Properties
        private void BtnMakeMaintence_Click(object sender, EventArgs e)
        {
            Call(maintence);
            // Unset Colors
            Uncolor();
            btnMaintence.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeMaintence.BackColor = Color.Gray;
        }

        //Button Listar Manutenção Properties
        private void BtnListMaintence_Click(object sender, EventArgs e)
        {
            Call(listMaintece);
            // Unset Colors
            Uncolor();
            btnMaintence.BackColor = Color.FromArgb(25, 137, 186);
            btnListMaintence.BackColor = Color.Gray;
        }

        //Button Alerta Manutenção Properties
        private void BtnAlertMaintence_Click_1(object sender, EventArgs e)
        {
            Call(aleratManutencao);
            // Unset Colors
            Uncolor();
            btnMaintence.BackColor = Color.FromArgb(25, 137, 186);
            btnAlertMaintence.BackColor = Color.Gray;
        }

        //Button Viagem Properties
        private void BtnTrip_Click(object sender, EventArgs e)
        {
            //Define a value to a global variable that contains the current panel group
            currentPanel = groupTrip;
            //Test the size of the panel group, if the condition is true, it's close the group instead of, it opens
            if (groupTrip.Size.Height == groupTrip.MaximumSize.Height)
                IsCollapsed = false;
            else
                IsCollapsed = true;
            //Call the timer which close or opens the groups
            timer.Start();
            //Opens the sideBar menu when the button is clicked and the menu is collapsed
            timerSideMenu.Start();
            //Call CloseGroup Function
            CloseGroup(trip);

            BackImageUp(btnTrip);

        }

        //Button Cadastrar Viagem Properties
        private void BtnMakeTrip_Click(object sender, EventArgs e)
        {
            Call(trip);
            // Unset Colors
            Uncolor();
            btnTrip.BackColor = Color.FromArgb(25, 137, 186);
            btnMakeTrip.BackColor = Color.Gray;
        }

        //Button Listar Viagens Properties
        private void BtnListTrip_Click(object sender, EventArgs e)
        {
            Call(listTrip);
            // Unset Colors
            Uncolor();
            btnTrip.BackColor = Color.FromArgb(25, 137, 186);
            btnListTrip.BackColor = Color.Gray;
        }

        //Button Usuário Properties
        private void BtnUser_Click(object sender, EventArgs e)
        {
            //Define a value to a global variable that contains the current panel group
            currentPanel = groupUser;
            //Test the size of the panel group, if the condition is true, it's close the group instead of, it opens
            if (groupUser.Size.Height == groupUser.MaximumSize.Height)
                IsCollapsed = false;
            else
                IsCollapsed = true;
            //Call the timer which close or opens the groups
            timer.Start();
            //Opens the sideBar menu when the button is clicked and the menu is collapsed
            timerSideMenu.Start();
            //Call CloseGroup Function
            CloseGroup(user);

            BackImageUp(btnTrip);
        }

        //Button Novo Usuário
        private void BtnNewUser_Click(object sender, EventArgs e)
        {
            Call(user);
            //Unset Colors
            Uncolor();
            BtnUser.BackColor = Color.FromArgb(25, 137, 186);
            BtnNewUser.BackColor = Color.Gray;
        }

        //Button Listar Usuários Properties
        private void BtnListUser_Click(object sender, EventArgs e)
        {
            Call(listUser);
            // Unset Colors
            Uncolor();
            BtnUser.BackColor = Color.FromArgb(25, 137, 186);
            BtnListUser.BackColor = Color.Gray;
        }

        //Button Cost Properties
        private void BtnCost_Click(object sender, EventArgs e)
        {
            //Define a value to a global variable that contains the current panel group
            currentPanel = groupCost;
            //Test the size of the panel group, if the condition is true, it's close the group instead of, it opens
            if (groupCost.Size.Height == groupCost.MaximumSize.Height)
                IsCollapsed = false;
            else
                IsCollapsed = true;
            //Call the timer which close or opens the groups
            timer.Start();
            //Opens the sideBar menu when the button is clicked and the menu is collapsed
            timerSideMenu.Start();
            //Call CloseGroup Function
            CloseGroup(user);

            BackImageUp(btnTrip);
        }

        //Button Nova Despesa
        private void BtnNewCost_Click(object sender, EventArgs e)
        {
            Call(expense);
            //Unset Colors
            Uncolor();
            BtnCost.BackColor = Color.FromArgb(25, 137, 186);
            BtnNewCost.BackColor = Color.Gray;
        }

        //Button Listar Despesas Properties
        private void BtnListCost_Click(object sender, EventArgs e)
        {
            Call(listExpense);
            // Unset Colors
            Uncolor();
            BtnCost.BackColor = Color.FromArgb(25, 137, 186);
            BtnListCost.BackColor = Color.Gray;
        }

        //Timer Open Side Menu When Other Button Is Clicked
        private void TimerSideMenu_Tick(object sender, EventArgs e)
        {
            sideBarMenu.Width += 10;
            if (sideBarMenu.Size.Width == sideBarMenu.MaximumSize.Width)
            {
                timerSideMenu.Stop();
                menuIsCollapsed = false;
            }
        }

        //Open and Close SideBar Menu By Click on Hamburguer Button
        private void HamburguerMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
            //Call CloseGroup Function
            CloseGroup(null);
        }

        //Does Nothing
        private void LoadScreen_Tick(object sender, EventArgs e)
        {

        }

    }
}
