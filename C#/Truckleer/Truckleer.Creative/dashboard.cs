using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Truckleer.Creative
{
    public partial class Dashboard : UserControl
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "bs4keWmPRssX4EEigZ5cgpHNkRkxcPNtLuc6xlIb",
            BasePath = "https://creative-external-supply.firebaseio.com"
        };

        IFirebaseClient client;

        public Dashboard()
        {
            InitializeComponent();
            
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            this.Dock= DockStyle.Fill;

            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                
            }
                
        }

        private void panelGraph_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
