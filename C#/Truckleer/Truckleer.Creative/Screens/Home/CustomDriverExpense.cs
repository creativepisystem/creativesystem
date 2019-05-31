using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;

namespace Truckleer.Creative.Screens.Home
{
    class CustomDriverExpenseList : Panel
    {
        //index - necessario
        readonly int index = 0;

        readonly DriverDTO driverDTO;

        public CustomDriverExpenseList(int index, DriverDTO driverDTO)
        {
            this.index = index;
            PanelBorderRow = new Panel();
            PanelRow = new Panel();
            LayoutRow = new TableLayoutPanel();
            PictureIcon = new PictureBox();
            LabelReceiveDriver = new Label();
            LabelReceiveSupply = new Label();
            LabelReceiveExpense = new Label();
            LabelReceiveTotal = new Label();
            PanelRow.SuspendLayout();
            LayoutRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(PictureIcon)).BeginInit();
            SuspendLayout();

            //Seta o Usuario
            this.driverDTO = driverDTO;
            InitializeCustomList();
        }

        private void InitializeCustomList()
        {
            // 
            // PanelBorderRow
            // 
            BackColor = System.Drawing.SystemColors.WindowText;
            Dock = DockStyle.Top;
            Location = new System.Drawing.Point(0, 62);
            Name = "PanelBorderRow";
            Size = new System.Drawing.Size(588, 5);
            TabIndex = 0;
            // 
            // PanelRow
            // 
            PanelRow.BackColor = System.Drawing.SystemColors.WindowFrame;
            PanelRow.Controls.Add(LayoutRow);
            PanelRow.Controls.Add(PanelBorderRow);
            PanelRow.Dock = DockStyle.Top;
            PanelRow.Location = new System.Drawing.Point(0, 0);
            PanelRow.Name = "PanelRow";
            PanelRow.Size = new System.Drawing.Size(588, 67);
            PanelRow.TabIndex = 0;
            // 
            // LayoutRow
            // 
            LayoutRow.ColumnCount = 5;
            LayoutRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            LayoutRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            LayoutRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            LayoutRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            LayoutRow.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            LayoutRow.Controls.Add(LabelReceiveTotal, 4, 0);
            LayoutRow.Controls.Add(LabelReceiveExpense, 3, 0);
            LayoutRow.Controls.Add(LabelReceiveSupply, 2, 0);
            LayoutRow.Controls.Add(PictureIcon, 0, 0);
            LayoutRow.Controls.Add(LabelReceiveDriver, 1, 0);
            LayoutRow.Dock = DockStyle.Fill;
            LayoutRow.Location = new System.Drawing.Point(0, 0);
            LayoutRow.Name = "LayoutRow";
            LayoutRow.RowCount = 1;
            LayoutRow.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LayoutRow.Size = new System.Drawing.Size(588, 62);
            LayoutRow.TabIndex = 1;
            // 
            // PictureIcon
            // 
            PictureIcon.Dock = DockStyle.Fill;
            PictureIcon.Image = Properties.Resources.driverSelectedMin;
            PictureIcon.Location = new System.Drawing.Point(3, 3);
            PictureIcon.Name = "PictureIcon";
            PictureIcon.Size = new System.Drawing.Size(52, 56);
            PictureIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            PictureIcon.TabIndex = 0;
            PictureIcon.TabStop = false;
            // 
            // LabelReceiveDriver
            // 
            LabelReceiveDriver.AutoSize = true;
            LabelReceiveDriver.Dock = DockStyle.Fill;
            LabelReceiveDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveDriver.ForeColor = System.Drawing.Color.Azure;
            LabelReceiveDriver.Location = new System.Drawing.Point(58, 0);
            LabelReceiveDriver.Margin = new Padding(0);
            LabelReceiveDriver.Name = "LabelReceiveDriver";
            LabelReceiveDriver.Size = new System.Drawing.Size(176, 62);
            LabelReceiveDriver.TabIndex = 1;
            LabelReceiveDriver.Text = driverDTO.Name;
            LabelReceiveDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveSupply
            // 
            LabelReceiveSupply.AutoSize = true;
            LabelReceiveSupply.Dock = DockStyle.Fill;
            LabelReceiveSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveSupply.ForeColor = System.Drawing.Color.Azure;
            LabelReceiveSupply.Location = new System.Drawing.Point(234, 0);
            LabelReceiveSupply.Margin = new Padding(0);
            LabelReceiveSupply.Name = "LabelReceiveSupply";
            LabelReceiveSupply.Size = new System.Drawing.Size(117, 62);
            LabelReceiveSupply.TabIndex = 2;
            LabelReceiveSupply.Text = $"R$ {string.Format("{0:0.00}",driverDTO.FuelTotal)}";
            LabelReceiveSupply.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveExpense
            // 
            LabelReceiveExpense.AutoSize = true;
            LabelReceiveExpense.Dock = DockStyle.Fill;
            LabelReceiveExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveExpense.ForeColor = System.Drawing.Color.Azure;
            LabelReceiveExpense.Location = new System.Drawing.Point(351, 0);
            LabelReceiveExpense.Margin = new Padding(0);
            LabelReceiveExpense.Name = "LabelReceiveExpense";
            LabelReceiveExpense.Size = new System.Drawing.Size(117, 62);
            LabelReceiveExpense.TabIndex = 3;
            LabelReceiveExpense.Text = $"R$ {string.Format("{0:0.00}", driverDTO.ExpenseTotal)}";
            LabelReceiveExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveTotal
            // 
            LabelReceiveTotal.AutoSize = true;
            LabelReceiveTotal.Dock = DockStyle.Fill;
            LabelReceiveTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveTotal.ForeColor = System.Drawing.Color.Azure;
            LabelReceiveTotal.Location = new System.Drawing.Point(468, 0);
            LabelReceiveTotal.Margin = new Padding(0);
            LabelReceiveTotal.Name = "LabelReceiveTotal";
            LabelReceiveTotal.Size = new System.Drawing.Size(120, 62);
            LabelReceiveTotal.TabIndex = 4;
            LabelReceiveTotal.Text = $"R$ {string.Format("{0:0.00}", driverDTO.FuelTotal + driverDTO.ExpenseTotal)}";
            LabelReceiveTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private readonly Panel PanelBorderRow;
        private Panel PanelRow;
        private TableLayoutPanel LayoutRow;
        private Label LabelReceiveTotal;
        private Label LabelReceiveExpense;
        private Label LabelReceiveSupply;
        private PictureBox PictureIcon;
        private Label LabelReceiveDriver;
    }
}
