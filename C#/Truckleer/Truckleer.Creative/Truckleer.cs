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
        Abastecimento supply = new Abastecimento();
        Dashboard dash = new Dashboard();
        Motorista driver = new Motorista();
        Veiculos vehicle = new Veiculos();
        Rotas route = new Rotas();
        Manutencao maintence = new Manutencao();
        Viagens trip = new Viagens();

        public Truckleer()
        {
            InitializeComponent();
            truckleerCallcontainer.Controls.Add(dash);
            dash.BringToFront();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool supplyIsCollapsed;
        private void supplyTimer_Tick(object sender, EventArgs e)
        {
            if (supplyIsCollapsed)
            {
                groupSupply.Height += 10;
                if(groupSupply.Size.Height == groupSupply.MaximumSize.Height)
                {
                    supplyTimer.Stop();
                    supplyIsCollapsed = false;
                }
            }
            else
            {
                groupSupply.Height -= 10;
                if(groupSupply.Size.Height == groupSupply.MinimumSize.Height)
                {
                    supplyTimer.Stop();
                    supplyIsCollapsed = true;
                }
            }
        }

        private void btnAbastecimento_Click(object sender, EventArgs e)
        {
            supplyTimer.Start();
        }

        private void btnAbastecer_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(supply);
            supply.BringToFront();
        }

        private void btnDash_Click(object sender, EventArgs e)
        {
            truckleerCallcontainer.Controls.Clear();
            truckleerCallcontainer.Controls.Add(dash);
            dash.BringToFront();
        }
    }
}
