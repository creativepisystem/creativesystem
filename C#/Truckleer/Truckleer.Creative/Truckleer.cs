using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Truckleer.Creative
{
    public partial class Truckleer : Form
    {
        public Truckleer()
        {
            InitializeComponent();
            Dashboard dash = new Dashboard();
            truckleerContainer.Controls.Add(dash);
            dash.BringToFront();
        }
    }
}
