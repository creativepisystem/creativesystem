using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truckleer.Creative.Screens.Despesas
{
    public partial class ListarDespesas : UserControl
    {
        public ListarDespesas()
        {
            InitializeComponent();
        }

        private void ListarDespesas_Load(object sender, EventArgs e)
        {
            Dock = DockStyle.Fill;
        }
    }
}
