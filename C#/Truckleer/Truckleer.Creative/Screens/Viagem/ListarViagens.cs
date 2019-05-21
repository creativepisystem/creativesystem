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

namespace Truckleer.Creative.Screens.Viagem
{
    public partial class ListarViagens : UserControl
    {
        public ListarViagens()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
                LayoutRoute.Controls.Add(new CustomTripList(i, new Trip()));
        }

        private void ButtonCadastro_Click(object sender, EventArgs e)
        {

        }

        private void ListarViagens_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}
