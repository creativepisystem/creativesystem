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
using Truckleer.Creative.Screens.Motorista;

namespace Truckleer.Creative
{
    public partial class ListarMotoristas : UserControl
    {

        private DriverService driverService;
        private List<Driver> drivers = new List<Driver>();

        public ListarMotoristas()
        {
            InitializeComponent();
            driverService = new DriverService();
        }

        private void ListarMotoristas_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            driverListWorker.RunWorkerAsync();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            filtro.Start();
        }

        bool isCollapsed = false;
        private void Filtro_Tick(object sender, EventArgs e)
        {            
                if (isCollapsed)
                {
                    TitleFilter.Height += 40;
                    if (TitleFilter.Size.Height == TitleFilter.MaximumSize.Height)
                    {
                        filtro.Stop();
                        isCollapsed = false;
                    }
                }
                else
                {
                    TitleFilter.Height -= 40;
                    if (TitleFilter.Size.Height == TitleFilter.MinimumSize.Height)
                    {
                        filtro.Stop();
                        isCollapsed = true;
                    }
                }
            
        }

        private void ButtonCadastro_Click(object sender, EventArgs e)
        {
            driverListWorker.RunWorkerAsync();
        }

        private void FilterDriver(object sender, DoWorkEventArgs e)
        {
            e.Result = driverService.FindAll();
            for (int i = 0; i <= 100; i++)
                driverListWorker.ReportProgress(i);
        }

        private void FilterDriverProgress(object sender, ProgressChangedEventArgs e)
        {
            ProgressBar.Value = e.ProgressPercentage;
        }

        private void FilterDriverFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar.Visible = false;
            drivers = (List<Driver>)e.Result;
            FlowDriver.Controls.Clear();
            for (int i = 0; i < drivers.Count; i++)
                FlowDriver.Controls.Add(new CustomDriverList(i, drivers[i]));
        }
    }
}
