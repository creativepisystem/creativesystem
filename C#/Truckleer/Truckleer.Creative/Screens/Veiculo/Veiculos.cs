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
using Truckleer.Creative.Screens.CustomEvent;

namespace Truckleer.Creative
{
    public partial class Veiculos : UserControl
    {
        public ChangeScreenEvent<Vehicle> ChangeScreenEvent { get; set; }
        private Vehicle Vehicle;
        private VehicleService vehicleService;
        public Veiculos()
        {
            InitializeComponent();
            vehicleService = new VehicleService();
            Vehicle = new Vehicle();
        }

        private void Veiculos_Load(object sender, EventArgs e)
        {
            ClearFields();
            this.Dock = DockStyle.Fill;
        }


        private void SaveVehicle(object sender, DoWorkEventArgs e)
        {
            e.Result = vehicleService.Save(Vehicle);
        }
        private void SaveVehicleFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            bool isSave = (bool)e.Result;
            if (isSave)
            {
                MessageBox.Show("Veiculo Salvo com Sucesso");
                ClearFields();
            }
            else
            {
                MessageBox.Show("Erro ao Salvar o Veiculo");
            }
            ButtonSave.Enabled = true;
            Cursor = Cursors.Default;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            ButtonSave.Enabled = false;
            if (!string.IsNullOrEmpty(TextPlate.Text))
                Vehicle.License_plate = TextPlate.Text;
            if (!string.IsNullOrEmpty(TextBrand.Text))
                Vehicle.Brand = TextBrand.Text;
            if (!string.IsNullOrEmpty(TextModel.Text))
                Vehicle.Model = TextModel.Text;
            if (BoxColor.SelectedIndex > -1)
                Vehicle.Color= (VehicleColor)BoxColor.SelectedIndex;
            if (!string.IsNullOrEmpty(TextChassi.Text))
                Vehicle.Chassi = TextChassi.Text;
            if (!string.IsNullOrEmpty(TextYearFab.Text))
                Vehicle.Fab_Year= Convert.ToInt32(TextYearFab.Text);
            if (!string.IsNullOrEmpty(TextYearMod.Text))
                Vehicle.Mod_Year = Convert.ToInt32(TextYearMod.Text);
            if (!string.IsNullOrEmpty(TextYearMod.Text))
                Vehicle.Mod_Year = Convert.ToInt32(TextYearMod.Text);
            if (!string.IsNullOrEmpty(TextRenavam.Text))
                Vehicle.Renavam = TextRenavam.Text;
            if (!string.IsNullOrEmpty(TextTank.Text))
                Vehicle.Tank_capacity = Convert.ToInt32(TextTank.Text);
            Message message = Vehicle.IsValid();
            if(message.Type == MessageType.ERROR)
            {
                MessageBox.Show(message.MessageText);
                ButtonSave.Enabled = true;
                Cursor = Cursors.Default;
            }
            else
            {
                vehicleWorker.RunWorkerAsync();
            }
        }
        private void ClearFields()
        {
            TextPlate.Text = "";
            TextBrand.Text = "";
            TextModel.Text = "";
            BoxColor.Items.Clear();
            TextChassi.Text = "";
            TextYearFab.Text = "";
            TextYearMod.Text = "";
            TextYearMod.Text = "";
            TextRenavam.Text = "";
            TextTank.Text = "";
        }
    }
}
