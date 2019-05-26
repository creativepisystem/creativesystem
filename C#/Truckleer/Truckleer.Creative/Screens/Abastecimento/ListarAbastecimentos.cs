using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;
using Truckleer.Creative.Screens.Abastecimento;

namespace Truckleer.Creative
{    
    public partial class ListarAbastecimentos : UserControl
    {
        private SupplyService supplyService;
        private List<Supply> supplys = new List<Supply>();
        
        public ListarAbastecimentos()
        {
            InitializeComponent();
            supplyService = new SupplyService();
        }
        public void ListarAbastecimentos_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
            supplyListWorker.RunWorkerAsync();
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

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            supplyListWorker.RunWorkerAsync();
        }       
        private void FilterSupply(object sender, DoWorkEventArgs e)
        {
            e.Result = supplyService.FindAll();
        }
        private void FilterSupplyFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            
            supplys = (List<Supply>)e.Result;
            supplys.Sort((a, b) =>( a.Date.CompareTo(b.Date)));
            ListPanel.Controls.Clear();
            for (int i = 0; i < supplys.Count; i++)
                ListPanel.Controls.Add(new CustomSupplyList(i, supplys[i]));
        }
    }    
}
