using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;

namespace Truckleer.Creative.Screens.Viagem
{
    class CustomTripList : Panel
    {
        //index - necessario
        readonly int index = 0;

        //Exemplo para classe Usuario
        readonly Trip trip;

        public CustomTripList(int index, Trip trip)
        {
            this.index = index;

            PanelItemList = new Panel();
            panel2 = new Panel();
            LayoutList = new TableLayoutPanel();
            PanelButtons = new Panel();
            ButtonDelete = new Button();
            ButonEdit = new Button();
            PanelRoute = new Panel();
            LabelRoute = new Label();
            PanelDriver = new Panel();
            LabelDriver = new Label();
            PanelVehicle = new Panel();
            LabelVehicle = new Label();
            PanelTrip = new Panel();
            LabelTrip = new Label();
            PanelData = new Panel();
            LabelData = new Label();
            SuspendLayout();
            LayoutList.SuspendLayout();
            PanelButtons.SuspendLayout();
            PanelRoute.SuspendLayout();
            PanelDriver.SuspendLayout();
            PanelVehicle.SuspendLayout();
            PanelTrip.SuspendLayout();
            PanelData.SuspendLayout();
            SuspendLayout();


            //Seta o Usuario
            this.trip = trip;
            InitializeCustomList();
        }

        private void InitializeCustomList()
        {
            // 
            // PanelItemList
            // 
            BackColor = System.Drawing.Color.LightGray;
            Controls.Add(LayoutList);
            Controls.Add(panel2);
            Location = new System.Drawing.Point(0, 0);
            Name = "PanelItemList";
            Size = new System.Drawing.Size(704, 100);
            Height = 100;
            Dock = DockStyle.Top;
            TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 98);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(704, 2);
            panel2.TabIndex = 0;
            // 
            // LayoutList
            // 
            LayoutList.ColumnCount = 6;
            LayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33173F));
            LayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.3301F));
            LayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.33938F));
            LayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.32996F));
            LayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.33924F));
            LayoutList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.32957F));
            LayoutList.Controls.Add(PanelButtons, 5, 0);
            LayoutList.Controls.Add(PanelRoute, 4, 0);
            LayoutList.Controls.Add(PanelDriver, 3, 0);
            LayoutList.Controls.Add(PanelVehicle, 2, 0);
            LayoutList.Controls.Add(PanelTrip, 1, 0);
            LayoutList.Controls.Add(PanelData, 0, 0);
            LayoutList.Dock = System.Windows.Forms.DockStyle.Fill;
            LayoutList.Location = new System.Drawing.Point(0, 0);
            LayoutList.Name = "LayoutList";
            LayoutList.RowCount = 1;
            LayoutList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            LayoutList.Size = new System.Drawing.Size(704, 98);
            LayoutList.TabIndex = 1;
            // 
            // PanelButtons
            // 
            PanelButtons.Controls.Add(ButtonDelete);
            PanelButtons.Controls.Add(ButonEdit);
            PanelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelButtons.Location = new System.Drawing.Point(630, 0);
            PanelButtons.Margin = new System.Windows.Forms.Padding(0);
            PanelButtons.Name = "PanelButtons";
            PanelButtons.Size = new System.Drawing.Size(74, 98);
            PanelButtons.TabIndex = 5;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            ButtonDelete.FlatAppearance.BorderSize = 0;
            ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonDelete.Location = new System.Drawing.Point(8, 53);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new System.Drawing.Size(63, 39);
            ButtonDelete.TabIndex = 2;
            ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // ButonEdit
            // 
            ButonEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Right)));
            ButonEdit.BackColor = System.Drawing.Color.Teal;
            ButonEdit.FlatAppearance.BorderSize = 0;
            ButonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButonEdit.Location = new System.Drawing.Point(8, 7);
            ButonEdit.Name = "ButonEdit";
            ButonEdit.Size = new System.Drawing.Size(63, 39);
            ButonEdit.TabIndex = 1;
            ButonEdit.UseVisualStyleBackColor = false;
            // 
            // PanelRoute
            // 
            PanelRoute.Controls.Add(LabelRoute);
            PanelRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelRoute.Location = new System.Drawing.Point(501, 0);
            PanelRoute.Margin = new System.Windows.Forms.Padding(0);
            PanelRoute.Name = "PanelRoute";
            PanelRoute.Size = new System.Drawing.Size(129, 98);
            PanelRoute.TabIndex = 4;
            // 
            // LabelRoute
            // 
            LabelRoute.Dock = System.Windows.Forms.DockStyle.Fill;
            LabelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelRoute.Location = new System.Drawing.Point(0, 0);
            LabelRoute.Name = "LabelRoute";
            LabelRoute.Size = new System.Drawing.Size(129, 98);
            LabelRoute.TabIndex = 3;
            LabelRoute.Text = "São Paulo";
            LabelRoute.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelDriver
            // 
            PanelDriver.Controls.Add(LabelDriver);
            PanelDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelDriver.Location = new System.Drawing.Point(358, 0);
            PanelDriver.Margin = new System.Windows.Forms.Padding(0);
            PanelDriver.Name = "PanelDriver";
            PanelDriver.Size = new System.Drawing.Size(143, 98);
            PanelDriver.TabIndex = 3;
            // 
            // LabelDriver
            // 
            LabelDriver.Dock = System.Windows.Forms.DockStyle.Fill;
            LabelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelDriver.Location = new System.Drawing.Point(0, 0);
            LabelDriver.Name = "LabelDriver";
            LabelDriver.Size = new System.Drawing.Size(143, 98);
            LabelDriver.TabIndex = 3;
            LabelDriver.Text = "Felipe Creative Corp";
            LabelDriver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelVehicle
            // 
            PanelVehicle.Controls.Add(LabelVehicle);
            PanelVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelVehicle.Location = new System.Drawing.Point(243, 0);
            PanelVehicle.Margin = new System.Windows.Forms.Padding(0);
            PanelVehicle.Name = "PanelVehicle";
            PanelVehicle.Size = new System.Drawing.Size(115, 98);
            PanelVehicle.TabIndex = 2;
            // 
            // LabelVehicle
            // 
            LabelVehicle.Dock = System.Windows.Forms.DockStyle.Fill;
            LabelVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelVehicle.Location = new System.Drawing.Point(0, 0);
            LabelVehicle.Name = "LabelVehicle";
            LabelVehicle.Size = new System.Drawing.Size(115, 98);
            LabelVehicle.TabIndex = 2;
            LabelVehicle.Text = "EPY9100";
            LabelVehicle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelTrip
            // 
            PanelTrip.Controls.Add(LabelTrip);
            PanelTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelTrip.Location = new System.Drawing.Point(114, 0);
            PanelTrip.Margin = new System.Windows.Forms.Padding(0);
            PanelTrip.Name = "PanelTrip";
            PanelTrip.Size = new System.Drawing.Size(129, 98);
            PanelTrip.TabIndex = 1;
            // 
            // LabelTrip
            // 
            LabelTrip.Dock = System.Windows.Forms.DockStyle.Fill;
            LabelTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelTrip.Location = new System.Drawing.Point(0, 0);
            LabelTrip.Name = "LabelTrip";
            LabelTrip.Size = new System.Drawing.Size(129, 98);
            LabelTrip.TabIndex = 1;
            LabelTrip.Text = "Santana de Pernaíba";
            LabelTrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelData
            // 
            PanelData.Controls.Add(LabelData);
            PanelData.Dock = System.Windows.Forms.DockStyle.Fill;
            PanelData.Location = new System.Drawing.Point(0, 0);
            PanelData.Margin = new System.Windows.Forms.Padding(0);
            PanelData.Name = "PanelData";
            PanelData.Size = new System.Drawing.Size(114, 98);
            PanelData.TabIndex = 0;
            // 
            // LabelData
            // 
            LabelData.Dock = System.Windows.Forms.DockStyle.Fill;
            LabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelData.Location = new System.Drawing.Point(0, 0);
            LabelData.Name = "LabelData";
            LabelData.Size = new System.Drawing.Size(114, 98);
            LabelData.TabIndex = 0;
            LabelData.Text = "18/05/2019 00:00";
            LabelData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        }

        private readonly Panel PanelItemList;
        private TableLayoutPanel LayoutList;
        private Panel PanelButtons;
        private Button ButtonDelete;
        private Button ButonEdit;
        private Panel PanelRoute;
        private Label LabelRoute;
        private Panel PanelDriver;
        private Label LabelDriver;
        private Panel PanelVehicle;
        private Label LabelVehicle;
        private Panel PanelTrip;
        private Label LabelTrip;
        private Panel PanelData;
        private Label LabelData;
        private Panel panel2;
    }
}
