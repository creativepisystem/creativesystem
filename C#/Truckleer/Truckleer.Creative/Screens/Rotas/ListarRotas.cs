using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Creative.Screens.Rotas;
using Truckleer.Modules;

namespace Truckleer.Creative
{
    public partial class ListarRotas : UserControl
    {
        public ListarRotas()
        {
            InitializeComponent();
            for (int i = 0; i < 20; i++)
                FlowRoute.Controls.Add(new CustomRouteList(i, new Route()));
        }
        
        private void ListarRotas_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void ButtonCadastro_Click(object sender, EventArgs e)
        {

        }

        private void ButtonFilter_Click(object sender, EventArgs e)
        {
            filtro.Start();
        }

        bool isCollapsed = false;
        private void Fdiltro_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                TitleFilter.Height += 40;
                if (TitleFilter.Size.Height == TitleFilter.MaximumSize.Height)
                {
                    filtro.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                TitleFilter.Height -= 40;
                if (TitleFilter.Size.Height == TitleFilter.MinimumSize.Height)
                {
                    filtro.Stop();
                    isCollapsed = true;
                }
            }
        }
    }
}
