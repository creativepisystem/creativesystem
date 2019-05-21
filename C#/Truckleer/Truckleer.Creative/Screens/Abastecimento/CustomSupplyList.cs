using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;

namespace Truckleer.Creative.Screens.Abastecimento
{
    class CustomSupplyList : Panel
    {
        //index - necessario
        readonly int index = 0;

        //Exemplo para classe Usuario
        readonly User user;

        public CustomSupplyList(int index, User user)
        {
            this.index = index;

            BorderPanel = new Panel();
            PanelHour = new Panel();
            PanelPlate = new Panel();
            PanelDriver = new Panel();
            PanelPrice = new Panel();
            PanelKm = new Panel();
            PanelRoute = new Panel();
            PanelStation = new Panel();
            PanelTotalPrice = new Panel();
            LabelListPlate = new Label();
            LabelListDriver = new Label();
            LabelListPrice = new Label();
            LabelListKm = new Label();
            LabelListRoute = new Label();
            LabelListTrip = new Label();
            LabelListLiters = new Label();
            PanelLiters = new Panel();
            PanelTrip = new Panel();
            LabelTotalPrice = new Label();
            LabelListStation = new Label();
            PanelButtons = new Panel();
            ButtonEdit = new Button();
            ButtonDelete = new Button();
            LabelListDate = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();

            //Seta o Usuario
            this.user = user;
            InitializeCustomList();
        }

