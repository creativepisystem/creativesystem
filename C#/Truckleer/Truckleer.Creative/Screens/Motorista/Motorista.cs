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

        private void PanelRightDriver_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void BtnSaveDriver_Click(object sender, EventArgs e)
        {

        }
    }
}
