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
    public partial class ListarMotoristas : UserControl
    {
        public ListarMotoristas()
        {
            InitializeComponent();
        }

        private void ListarMotoristas_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