        private void InitializeCustomList()
        {            
            //
            // PanelItemList
            //
            Controls.Add(tableLayoutPanel1);
            Controls.Add(BorderPanel);
            BackColor = System.Drawing.Color.Gray;
            Size = new System.Drawing.Size(904, 69);
            Dock = DockStyle.Top;
            Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            Location = new System.Drawing.Point(0, Height * index);
            Name = "PanelItemList";
            TabIndex = 0;
            //
            // BorderPanel
            // 
            BorderPanel.BackColor = System.Drawing.Color.RoyalBlue;
            BorderPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            BorderPanel.Location = new System.Drawing.Point(0, 66);
            BorderPanel.Name = "BorderPanel";
            BorderPanel.Size = new System.Drawing.Size(904, 3);
            BorderPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 11;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.08402F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.089F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.08902F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.092999F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.092253F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.0855F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.0806F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.080067F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.10006F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.09645F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.110038F));
            tableLayoutPanel1.Controls.Add(PanelTotalPrice, 8, 0);
            tableLayoutPanel1.Controls.Add(PanelStation, 7, 0);
            tableLayoutPanel1.Controls.Add(PanelRoute, 6, 0);
            tableLayoutPanel1.Controls.Add(PanelKm, 5, 0);
            tableLayoutPanel1.Controls.Add(PanelPrice, 4, 0);
            tableLayoutPanel1.Controls.Add(PanelLiters, 3, 0);
            tableLayoutPanel1.Controls.Add(PanelDriver, 2, 0);
            tableLayoutPanel1.Controls.Add(PanelPlate, 1, 0);
            tableLayoutPanel1.Controls.Add(PanelHour, 0, 0);
            tableLayoutPanel1.Controls.Add(PanelTrip, 9, 0);
            tableLayoutPanel1.Controls.Add(PanelButtons, 10, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new System.Drawing.Size(904, 66);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // PanelHour
            // 
            PanelHour.Controls.Add(LabelListDate);
            PanelHour.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelHour.Location = new System.Drawing.Point(0, 0);
            PanelHour.Margin = new System.Windows.Forms.Padding(0);
            PanelHour.Name = "PanelHour";
            PanelHour.Size = new System.Drawing.Size(100, 66);
            PanelHour.TabIndex = 0;
            // 
            // PanelPlate
            // 
            PanelPlate.Controls.Add(LabelListPlate);
            PanelPlate.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelPlate.Location = new System.Drawing.Point(100, 0);
            PanelPlate.Margin = new System.Windows.Forms.Padding(0);
            PanelPlate.Name = "PanelPlate";
            PanelPlate.Size = new System.Drawing.Size(82, 66);
            PanelPlate.TabIndex = 1;
            // 
            // PanelDriver
            // 
            PanelDriver.Controls.Add(LabelListDriver);
            PanelDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelDriver.Location = new System.Drawing.Point(182, 0);
            PanelDriver.Margin = new System.Windows.Forms.Padding(0);
            PanelDriver.Name = "PanelDriver";
            PanelDriver.Size = new System.Drawing.Size(91, 66);
            PanelDriver.TabIndex = 2;
            // 
            // PanelPrice
            // 
            PanelPrice.Controls.Add(LabelListPrice);
            PanelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelPrice.Location = new System.Drawing.Point(337, 0);
            PanelPrice.Margin = new System.Windows.Forms.Padding(0);
            PanelPrice.Name = "PanelPrice";
            PanelPrice.Size = new System.Drawing.Size(64, 66);
            PanelPrice.TabIndex = 4;
            // 
            // PanelKm
            // 
            PanelKm.Controls.Add(LabelListKm);
            PanelKm.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelKm.Location = new System.Drawing.Point(401, 0);
            PanelKm.Margin = new System.Windows.Forms.Padding(0);
            PanelKm.Name = "PanelKm";
            PanelKm.Size = new System.Drawing.Size(100, 66);
            PanelKm.TabIndex = 5;
            // 
            // PanelRoute
            // 
            PanelRoute.Controls.Add(LabelListRoute);
            PanelRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelRoute.Location = new System.Drawing.Point(501, 0);
            PanelRoute.Margin = new System.Windows.Forms.Padding(0);
            PanelRoute.Name = "PanelRoute";
            PanelRoute.Size = new System.Drawing.Size(91, 66);
            PanelRoute.TabIndex = 6;
            // 
            // PanelStation
            // 
            PanelStation.Controls.Add(LabelListStation);
            PanelStation.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelStation.Location = new System.Drawing.Point(592, 0);
            PanelStation.Margin = new System.Windows.Forms.Padding(0);
            PanelStation.Name = "PanelStation";
            PanelStation.Size = new System.Drawing.Size(82, 66);
            PanelStation.TabIndex = 7;
            // 
            // PanelTotalPrice
            // 
            PanelTotalPrice.Controls.Add(LabelTotalPrice);
            PanelTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelTotalPrice.Location = new System.Drawing.Point(674, 0);
            PanelTotalPrice.Margin = new System.Windows.Forms.Padding(0);
            PanelTotalPrice.Name = "PanelTotalPrice";
            PanelTotalPrice.Size = new System.Drawing.Size(82, 66);
            PanelTotalPrice.TabIndex = 8;
            // 
            // LabelListPlate
            // 
            LabelListPlate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            LabelListPlate.AutoSize = true;
            LabelListPlate.Location = new System.Drawing.Point(6, 27);
            LabelListPlate.Name = "LabelListPlate";
            LabelListPlate.Size = new System.Drawing.Size(67, 17);
            LabelListPlate.TabIndex = 1;
            LabelListPlate.Text = "XXX0000";
            // 
            // LabelListDriver
            // 
            LabelListDriver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            LabelListDriver.Location = new System.Drawing.Point(5, 12);
            LabelListDriver.Name = "LabelListDriver";
            LabelListDriver.Size = new System.Drawing.Size(83, 40);
            LabelListDriver.TabIndex = 1;
            LabelListDriver.Text = "Jefferson Dias";
            LabelListDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelListPrice
            // 
            LabelListPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            LabelListPrice.AutoSize = true;
            LabelListPrice.Location = new System.Drawing.Point(14, 26);
            LabelListPrice.Name = "LabelListPrice";
            LabelListPrice.Size = new System.Drawing.Size(36, 17);
            LabelListPrice.TabIndex = 1;
            LabelListPrice.Text = "3,50";
            // 
            // LabelListKm
            // 
            LabelListKm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            LabelListKm.AutoSize = true;
            LabelListKm.Location = new System.Drawing.Point(20, 26);
            LabelListKm.Name = "LabelListKm";
            LabelListKm.Size = new System.Drawing.Size(56, 17);
            LabelListKm.TabIndex = 1;
            LabelListKm.Text = "132785";
            // 
            // LabelListRoute
            // 
            LabelListRoute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            LabelListRoute.AutoSize = true;
            LabelListRoute.Location = new System.Drawing.Point(10, 26);
            LabelListRoute.Name = "LabelListRoute";
            LabelListRoute.Size = new System.Drawing.Size(70, 17);
            LabelListRoute.TabIndex = 1;
            LabelListRoute.Text = "Campinas";
            // 
            // LabelListTrip
            // 
            LabelListTrip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            LabelListTrip.AutoSize = true;
            LabelListTrip.Location = new System.Drawing.Point(12, 24);
            LabelListTrip.Name = "LabelListTrip";
            LabelListTrip.Size = new System.Drawing.Size(70, 17);
            LabelListTrip.TabIndex = 1;
            LabelListTrip.Text = "Campinas";
            // 
            // LabelListLiters
            // 
            LabelListLiters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            LabelListLiters.AutoSize = true;
            LabelListLiters.Location = new System.Drawing.Point(14, 26);
            LabelListLiters.Name = "LabelListLiters";
            LabelListLiters.Size = new System.Drawing.Size(32, 17);
            LabelListLiters.TabIndex = 1;
            LabelListLiters.Text = "140";
            // 
            // PanelLiters
            // 
            PanelLiters.Controls.Add(LabelListLiters);
            PanelLiters.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelLiters.Location = new System.Drawing.Point(273, 0);
            PanelLiters.Margin = new System.Windows.Forms.Padding(0);
            PanelLiters.Name = "PanelLiters";
            PanelLiters.Size = new System.Drawing.Size(64, 66);
            PanelLiters.TabIndex = 3;
            // 
            // PanelTrip
            // 
            PanelTrip.Controls.Add(LabelListTrip);
            PanelTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelTrip.Location = new System.Drawing.Point(756, 0);
            PanelTrip.Margin = new System.Windows.Forms.Padding(0);
            PanelTrip.Name = "PanelTrip";
            PanelTrip.Size = new System.Drawing.Size(100, 66);
            PanelTrip.TabIndex = 9;
            // 
            // LabelTotalPrice
            // 
            LabelTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            LabelTotalPrice.AutoSize = true;
            LabelTotalPrice.Location = new System.Drawing.Point(12, 27);
            LabelTotalPrice.Name = "LabelTotalPrice";
            LabelTotalPrice.Size = new System.Drawing.Size(52, 17);
            LabelTotalPrice.TabIndex = 2;
            LabelTotalPrice.Text = "150,20";
            // 
            // LabelListStation
            // 
            LabelListStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            LabelListStation.Location = new System.Drawing.Point(10, 14);
            LabelListStation.Name = "LabelListStation";
            LabelListStation.Size = new System.Drawing.Size(65, 40);
            LabelListStation.TabIndex = 2;
            LabelListStation.Text = "Shell";
            LabelListStation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelButtons
            // 
            PanelButtons.Controls.Add(ButtonDelete);
            PanelButtons.Controls.Add(ButtonEdit);
            PanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelButtons.Location = new System.Drawing.Point(859, 3);
            PanelButtons.Name = "PanelButtons";
            PanelButtons.Size = new System.Drawing.Size(42, 60);
            PanelButtons.TabIndex = 10;
            // 
            // ButtonEdit
            // 
            ButtonEdit.BackColor = System.Drawing.Color.Teal;
            ButtonEdit.Dock = System.Windows.Forms.DockStyle.Top;
            ButtonEdit.FlatAppearance.BorderSize = 0;
            ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonEdit.Location = new System.Drawing.Point(0, 0);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new System.Drawing.Size(42, 23);
            ButtonEdit.TabIndex = 11;
            ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // ButtonDelete
            // 
            ButtonDelete.BackColor = System.Drawing.Color.Firebrick;
            ButtonDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            ButtonDelete.FlatAppearance.BorderSize = 0;
            ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonDelete.Location = new System.Drawing.Point(0, 37);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new System.Drawing.Size(42, 23);
            ButtonDelete.TabIndex = 12;
            ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // LabelListDate
            // 
            LabelListDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            LabelListDate.Location = new System.Drawing.Point(3, 14);
            LabelListDate.Name = "LabelListDate";
            LabelListDate.Size = new System.Drawing.Size(94, 41);
            LabelListDate.TabIndex = 2;
            LabelListDate.Text = "dd/mm/aaaa 00:00";
            LabelListDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private Panel BorderPanel;
        private Panel PanelHour;
        private Panel PanelPlate;
        private Panel PanelDriver;
        private Panel PanelPrice;
        private Panel PanelKm;
        private Panel PanelRoute;
        private Panel PanelStation;
        private Panel PanelTotalPrice;
        private Label LabelListPlate;
        private Label LabelListDriver;
        private Label LabelListPrice;
        private Label LabelListKm;
        private Label LabelListRoute;
        private Label LabelListTrip;
        private Label LabelListLiters;
        private Panel PanelLiters;
        private Panel PanelTrip;
        private Label LabelTotalPrice;
        private Label LabelListStation;
        private Panel PanelButtons;
        private Button ButtonEdit;
        private Button ButtonDelete;
        private Label LabelListDate;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
