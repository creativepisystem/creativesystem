using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;
using Message = Truckleer.Modules.Message;

namespace Truckleer.Creative.Screens.Despesas
{
    public partial class Despesas : UserControl
    {
        private Expense Expense;
        private DriverService driverService;
        private TripService tripService;
        private ExpenseService expenseService;
        private List<Trip> trips;
        private List<Driver> drivers;
        public Despesas()
        {
            InitializeComponent();
            driverService = new DriverService();
            expenseService = new ExpenseService();
            tripService = new TripService();
            Expense = new Expense();
        }

        private void Despesas_Load(object sender, EventArgs e)
        {
            
            if (Expense == null)
                ClearFields();
            Dock = DockStyle.Fill;
            TripWorker.RunWorkerAsync();
            DriverWorker.RunWorkerAsync();
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

        private void GetDrivers(object sender, DoWorkEventArgs e)
        {
            e.Result = driverService.FindAll();
        }

        private void GetDriversWorker(object sender, RunWorkerCompletedEventArgs e)
        {
            drivers = (List<Driver>)e.Result;
            drivers.ForEach((driver) =>
            {
                BoxDriver.Items.Add($"{driver.Name}");
            });
        }

        private void SaveExpense(object sender, DoWorkEventArgs e)
        {
            e.Result = expenseService.Save(Expense);
        }

        private void SaveExpenseFinish(object sender, RunWorkerCompletedEventArgs e)
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ButtonSave.Enabled = false;
            Expense.Date = Date.Value;
            Expense.Type = TextType.Text;
            Expense.Obs = TextObservation.Text;
            if (BoxTrip.SelectedIndex > -1)
                Expense.Trip = trips[BoxTrip.SelectedIndex];
            if(BoxDriver.SelectedIndex > -1)
                Expense.Driver = drivers[BoxDriver.SelectedIndex];
            if (!string.IsNullOrEmpty(TextPrice.Text))
                Expense.Value = Convert.ToSingle(TextPrice.Text);
            Message message = Expense.IsValid();
            if(message.Type == MessageType.ERROR)
            {
                MessageBox.Show(message.MessageText);
                ButtonSave.Enabled = true;
                Cursor = Cursors.Default;
            }
            else
            {
                ExpenseWorker.RunWorkerAsync();
            }
        }
        

        private void TextPrice_TextChanged(object sender, EventArgs e)
        {
            TextPrice.Text = RemoveLetters(TextPrice.Text);
        }
        private string RemoveLetters(string text)
        {
            int cont = 0;
            foreach (char c in text)
            {
                if (!char.IsDigit(c) && c != '.' && c != ',')
                {
                    text = text.Remove(text.IndexOf(c));
                }
                if (c == ',')
                {
                    cont++;
                }
            }
            if (cont > 0)
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
            Date.Value = DateTime.Now;
            TextType.Text = "";
            TextObservation.Text = "";
            TextPrice.Text = "";
            BoxDriver.SelectedIndex = -1;
            BoxTrip.SelectedIndex = -1;
        }
    }
}
