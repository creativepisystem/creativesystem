using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Response;
using Truckleer.Api.FireConnection;
using Truckleer.Api.Classes;

namespace Truckleer.Creative
{
    public partial class Motorista : UserControl
    {
        public Motorista()
        {
            InitializeComponent();
        }

        private void Motorista_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void panelRightDriver_Paint(object sender, PaintEventArgs e)
        {

        }

        FireConnection conn = new FireConnection();
        private void btnSaveDriver_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = conn.Client.Get("/supplys/3ooEqZuHW7A5UpxgMYUu/");
            Driver obj = response.ResultAs<Driver>();

            textBoxNameDriver.Text = obj.Name;
        }
    }
}
