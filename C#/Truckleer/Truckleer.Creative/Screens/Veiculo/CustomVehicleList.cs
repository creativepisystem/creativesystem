using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Truckleer.Modules;

namespace Truckleer.Creative.Screens.Veiculo
{
    class CustomVehicleList : Panel
    {
        readonly int index = 0;

        readonly Vehicle vehicle;

        
        public CustomVehicleList(int index, Vehicle vehicle)
        {
            this.index = index;

            PanelPost = new Panel();
            PanelSide = new Panel();
            LabelReceivePlaca = new Label();
            LabelPlaca = new Label();
            LabelBrand = new Label();
            LabelModel = new Label();
            LabelColor = new Label();
            LabelYearFab = new Label();
            LabelTank = new Label();
            LabelChassi = new Label();
            BorderPanel1 = new Panel();
            BorderPanel2 = new Panel();
            BorderPanel3 = new Panel();
            BordePanel4 = new Panel();
            BorderPanel5 = new Panel();
            BorderPanel6 = new Panel();
            LabelReceiveBrand = new Label();
            LabelReceiveModel = new Label();
            LabelReceiveColor = new Label();
            LabelReceiveYear = new Label();
            LabelReceiveChassi = new Label();
            LabelReceiveTank = new Label();
            ButtonEdit = new Button();
            ButtonDelete = new Button();



            pictureBox1 = new PictureBox();           
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();
            PanelSide.SuspendLayout();
            SuspendLayout();
            pictureBox1.Image = Properties.Resources.truckList;
            pictureBox1.Location = new Point(15, 1);

            this.vehicle = vehicle;
            InitializeVehicleList();

        }

