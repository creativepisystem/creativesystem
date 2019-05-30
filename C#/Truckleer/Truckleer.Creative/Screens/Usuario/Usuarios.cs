using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Creative.Screens.CustomEvent;
using Truckleer.Modules;

namespace Truckleer.Creative
{
    public partial class Usuarios : UserControl
    {
        public ChangeScreenEvent<User> ChangeScreenEvent { get; set; }
        public Usuarios()
        {
            InitializeComponent();
        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }
    }
}
