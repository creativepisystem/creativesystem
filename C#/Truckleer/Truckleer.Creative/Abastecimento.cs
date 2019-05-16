using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Api.Classes;

namespace Truckleer.Creative
{
    public partial class Abastecimento : UserControl
    {
        public Supply Supply;

        public Abastecimento(Supply supply)
        {
            if(supply != null)
            {
                this.Supply = supply;
            }
            else
            {
                this.Supply = new Supply();
            }

            InitializeComponent();
        }

        private void Abastecimento_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBoxLitersSupply_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void BtnSaveSupply_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
