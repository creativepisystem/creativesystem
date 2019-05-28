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
            LabelReceiveTank = new Label();
            LabelReceiveChassi = new Label();
            LabelReceiveYear = new Label();
            LabelReceiveColor = new Label();
            LabelReceiveModel = new Label();
            LabelReceiveBrand = new Label();
            BorderPanel6 = new Panel();
            BorderPanel5 = new Panel();
            BordePanel4 = new Panel();
            BorderPanel3 = new Panel();
            BorderPanel2 = new Panel();
            BorderPanel1 = new Panel();
            LabelChassi = new Label();
            LabelTank = new Label();
            LabelYearFab = new Label();
            LabelColor = new Label();
            LabelModel = new Label();
            LabelBrand = new Label();
            PanelSide = new Panel();
            ButtonDelete = new Button();
            pictureBox1 = new PictureBox();
            ButtonEdit = new Button();
            LabelPlaca = new Label();
            LabelReceivePlaca = new Label();
            LabelRenavam = new Label();
            panel1 = new Panel();
            LabelReceiveRenavam = new Label();
            SuspendLayout();
            PanelSide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(pictureBox1)).BeginInit();
            SuspendLayout();



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
            BackColor = System.Drawing.Color.LightGray;
            Controls.Add(LabelReceiveRenavam);
            Controls.Add(panel1);
            Controls.Add(LabelRenavam);
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
            Location = new System.Drawing.Point(216, 47);
            Margin = new Padding(3, 15, 3, 0);
            Name = "PanelPost";
            Size = new System.Drawing.Size(370, 247);
            TabIndex = 0;
            // 
            // LabelReceiveTank
            // 
            LabelReceiveTank.AutoSize = true;
            LabelReceiveTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveTank.Location = new System.Drawing.Point(216, 207);
            LabelReceiveTank.Name = "LabelReceiveTank";
            LabelReceiveTank.Size = new System.Drawing.Size(32, 17);
            LabelReceiveTank.TabIndex = 104;
            LabelReceiveTank.Text = vehicle.Tank_capacity.ToString();
            // 
            // LabelReceiveChassi
            // 
            LabelReceiveChassi.AutoSize = true;
            LabelReceiveChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveChassi.Location = new System.Drawing.Point(212, 171);
            LabelReceiveChassi.Name = "LabelReceiveChassi";
            LabelReceiveChassi.Size = new System.Drawing.Size(126, 17);
            LabelReceiveChassi.TabIndex = 103;
            LabelReceiveChassi.Text = vehicle.Chassi ?? "-";
            // 
            // LabelReceiveYear
            // 
            LabelReceiveYear.AutoSize = true;
            LabelReceiveYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveYear.Location = new System.Drawing.Point(226, 107);
            LabelReceiveYear.Name = "LabelReceiveYear";
            LabelReceiveYear.Size = new System.Drawing.Size(40, 17);
            LabelReceiveYear.TabIndex = 102;
            LabelReceiveYear.Text = vehicle.Fab_Year.ToString();
            // 
            // LabelReceiveColor
            // 
            LabelReceiveColor.AutoSize = true;
            LabelReceiveColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveColor.Location = new System.Drawing.Point(214, 77);
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
            // LabelReceiveModel
            // 
            LabelReceiveModel.AutoSize = true;
            LabelReceiveModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveModel.Location = new System.Drawing.Point(240, 46);
            LabelReceiveModel.Name = "LabelReceiveModel";
            LabelReceiveModel.Size = new System.Drawing.Size(74, 17);
            LabelReceiveModel.TabIndex = 100;
            LabelReceiveModel.Text = vehicle.Model;
            // 
            // LabelReceiveBrand
            // 
            LabelReceiveBrand.AutoSize = true;
            LabelReceiveBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveBrand.Location = new System.Drawing.Point(247, 18);
            LabelReceiveBrand.Name = "LabelReceiveBrand";
            LabelReceiveBrand.Size = new System.Drawing.Size(37, 17);
            LabelReceiveBrand.TabIndex = 99;
            LabelReceiveBrand.Text = vehicle.Brand;
            // 
            // BorderPanel6
            // 
            BorderPanel6.BackColor = System.Drawing.Color.Firebrick;
            BorderPanel6.Location = new System.Drawing.Point(209, 226);
            BorderPanel6.Name = "BorderPanel6";
            BorderPanel6.Size = new System.Drawing.Size(53, 1);
            BorderPanel6.TabIndex = 98;
            // 
            // BorderPanel5
            // 
            BorderPanel5.BackColor = System.Drawing.Color.Firebrick;
            BorderPanel5.Location = new System.Drawing.Point(201, 189);
            BorderPanel5.Name = "BorderPanel5";
            BorderPanel5.Size = new System.Drawing.Size(150, 1);
            BorderPanel5.TabIndex = 97;
            // 
            // BordePanel4
            // 
            BordePanel4.BackColor = System.Drawing.Color.Firebrick;
            BordePanel4.Location = new System.Drawing.Point(201, 125);
            BordePanel4.Name = "BordePanel4";
            BordePanel4.Size = new System.Drawing.Size(97, 1);
            BordePanel4.TabIndex = 96;
            // 
            // BorderPanel3
            // 
            BorderPanel3.BackColor = System.Drawing.Color.Firebrick;
            BorderPanel3.Location = new System.Drawing.Point(185, 95);
            BorderPanel3.Name = "BorderPanel3";
            BorderPanel3.Size = new System.Drawing.Size(130, 1);
            BorderPanel3.TabIndex = 95;
            // 
            // BorderPanel2
            // 
            BorderPanel2.BackColor = System.Drawing.Color.Firebrick;
            BorderPanel2.Location = new System.Drawing.Point(201, 66);
            BorderPanel2.Name = "BorderPanel2";
            BorderPanel2.Size = new System.Drawing.Size(160, 1);
            BorderPanel2.TabIndex = 94;
            // 
            // BorderPanel1
            // 
            BorderPanel1.BackColor = System.Drawing.Color.Firebrick;
            BorderPanel1.Location = new System.Drawing.Point(199, 36);
            BorderPanel1.Name = "BorderPanel1";
            BorderPanel1.Size = new System.Drawing.Size(150, 1);
            BorderPanel1.TabIndex = 93;
            // 
            // LabelChassi
            // 
            LabelChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelChassi.Location = new System.Drawing.Point(131, 173);
            LabelChassi.Name = "LabelChassi";
            LabelChassi.Size = new System.Drawing.Size(62, 20);
            LabelChassi.TabIndex = 13;
            LabelChassi.Text = "Chassi";
            // 
            // LabelTank
            // 
            LabelTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelTank.Location = new System.Drawing.Point(131, 208);
            LabelTank.Name = "LabelTank";
            LabelTank.Size = new System.Drawing.Size(72, 23);
            LabelTank.TabIndex = 12;
            LabelTank.Text = "Tanque";
            LabelTank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelYearFab
            // 
            LabelYearFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelYearFab.Location = new System.Drawing.Point(131, 107);
            LabelYearFab.Name = "LabelYearFab";
            LabelYearFab.Size = new System.Drawing.Size(74, 20);
            LabelYearFab.TabIndex = 11;
            LabelYearFab.Text = "Ano Fab.";
            // 
            // LabelColor
            // 
            LabelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelColor.Location = new System.Drawing.Point(131, 77);
            LabelColor.Name = "LabelColor";
            LabelColor.Size = new System.Drawing.Size(43, 20);
            LabelColor.TabIndex = 10;
            LabelColor.Text = "Cor";
            // 
            // LabelModel
            // 
            LabelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelModel.Location = new System.Drawing.Point(131, 48);
            LabelModel.Name = "LabelModel";
            LabelModel.Size = new System.Drawing.Size(62, 20);
            LabelModel.TabIndex = 9;
            LabelModel.Text = "Modelo";
            // 
            // LabelBrand
            // 
            LabelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelBrand.Location = new System.Drawing.Point(131, 18);
            LabelBrand.Name = "LabelBrand";
            LabelBrand.Size = new System.Drawing.Size(62, 20);
            LabelBrand.TabIndex = 2;
            LabelBrand.Text = "Marca";
            // 
            // PanelSide
            // 
            PanelSide.BackColor = System.Drawing.Color.Firebrick;
            PanelSide.Controls.Add(ButtonDelete);
            PanelSide.Controls.Add(pictureBox1);
            PanelSide.Controls.Add(ButtonEdit);
            PanelSide.Controls.Add(LabelPlaca);
            PanelSide.Controls.Add(LabelReceivePlaca);
            PanelSide.Dock = DockStyle.Left;
            PanelSide.Location = new System.Drawing.Point(0, 0);
            PanelSide.Name = "PanelSide";
            PanelSide.Size = new System.Drawing.Size(125, 247);
            PanelSide.TabIndex = 1;
            // 
            // ButtonDelete
            // 
            ButtonDelete.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            ButtonDelete.BackColor = System.Drawing.Color.Crimson;
            ButtonDelete.BackgroundImage = Properties.Resources.delete;
            ButtonDelete.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonDelete.FlatAppearance.BorderSize = 0;
            ButtonDelete.FlatStyle = FlatStyle.Flat;
            ButtonDelete.Location = new System.Drawing.Point(67, 186);
            ButtonDelete.Name = "ButtonDelete";
            ButtonDelete.Size = new System.Drawing.Size(30, 30);
            ButtonDelete.TabIndex = 106;
            ButtonDelete.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.truckList;
            pictureBox1.Location = new System.Drawing.Point(15, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(91, 83);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 73;
            pictureBox1.TabStop = false;
            // 
            // ButtonEdit
            // 
            ButtonEdit.Anchor = ((AnchorStyles)((AnchorStyles.Bottom | AnchorStyles.Right)));
            ButtonEdit.BackColor = System.Drawing.Color.Teal;
            ButtonEdit.BackgroundImage = Properties.Resources.editNote;
            ButtonEdit.BackgroundImageLayout = ImageLayout.Stretch;
            ButtonEdit.FlatAppearance.BorderSize = 0;
            ButtonEdit.FlatStyle = FlatStyle.Flat;
            ButtonEdit.Location = new System.Drawing.Point(21, 186);
            ButtonEdit.Name = "ButtonEdit";
            ButtonEdit.Size = new System.Drawing.Size(30, 30);
            ButtonEdit.TabIndex = 105;
            ButtonEdit.UseVisualStyleBackColor = false;
            // 
            // LabelPlaca
            // 
            LabelPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelPlaca.ForeColor = System.Drawing.Color.Azure;
            LabelPlaca.Location = new System.Drawing.Point(35, 103);
            LabelPlaca.Name = "LabelPlaca";
            LabelPlaca.Size = new System.Drawing.Size(62, 28);
            LabelPlaca.TabIndex = 1;
            LabelPlaca.Text = "Placa";
            // 
            // LabelReceivePlaca
            // 
            LabelReceivePlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceivePlaca.ForeColor = System.Drawing.Color.Azure;
            LabelReceivePlaca.Location = new System.Drawing.Point(3, 131);
            LabelReceivePlaca.Name = "LabelReceivePlaca";
            LabelReceivePlaca.RightToLeft = RightToLeft.Yes;
            LabelReceivePlaca.Size = new System.Drawing.Size(118, 28);
            LabelReceivePlaca.TabIndex = 0;
            LabelReceivePlaca.Text = vehicle.License_plate;
            // 
            // LabelRenavam
            // 
            LabelRenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelRenavam.Location = new System.Drawing.Point(131, 139);
            LabelRenavam.Name = "LabelRenavam";
            LabelRenavam.Size = new System.Drawing.Size(92, 20);
            LabelRenavam.TabIndex = 105;
            LabelRenavam.Text = "Renavam:";
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Firebrick;
            panel1.Location = new System.Drawing.Point(229, 157);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(130, 1);
            panel1.TabIndex = 94;
            // 
            // LabelReceiveRenavam
            // 
            LabelReceiveRenavam.AutoSize = true;
            LabelReceiveRenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LabelReceiveRenavam.Location = new System.Drawing.Point(247, 138);
            LabelReceiveRenavam.Name = "LabelReceiveRenavam";
            LabelReceiveRenavam.Size = new System.Drawing.Size(80, 17);
            LabelReceiveRenavam.TabIndex = 106;
            LabelReceiveRenavam.Text = vehicle.Renavam ?? "-";
        }

        private readonly Panel PanelPost;
        private Label LabelReceiveTank;
        private Label LabelReceiveChassi;
        private Label LabelReceiveYear;
        private Label LabelReceiveColor;
        private Label LabelReceiveModel;
        private Label LabelReceiveBrand;
        private Panel BorderPanel6;
        private Panel BorderPanel5;
        private Panel BordePanel4;
        private Panel BorderPanel3;
        private Panel BorderPanel2;
        private Panel BorderPanel1;
        private Label LabelChassi;
        private Label LabelTank;
        private Label LabelYearFab;
        private Label LabelColor;
        private Label LabelModel;
        private Label LabelBrand;
        private Panel PanelSide;
        private Label LabelPlaca;
        private Label LabelReceivePlaca;
        private PictureBox pictureBox1;
        private Button ButtonDelete;
        private Button ButtonEdit;
        private Label LabelReceiveRenavam;
        private Panel panel1;
        private Label LabelRenavam;
    }
}
