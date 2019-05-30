using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truckleer.Creative.Screens.Despesas
{
    public partial class Despesas : UserControl
    {
        public Despesas()
        {
            InitializeComponent();
        }

        private void Despesas_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }

        private void GetTrips(object sender, DoWorkEventArgs e)
        {

        }

        private void GetTripsFinish(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void GetDrivers(object sender, DoWorkEventArgs e)
        {

        }

        private void GetDriversWorker(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void SaveExpense(object sender, DoWorkEventArgs e)
        {

        }

        private void SaveExpenseFinish(object sender, RunWorkerCompletedEventArgs e)
        {

        }
    }
}
