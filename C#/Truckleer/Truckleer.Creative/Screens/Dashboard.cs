using System;
using System.Windows.Forms;

namespace Truckleer.Creative
{
    public partial class Dashboard : UserControl
    {

        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;               
        }
    }
}
