using System;
using System.Collections.Generic;
using System.Drawing;
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
            ItemListDriver = new Panel();
            BorderPanel3 = new Panel();
            BorderPanel2 = new Panel();
            BorderPanel1 = new Panel();
            LabelReceiveDriver = new Label();
            LabelReceiveVehicle = new Label();
            LabelReceiveDate = new Label();
            LabelDriver = new Label();
            LabelVehicle = new Label();
            LabelDate = new Label();
            LabelRoute = new Label();
            TitleItemDriver = new Panel();
            LabelReceiveName = new Label();
            LabelName = new Label();
            panel1 = new Panel();
            LabelReceiveRoute = new Label();
            ButtonDelete = new Button();
            ButtonEdit = new Button();
            SuspendLayout();
            TitleItemDriver.SuspendLayout();
            SuspendLayout();


            //Seta o Usuario
            this.trip = trip;
            InitializeCustomList();
        }

        private void InitializeCustomList()
        {
            // 
            // ItemListDriver
            // 
            BackColor = System.Drawing.Color.LightGray;
            Controls.Add(panel1);
            Controls.Add(LabelReceiveRoute);
            Controls.Add(BorderPanel3);
            Controls.Add(BorderPanel2);
            Controls.Add(BorderPanel1);
            Controls.Add(LabelReceiveDriver);
            Controls.Add(LabelReceiveVehicle);
            Controls.Add(LabelReceiveDate);
            Controls.Add(LabelDriver);
            Controls.Add(LabelVehicle);
            Controls.Add(LabelDate);
            Controls.Add(LabelRoute);
            Controls.Add(TitleItemDriver);
            Location = new System.Drawing.Point(190, 62);
            Margin = new Padding(10, 20, 5, 0);
            Name = "ItemListDriver";
            Size = new System.Drawing.Size(355, 256);
            TabIndex = 1;
            // 
            // BorderPanel3
            // 
            BorderPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            BorderPanel3.Location = new System.Drawing.Point(94, 182);
            BorderPanel3.Name = "BorderPanel3";
            BorderPanel3.Size = new System.Drawing.Size(190, 1);
            BorderPanel3.TabIndex = 18;
            // 
            // BorderPanel2
            // 
            BorderPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            BorderPanel2.Location = new System.Drawing.Point(95, 143);
            BorderPanel2.Name = "BorderPanel2";
            BorderPanel2.Size = new System.Drawing.Size(100, 1);
            BorderPanel2.TabIndex = 16;
            // 
            // BorderPanel1
            // 
            BorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            BorderPanel1.Location = new System.Drawing.Point(68, 101);
            BorderPanel1.Name = "BorderPanel1";
            BorderPanel1.Size = new System.Drawing.Size(110, 1);
            BorderPanel1.TabIndex = 15;
            // 
            // LabelReceiveDriver
            // 
            LabelReceiveDriver.AutoSize = true;
            LabelReceiveDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveDriver.Location = new System.Drawing.Point(98, 166);
            LabelReceiveDriver.Name = "LabelReceiveDriver";
            LabelReceiveDriver.Size = new System.Drawing.Size(97, 17);
            LabelReceiveDriver.TabIndex = 11;
            LabelReceiveDriver.Text = "Felipe Goulart";
            // 
            // LabelReceiveVehicle
            // 
            LabelReceiveVehicle.AutoSize = true;
            LabelReceiveVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveVehicle.Location = new System.Drawing.Point(105, 124);
            LabelReceiveVehicle.Name = "LabelReceiveVehicle";
            LabelReceiveVehicle.Size = new System.Drawing.Size(67, 17);
            LabelReceiveVehicle.TabIndex = 9;
            LabelReceiveVehicle.Text = "XXX0000";
            // 
            // LabelReceiveDate
            // 
            LabelReceiveDate.AutoSize = true;
            LabelReceiveDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveDate.Location = new System.Drawing.Point(79, 83);
            LabelReceiveDate.Name = "LabelReceiveDate";
            LabelReceiveDate.Size = new System.Drawing.Size(80, 17);
            LabelReceiveDate.TabIndex = 8;
            LabelReceiveDate.Text = "22/04/2019";
            // 
            // LabelDriver
            // 
            LabelDriver.AutoSize = true;
            LabelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelDriver.Location = new System.Drawing.Point(11, 167);
            LabelDriver.Name = "LabelDriver";
            LabelDriver.Size = new System.Drawing.Size(80, 17);
            LabelDriver.TabIndex = 6;
            LabelDriver.Text = "Motorista:";
            // 
            // LabelVehicle
            // 
            LabelVehicle.AutoSize = true;
            LabelVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelVehicle.Location = new System.Drawing.Point(13, 127);
            LabelVehicle.Name = "LabelVehicle";
            LabelVehicle.Size = new System.Drawing.Size(71, 17);
            LabelVehicle.TabIndex = 3;
            LabelVehicle.Text = "Veículo: ";
            // 
            // LabelDate
            // 
            LabelDate.AutoSize = true;
            LabelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelDate.Location = new System.Drawing.Point(13, 86);
            LabelDate.Name = "LabelDate";
            LabelDate.Size = new System.Drawing.Size(47, 17);
            LabelDate.TabIndex = 2;
            LabelDate.Text = "Data:";
            // 
            // LabelRoute
            // 
            LabelRoute.AutoSize = true;
            LabelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelRoute.Location = new System.Drawing.Point(11, 210);
            LabelRoute.Name = "LabelRoute";
            LabelRoute.Size = new System.Drawing.Size(47, 17);
            LabelRoute.TabIndex = 1;
            LabelRoute.Text = "Rota:";
            // 
            // TitleItemDriver
            // 
            TitleItemDriver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            TitleItemDriver.Controls.Add(ButtonDelete);
            TitleItemDriver.Controls.Add(ButtonEdit);
            TitleItemDriver.Controls.Add(LabelReceiveName);
            TitleItemDriver.Controls.Add(LabelName);
            TitleItemDriver.Dock = DockStyle.Top;
            TitleItemDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            TitleItemDriver.ForeColor = System.Drawing.Color.Azure;
            TitleItemDriver.Location = new System.Drawing.Point(0, 0);
            TitleItemDriver.Name = "TitleItemDriver";
            TitleItemDriver.Size = new System.Drawing.Size(355, 67);
            TitleItemDriver.TabIndex = 0;
            // 
            // LabelReceiveName
            // 
            LabelReceiveName.AutoSize = true;
            LabelReceiveName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveName.Location = new System.Drawing.Point(107, 33);
            LabelReceiveName.Name = "LabelReceiveName";
            LabelReceiveName.Size = new System.Drawing.Size(82, 20);
            LabelReceiveName.TabIndex = 1;
            LabelReceiveName.Text = "São Paulo";
            // 
            // LabelName
            // 
            LabelName.AutoSize = true;
            LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelName.Location = new System.Drawing.Point(9, 28);
            LabelName.Name = "LabelName";
            LabelName.Size = new System.Drawing.Size(92, 25);
            LabelName.TabIndex = 0;
            LabelName.Text = "Viagem:";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            panel1.Location = new System.Drawing.Point(74, 225);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(190, 1);
            panel1.TabIndex = 20;
            // 
            // LabelReceiveRoute
            // 
            LabelReceiveRoute.AutoSize = true;
            LabelReceiveRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveRoute.Location = new System.Drawing.Point(81, 207);
            LabelReceiveRoute.Name = "LabelReceiveRoute";
            LabelReceiveRoute.Size = new System.Drawing.Size(73, 17);
            LabelReceiveRoute.TabIndex = 19;
            LabelReceiveRoute.Text = "São Paulo";
            // 
            // ButtonDelete
            // 
            ButtonDelete.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            ButtonDelete.BackgroundImage = Properties.Resources.delete;
            ButtonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonDelete.FlatAppearance.BorderSize = 0;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Location = new System.Drawing.Point(310, 18);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new System.Drawing.Size(25, 25);
            ButtonDelete.TabIndex = 110;
            ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Anchor = ((AnchorStyles)((AnchorStyles.Top | AnchorStyles.Right)));
            ButtonEdit.BackColor = System.Drawing.Color.Teal;
            ButtonEdit.BackgroundImage = Properties.Resources.editNote;
            ButtonEdit.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonEdit.FlatAppearance.BorderSize = 0;
            ButtonEdit.FlatStyle = FlatStyle.Flat;
            ButtonEdit.Location = new System.Drawing.Point(278, 18);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new System.Drawing.Size(25, 25);
            ButtonEdit.TabIndex = 109;
            ButtonEdit.UseVisualStyleBackColor = false;
        }

        private readonly Panel ItemListDriver;
        private Panel panel1;
        private Label LabelReceiveRoute;
        private Panel BorderPanel3;
        private Panel BorderPanel2;
        private Panel BorderPanel1;
        private Label LabelReceiveDriver;
        private Label LabelReceiveVehicle;
        private Label LabelReceiveDate;
        private Label LabelDriver;
        private Label LabelVehicle;
        private Label LabelDate;
        private Label LabelRoute;
        private Panel TitleItemDriver;
        private Label LabelReceiveName;
        private Label LabelName;
        private Button ButtonDelete;
        private Button ButtonEdit;
    }
}
