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
    public partial class ListarAbastecimentos : UserControl
    {
        public ListarAbastecimentos()
        {
            InitializeComponent();
        }

        private void ListarAbastecimentos_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

       /* bool isCollapsed = false; 
        private void TimerFilter_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                filter.Height += 10;
                if (filter.Size.Height == filter.MaximumSize.Height)
                {
                    timerFilter.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                filter.Height -= 10;
                if (filter.Size.Height == filter.MinimumSize.Height)
                {
                    timerFilter.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            timerFilter.Start();
        }*/
    }
    
}
