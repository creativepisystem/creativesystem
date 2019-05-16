using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truckleer.Creative
{
    public partial class Manutencao : UserControl
    {
        public Manutencao()
        {
            InitializeComponent();
        }

        private void Manutencao_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void RadioButtonPreventiva_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButtonCorretiva_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void PanelMaintence_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
