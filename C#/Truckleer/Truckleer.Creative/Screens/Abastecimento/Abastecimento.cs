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

namespace Truckleer.Creative
{
    public partial class Abastecimento : UserControl
    {
        public Supply Supply;

        public Abastecimento(Supply supply)
        {
            if(supply != null)
            {
                this.Supply = supply;
            }
            else
            {
                this.Supply = new Supply();
            }

            InitializeComponent();
        }

        private void Abastecimento_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
        
        //Call Dashboard
        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            Supply.vehicle.license_plate = BoxVehicle.ToString();
            Supply.liters = Convert.ToSingle(TextLiters);
            Supply.route.origin = BoxRoute.ToString();
        }

        private void BoxVehicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            VehicleService veiculos = new VehicleService();
            MessageBox.Show(veiculos.FindAll().ToString());
        }
    }
}
