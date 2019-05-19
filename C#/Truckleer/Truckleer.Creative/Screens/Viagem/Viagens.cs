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
    public partial class Viagens : UserControl
    {
        public Viagens()
        {
            InitializeComponent();
        }

        private void Viagens_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
