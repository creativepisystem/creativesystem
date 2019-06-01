using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Truckleer.Modules;
using System.Linq;
using System.Dynamic;

namespace Truckleer.Creative.Screens.Home
{
    public partial class Home : UserControl
    {
        private TripService tripService;
        private DriverService driverService;
        private SupplyService supplyService;
        private ExpenseService expenseService;
        private List<Supply> supplys;
        private List<Driver> drivers;
        private List<Trip> trips;
        private List<Expense> expenses;
        private int contWorks = 0;
        public Home()
        {
            tripService = new TripService();
            driverService = new DriverService();
            supplyService = new SupplyService();
            expenseService = new ExpenseService();
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
            Cursor = Cursors.WaitCursor;
            TripListWorker.RunWorkerAsync();
            DriverListWorker.RunWorkerAsync();
            SupplyListWorker.RunWorkerAsync();
            ExpenseListWorker.RunWorkerAsync();
        }

        private void SaveTrip(object sender, DoWorkEventArgs e)
        {

        }

        private void SaveTripFinish(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void GetTrips(object sender, DoWorkEventArgs e)
        {
            e.Result = tripService.FindAll();
        }

        private void GetTripsFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            trips = (List<Trip>)e.Result;
            contWorks++;
            if (contWorks > 3)
                FinishAllWorkers();
        }

        private void GetSupplys(object sender, DoWorkEventArgs e)
        {
            e.Result = supplyService.FindAll();
        }

        private void GetSupplysFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            supplys = (List<Supply>)e.Result;
            contWorks++;
            if (contWorks > 3)
                FinishAllWorkers();
        }

        private void GetExpenses(object sender, DoWorkEventArgs e)
        {
            e.Result = expenseService.FindAll();
        }

        private void GetExpensesFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            expenses = (List<Expense>)e.Result;
            contWorks++;
            if (contWorks > 3)
                FinishAllWorkers();
        }

        private void GetDrivers(object sender, DoWorkEventArgs e)
        {
            e.Result = driverService.FindAll();
        }

        private void GetDriversFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            drivers = (List<Driver>)e.Result;
            contWorks++;
            if (contWorks > 3)
                FinishAllWorkers();
        }

        private void FinishAllWorkers()
        {
            Cursor = Cursors.Default;
            LabelReceiveLitros.Text = string.Format("{0:0.00} L", supplys.Sum(s => s.Liters));
            LabelReceiveCLitros.Text = string.Format("R$ {0:0.00}", supplys.Sum(s => s.Price));
            LabelReceiveExpense.Text = string.Format("R$ {0:0.00}", expenses.Sum(s => s.Value));
            LabelReceiveTrip.Text = trips.Count.ToString();
            LabelReceiveTotal.Text = string.Format("R$ {0:0.00}", supplys.Sum(s => s.Price) + expenses.Sum(s => s.Value));

            FlowTrip.Controls.Clear();
            FlowDriver.Controls.Clear();
            for (int i = 0; i < trips.Count; i++)
                FlowTrip.Controls.Add(
                    new CustomTripExpenseList(i, new TripDTO()
                    {
                        Trip = trips[i],
                        TotalExpense = expenses.Where(expense => expense.Trip.Id == trips[i].Id)
                                        .Sum(expense => expense.Value)
                    },
                    CloseTrip
                    ));
            for (int i = 0; i < drivers.Count; i++)
                FlowDriver.Controls.Add(
                    new CustomDriverExpenseList(i,
                    new DriverDTO()
                    {
                        Name = drivers[i].Name,
                        FuelTotal = supplys.Where(supply => supply.Driver.Id == drivers[i].Id).Sum(supply => supply.Price),
                        ExpenseTotal = expenses.Where(expense => expense.Driver.Id == drivers[i].Id)
                                        .Sum(expense => expense.Value)
                    }
                    ));
            var litersSerie = LitersCharts.Series.Add("Litros");
            var expenseSerie = LitersCharts.Series.Add("Custo");
            var teste = supplys.
                GroupBy(s => new DateTime(year: s.Date.Year, month: s.Date.Month, day: s.Date.Day)).ToList();
                
                getListUniqueDates().ForEach(d =>
            {
                
                litersSerie.Points.AddXY($"{d.Day}",
                    supplys.Where(s=> s.Date.Day == d.Day && s.Date.Month == d.Month && s.Date.Year == d.Year).
                    Sum(s => s.Liters)
                    );
                expenseSerie.Points.AddXY($"{d.Day}",
                    supplys.Where(s => s.Date.Day == d.Day && s.Date.Month == d.Month && s.Date.Year == d.Year).
                    Sum(s => s.Price)
                    );
            });
           
        }

        private void CloseTrip(Trip trip)
        {

        }
        private List<DateTime> getListUniqueDates()
        {
            List<DateTime> uDates = new List<DateTime>();
            return uDates;
        }
    }
}
