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
    public partial class ListarManutencao : UserControl
    {
        public ListarManutencao()
        {
            InitializeComponent();
        }

        private void ListarManutencao_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        bool isCollapsed = true;
        private void TimerFiltro_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                filter.Height += 40;
                if (filter.Size.Height == filter.MaximumSize.Height)
                {
                    timerFiltro.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                filter.Height -= 40;
                if (filter.Size.Height == filter.MinimumSize.Height)
                {
                    timerFiltro.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timerFiltro.Start();
        }
    }
}
