﻿using System;
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
using Truckleer.Creative.Screens.CustomEvent;

namespace Truckleer.Creative
{    
    public partial class ListarAbastecimentos : UserControl
    {
        public ChangeScreenEvent<Supply> ChangeScreenEvent { get; set; }
        private SupplyService supplyService;
        private List<Supply> supplys = new List<Supply>();
        
        public ListarAbastecimentos()
        {
            InitializeComponent();
            supplyService = new SupplyService();
            ChangeScreenEvent = new ChangeScreenEvent<Supply>();
            DatePickerInitial.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DatePickerFinal.Value = DateTime.Now;
        }
        public void ListarAbastecimentos_Load(object sender, EventArgs e)
        {
            
            this.Dock = DockStyle.Fill;
            supplyListWorker.RunWorkerAsync();
        }

        public void UpdateList()
        {
            ProgressBar.Visible = true;

            RemoveSupplyList();
            
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
            ChangeScreenEvent.Change(null);
        }       

        private void FilterSupply(object sender, DoWorkEventArgs e)
        {

            e.Result = supplyService.FindAll();
        }

        private void FilterSupplyFinish(object sender, RunWorkerCompletedEventArgs e)
        {
            ProgressBar.Visible = false;
            supplys = (List<Supply>)e.Result;
            supplys.Sort((a, b) =>( a.Date.CompareTo(b.Date)));
            RemoveSupplyList();
            for (int i = 0; i < supplys.Count; i++)
                ListPanel.Controls.Add(new CustomSupplyList(i, supplys[i],Edit,Delete));
        }
        private void Edit(Supply supply)
        {
            ChangeScreenEvent.Change(supply);
        }
        private void Delete(Supply supply)
        {
            //supplyService.Delete(supply);
        }

        private void RemoveSupplyList()
        {
            for(int i = ListPanel.Controls.Count -1; i > -1; i--)
            {
                if(ListPanel.Controls[i].GetType()  == typeof(CustomSupplyList))
                {
                    ListPanel.Controls.RemoveAt(i);
                }
            }
        }
    }    
}