        public void InitializeVehicleList()
        {            
            // 
            // PanelPost
            // 
            BackColor = Color.LightGray;
            Controls.Add(LabelReceiveTank);
            Controls.Add(LabelReceiveChassi);
            Controls.Add(LabelReceiveYear);
            Controls.Add(LabelReceiveColor);
            Controls.Add(LabelReceiveModel);
            Controls.Add(LabelReceiveBrand);
            Controls.Add(BorderPanel6);
            Controls.Add(BorderPanel5);
            Controls.Add(BordePanel4);
            Controls.Add(BorderPanel3);
            Controls.Add(BorderPanel2);
            Controls.Add(BorderPanel1);
            Controls.Add(LabelChassi);
            Controls.Add(LabelTank);
            Controls.Add(LabelYearFab);
            Controls.Add(LabelColor);
            Controls.Add(LabelModel);
            Controls.Add(LabelBrand);
            Controls.Add(PanelSide);
            Location = new Point(1, 1);
            Margin = new Padding(3, 15, 3, 0);
            Name = "PanelPost";
            Size = new System.Drawing.Size(365, 204);
            TabIndex = 0;
            // 
            // PanelSide
            // 
            PanelSide.BackColor = System.Drawing.Color.Firebrick;
            PanelSide.Controls.Add(LabelPlaca);
            PanelSide.Controls.Add(pictureBox1);
            PanelSide.Controls.Add(LabelReceivePlaca);
            PanelSide.Controls.Add(ButtonEdit);
            PanelSide.Controls.Add(ButtonDelete);
            PanelSide.Dock = DockStyle.Left;
            PanelSide.Location = new System.Drawing.Point(0, 0);
            PanelSide.Name = "PanelSide";
            PanelSide.Size = new System.Drawing.Size(125, 204);
            PanelSide.TabIndex = 1;
            pictureBox1.Height = 100;
            pictureBox1.Width = 100;
            
            // 
            // LabelReceivePlaca
            // 
            LabelReceivePlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceivePlaca.Location = new System.Drawing.Point(4, 128);
            LabelReceivePlaca.Name = "LabelReceivePlaca";
            LabelReceivePlaca.RightToLeft = RightToLeft.Yes;
            LabelReceivePlaca.ForeColor = System.Drawing.Color.Azure;
            LabelReceivePlaca.Size = new System.Drawing.Size(118, 28);
            LabelReceivePlaca.TabIndex = 0;
            LabelReceivePlaca.Text = vehicle.License_plate.ToString();
            // 
            // LabelPlaca
            // 
            LabelPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelPlaca.Location = new System.Drawing.Point(29, 100);
            LabelPlaca.ForeColor = System.Drawing.Color.Azure;
            LabelPlaca.Name = "LabelPlaca";
            LabelPlaca.Size = new System.Drawing.Size(62, 28);
            LabelPlaca.TabIndex = 1;
            LabelPlaca.Text = "Placa";
            // 
            // LabelBrand
            // 
            LabelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelBrand.Location = new System.Drawing.Point(131, 18);
            LabelBrand.Name = "LabelBrand";
            LabelBrand.Size = new System.Drawing.Size(62, 20);
            LabelBrand.TabIndex = 2;
            LabelBrand.Text = "Marca";
            // 
            // LabelModel
            // 
            LabelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelModel.Location = new System.Drawing.Point(131, 48);
            LabelModel.Name = "LabelModel";
            LabelModel.Size = new System.Drawing.Size(62, 20);
            LabelModel.TabIndex = 9;
            LabelModel.Text = "Modelo";
            // 
            // LabelColor
            // 
            LabelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelColor.Location = new System.Drawing.Point(131, 77);
            LabelColor.Name = "LabelColor";
            LabelColor.Size = new System.Drawing.Size(43, 20);
            LabelColor.TabIndex = 10;
            LabelColor.Text = "Cor";
            // 
            // LabelYearFab
            // 
            LabelYearFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelYearFab.Location = new System.Drawing.Point(131, 107);
            LabelYearFab.Name = "LabelYearFab";
            LabelYearFab.Size = new System.Drawing.Size(74, 20);
            LabelYearFab.TabIndex = 11;
            LabelYearFab.Text = "Ano Fab.";
            // 
            // LabelTank
            // 
            LabelTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelTank.Location = new System.Drawing.Point(133, 166);
            LabelTank.Name = "LabelTank";
            LabelTank.Size = new System.Drawing.Size(72, 23);
            LabelTank.TabIndex = 12;
            LabelTank.Text = "Tanque";
            LabelTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelChassi
            // 
            LabelChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelChassi.Location = new System.Drawing.Point(131, 137);
            LabelChassi.Name = "LabelChassi";
            LabelChassi.Size = new System.Drawing.Size(62, 20);
            LabelChassi.TabIndex = 13;
            LabelChassi.Text = "Chassi";
            // 
            // BorderPanel1
            // 
            BorderPanel1.BackColor = System.Drawing.Color.Firebrick;
            BorderPanel1.Location = new System.Drawing.Point(185, 36);
            BorderPanel1.Name = "BorderPanel1";
            BorderPanel1.Size = new System.Drawing.Size(169, 1);
            BorderPanel1.TabIndex = 93;
            // 
            // BorderPanel2
            // 
            BorderPanel2.BackColor = System.Drawing.Color.Firebrick;
            BorderPanel2.Location = new System.Drawing.Point(185, 66);
            BorderPanel2.Name = "BorderPanel2";
            BorderPanel2.Size = new System.Drawing.Size(169, 1);
            BorderPanel2.TabIndex = 94;
            // 
            // BorderPanel3
            // 
            BorderPanel3.BackColor = System.Drawing.Color.Firebrick;
            BorderPanel3.Location = new System.Drawing.Point(185, 95);
            BorderPanel3.Name = "BorderPanel3";
            BorderPanel3.Size = new System.Drawing.Size(169, 1);
            BorderPanel3.TabIndex = 95;
            // 
            // BordePanel4
            // 
            BordePanel4.BackColor = System.Drawing.Color.Firebrick;
            BordePanel4.Location = new System.Drawing.Point(201, 125);
            BordePanel4.Name = "BordePanel4";
            BordePanel4.Size = new System.Drawing.Size(97, 1);
            BordePanel4.TabIndex = 96;
            // 
            // BorderPanel5
            // 
            BorderPanel5.BackColor = System.Drawing.Color.Firebrick;
            BorderPanel5.Location = new System.Drawing.Point(185, 156);
            BorderPanel5.Name = "BorderPanel5";
            BorderPanel5.Size = new System.Drawing.Size(169, 1);
            BorderPanel5.TabIndex = 97;
            // 
            // BorderPanel6
            // 
            BorderPanel6.BackColor = System.Drawing.Color.Firebrick;
            BorderPanel6.Location = new System.Drawing.Point(237, 187);
            BorderPanel6.Name = "BorderPanel6";
            BorderPanel6.Size = new System.Drawing.Size(97, 1);
            BorderPanel6.TabIndex = 98;
            // 
            // LabelReceiveBrand
            // 
            LabelReceiveBrand.AutoSize = true;
            LabelReceiveBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveBrand.Location = new System.Drawing.Point(186, 17);
            LabelReceiveBrand.Name = "LabelReceiveBrand";
            LabelReceiveBrand.Size = new System.Drawing.Size(37, 17);
            LabelReceiveBrand.TabIndex = 99;
            LabelReceiveBrand.Text = vehicle.Brand;
            // 
            // LabelReceiveModel
            // 
            LabelReceiveModel.AutoSize = true;
            LabelReceiveModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveModel.Location = new System.Drawing.Point(188, 47);
            LabelReceiveModel.Name = "LabelReceiveModel";
            LabelReceiveModel.Size = new System.Drawing.Size(74, 17);
            LabelReceiveModel.TabIndex = 100;
            LabelReceiveModel.Text = vehicle.Model;
            // 
            // LabelReceiveColor
            // 
            LabelReceiveColor.AutoSize = true;
            LabelReceiveColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveColor.Location = new System.Drawing.Point(182, 77);
            LabelReceiveColor.Name = "LabelReceiveColor";
            LabelReceiveColor.Size = new System.Drawing.Size(60, 17);
            LabelReceiveColor.TabIndex = 101;
            switch (vehicle.Color)
            {
                case VehicleColor.AMARELO:
                    LabelReceiveColor.Text = "Amarelo";
                    break;

                case VehicleColor.AZUL:
                    LabelReceiveColor.Text = "Azul";
                    break;

                case VehicleColor.BRANCO:
                    LabelReceiveColor.Text = "Branco";
                    break;

                case VehicleColor.CINZA:
                    LabelReceiveColor.Text = "Cinza";
                    break;

                case VehicleColor.MARROM:
                    LabelReceiveColor.Text = "Marrom";
                    break;

                case VehicleColor.PRETO:
                    LabelReceiveColor.Text = "Preto";
                    break;

                case VehicleColor.VERDE:
                    LabelReceiveColor.Text = "Verde";
                    break;

                case VehicleColor.VERMELHO:
                    LabelReceiveColor.Text = "Vermelho";
                    break;
            }
            // 
            // LabelReceiveYear
            // 
            LabelReceiveYear.AutoSize = true;
            LabelReceiveYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveYear.Location = new System.Drawing.Point(214, 107);
            LabelReceiveYear.Name = "LabelReceiveYear";
            LabelReceiveYear.Size = new System.Drawing.Size(40, 17);
            LabelReceiveYear.TabIndex = 102;
            LabelReceiveYear.Text = vehicle.Fab_Year.ToString();
            // 
            // LabelReceiveChassi
            // 
            LabelReceiveChassi.AutoSize = true;
            LabelReceiveChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveChassi.Location = new System.Drawing.Point(188, 137);
            LabelReceiveChassi.Name = "LabelReceiveChassi";
            LabelReceiveChassi.Size = new System.Drawing.Size(126, 17);
            LabelReceiveChassi.TabIndex = 103;
            LabelReceiveChassi.Text = vehicle.Chassi ?? "-";
            // 
            // LabelReceiveTank
            // 
            LabelReceiveTank.AutoSize = true;
            LabelReceiveTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveTank.Location = new System.Drawing.Point(258, 167);
            LabelReceiveTank.Name = "LabelReceiveTank";
            LabelReceiveTank.Size = new System.Drawing.Size(32, 17);
            LabelReceiveTank.TabIndex = 104;
            LabelReceiveTank.Text = vehicle.Tank_capacity.ToString();
            // 
            // ButtonEdit
            // 
            ButtonEdit.Anchor = (AnchorStyles.Bottom | AnchorStyles.Right);
            ButtonEdit.BackColor = System.Drawing.Color.Teal;
            ButtonEdit.BackgroundImage = Properties.Resources.editNote;
            ButtonEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ButtonEdit.FlatAppearance.BorderSize = 0;
            ButtonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ButtonEdit.Location = new System.Drawing.Point(20, 162);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new System.Drawing.Size(25, 25);
            ButtonEdit.TabIndex = 105;
            ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            this.ButtonDelete.BackgroundImage = Properties.Resources.delete;
            this.ButtonDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonDelete.FlatAppearance.BorderSize = 0;
            this.ButtonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonDelete.Location = new  Point(66, 162);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new Size(25, 25);
            this.ButtonDelete.TabIndex = 106;
            this.ButtonDelete.UseVisualStyleBackColor = false;
        }

        private readonly Panel PanelPost;
        private Label LabelReceivePlaca;
        private Label LabelPlaca;
        private Label LabelBrand;
        private Label LabelModel;
        private Label LabelColor;
        private Label LabelYearFab;
        private Label LabelTank;
        private Label LabelChassi;
        private Panel BorderPanel1;
        private Panel BorderPanel2;
        private Panel BorderPanel3;
        private Panel BordePanel4;
        private Panel BorderPanel5;
        private Panel BorderPanel6;
        private Label LabelReceiveBrand;
        private Label LabelReceiveModel;
        private Label LabelReceiveColor;
        private Label LabelReceiveYear;
        private Label LabelReceiveChassi;
        private Label LabelReceiveTank;
        private Panel PanelSide;
        private PictureBox pictureBox1;
        private Button ButtonEdit;
        private readonly Button ButtonDelete;
    }
}
