﻿using System;
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
    public partial class ListarVeiculos : UserControl
    {
        public ListarVeiculos()
        {
            InitializeComponent();
        }

        private void ListarVeiculos_Load_1(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        bool isCollapsed = false;
        private void filtro_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                filter.Height += 10;
                if(filter.Size.Height == filter.MaximumSize.Height)
                {
                    filtro.Stop();
                    isCollapsed = false;
                }
            }
            else
            {
                filter.Height -= 10;
                if(filter.Size.Height == filter.MinimumSize.Height)
                {
                    filtro.Stop();
                    isCollapsed = true;
                }
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            filtro.Start();
        }
    }
}