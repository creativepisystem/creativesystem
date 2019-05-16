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

        bool isCollapsed = false;
        private void TimerFilter_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                TitleFilter.Height += 40;
                if (TitleFilter.Size.Height == TitleFilter.MaximumSize.Height)
                {
                    timerFilter.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                TitleFilter.Height -= 40;
                if (TitleFilter.Size.Height == TitleFilter.MinimumSize.Height)
                {
                    timerFilter.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            timerFilter.Start();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void DateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
