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

namespace Truckleer.Creative
{
    public partial class Rotas : UserControl
    {
        private RouteService routeService;
        private Route Route;
        public Rotas()
        {
            InitializeComponent();
            routeService = new RouteService();
            Route = new Route();
        }

        private void Rotas_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        private void SaveRoute(object sender, DoWorkEventArgs e)
        {
            e.Result = routeService.Save(Route);
        }
        private void SaveRouteFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            bool isSave = (bool)e.Result;
            if (isSave)
            {
                MessageBox.Show("Rota Salva com Sucesso");
            }
            else
            {
                MessageBox.Show("Erro ao Salvar a rota!");
            }
            ButtonSave.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ButtonSave.Enabled = false;
            if (!string.IsNullOrEmpty(TextOrigin.Text))
                Route.Origin = TextOrigin.Text;
            if (!string.IsNullOrEmpty(TextDestination.Text))
                Route.Destination = TextDestination.Text;
            if (!string.IsNullOrEmpty(TextStops.Text))
            {
                Route.Stops = new List<string>();
                foreach (string stop in TextStops.Text.Split(','))
                    Route.Stops.Add(stop);
            }
            Message message = Route.IsValid();
            if(message.Type == MessageType.ERROR)
            {
                MessageBox.Show(message.MessageText);
                ButtonSave.Enabled = true;
                Cursor = Cursors.Default;
            }
            else
            {
                routeWorker.RunWorkerAsync();
            }
        }
    }
}
