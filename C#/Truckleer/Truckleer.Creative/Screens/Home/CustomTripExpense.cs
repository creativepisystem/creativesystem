using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;

namespace Truckleer.Creative.Screens.Home
{
    class CustomTripExpenseList : Panel
    {
        //index - necessario
        readonly int index = 0;

        //Exemplo para classe Usuario
        readonly TripDTO tripDTO;
        private Action<Trip> Action;
        public CustomTripExpenseList(int index, TripDTO tripDTO, Action<Trip> Action)
        {
            this.index = index;
            PanelRowTrip = new Panel();
            panel2 = new Panel();
            LayoutHeaderTrip = new TableLayoutPanel();
            LabelReceiveTrip = new Label();
            LabelReceiveDriverTrip = new Label();
            LabelReceiveTripExpense = new Label();
            ButtonCloseTrip = new Button();
            SuspendLayout();
            LayoutHeaderTrip.SuspendLayout();
            SuspendLayout();

            //Seta o Usuario
            this.tripDTO = tripDTO;
            this.Action = Action;
            InitializeCustomList();
        }

        private void InitializeCustomList()
        {
            // 
            // PanelRowTrip
            // 
            BackColor = System.Drawing.SystemColors.WindowFrame;
            Controls.Add(LayoutHeaderTrip);
            Controls.Add(panel2);
            Dock = DockStyle.Top;
            Location = new System.Drawing.Point(0, 0);
            Name = "PanelRowTrip";
            Size = new System.Drawing.Size(510, 83);
            TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Black;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 81);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(910, 2);
            panel2.TabIndex = 0;
            // 
            // LayoutHeaderTrip
            // 
            LayoutHeaderTrip.ColumnCount = 4;
            LayoutHeaderTrip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.68902F));
            LayoutHeaderTrip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.8007F));
            LayoutHeaderTrip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.17929F));
            LayoutHeaderTrip.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 13.331F));
            LayoutHeaderTrip.Controls.Add(LabelReceiveTrip, 0, 0);
            LayoutHeaderTrip.Controls.Add(LabelReceiveDriverTrip, 1, 0);
            LayoutHeaderTrip.Controls.Add(LabelReceiveTripExpense, 2, 0);
            LayoutHeaderTrip.Controls.Add(ButtonCloseTrip, 3, 0);
            LayoutHeaderTrip.Dock = DockStyle.Fill;
            LayoutHeaderTrip.Location = new System.Drawing.Point(0, 0);
            LayoutHeaderTrip.Name = "LayoutHeaderTrip";
            LayoutHeaderTrip.RowCount = 1;
            LayoutHeaderTrip.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            LayoutHeaderTrip.Size = new System.Drawing.Size(510, 81);
            LayoutHeaderTrip.TabIndex = 4;
            // 
            // LabelReceiveTrip
            // 
            LabelReceiveTrip.AutoSize = true;
            LabelReceiveTrip.Dock = DockStyle.Fill;
            LabelReceiveTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveTrip.ForeColor = System.Drawing.Color.Azure;
            LabelReceiveTrip.Location = new System.Drawing.Point(3, 0);
            LabelReceiveTrip.Name = "LabelReceiveTrip";
            LabelReceiveTrip.Size = new System.Drawing.Size(135, 81);
            LabelReceiveTrip.TabIndex = 0;
            LabelReceiveTrip.Text = tripDTO.Trip.Name;
            LabelReceiveTrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveDriverTrip
            // 
            LabelReceiveDriverTrip.AutoSize = true;
            LabelReceiveDriverTrip.Dock = DockStyle.Fill;
            LabelReceiveDriverTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveDriverTrip.ForeColor = System.Drawing.Color.Azure;
            LabelReceiveDriverTrip.Location = new System.Drawing.Point(144, 0);
            LabelReceiveDriverTrip.Name = "LabelReceiveDriverTrip";
            LabelReceiveDriverTrip.Size = new System.Drawing.Size(191, 81);
            LabelReceiveDriverTrip.TabIndex = 1;
            LabelReceiveDriverTrip.Text = tripDTO.Trip.Driver.Name;
            LabelReceiveDriverTrip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelReceiveTripExpense
            // 
            LabelReceiveTripExpense.AutoSize = true;
            LabelReceiveTripExpense.Dock = DockStyle.Fill;
            LabelReceiveTripExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveTripExpense.ForeColor = System.Drawing.Color.Azure;
            LabelReceiveTripExpense.Location = new System.Drawing.Point(341, 0);
            LabelReceiveTripExpense.Name = "LabelReceiveTripExpense";
            LabelReceiveTripExpense.Size = new System.Drawing.Size(96, 81);
            LabelReceiveTripExpense.TabIndex = 2;
            LabelReceiveTripExpense.Text = $"R$ {string.Format("{0:0.00}", tripDTO.TotalExpense)}"; ;
            LabelReceiveTripExpense.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonCloseTrip
            // 
            ButtonCloseTrip.FlatAppearance.BorderSize = 0;
            ButtonCloseTrip.FlatStyle = FlatStyle.Flat;
            ButtonCloseTrip.Location = new System.Drawing.Point(443, 15);
            ButtonCloseTrip.Margin = new Padding(3, 15, 3, 3);
            ButtonCloseTrip.Name = "ButtonCloseTrip";
            ButtonCloseTrip.Size = new System.Drawing.Size(64, 53);
            ButtonCloseTrip.TabIndex = 3;
            ButtonCloseTrip.UseVisualStyleBackColor = true;
            ButtonCloseTrip.Click += new EventHandler(BtnCloseTrip_CLick);
        }

        private void BtnCloseTrip_CLick(object Sender, EventArgs args)
        {
            tripDTO.Trip.Status = TripStatus.FECHADA;
            Action.Invoke(tripDTO.Trip);
        }
        private readonly Panel PanelRowTrip;
        private Panel panel2;
        private TableLayoutPanel LayoutHeaderTrip;
        private Label LabelReceiveTrip;
        private Label LabelReceiveDriverTrip;
        private Label LabelReceiveTripExpense;
        private Button ButtonCloseTrip;
    }
}
