using System.ComponentModel;

namespace Truckleer.Creative
{
    partial class Veiculos
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private BackgroundWorker vehicleWorker;
        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelVehicle = new System.Windows.Forms.Panel();
            this.BoxColor = new System.Windows.Forms.ComboBox();
            this.BorderPanel9 = new System.Windows.Forms.Panel();
            this.BorderPanel8 = new System.Windows.Forms.Panel();
            this.BorderPanel7 = new System.Windows.Forms.Panel();
            this.BorderPanel6 = new System.Windows.Forms.Panel();
            this.BorderPanel5 = new System.Windows.Forms.Panel();
            this.BorderPanel4 = new System.Windows.Forms.Panel();
            this.BorderPanel3 = new System.Windows.Forms.Panel();
            this.BorderPanel2 = new System.Windows.Forms.Panel();
            this.BorderPanel1 = new System.Windows.Forms.Panel();
            this.DivPanel = new System.Windows.Forms.Panel();
            this.TextYearMod = new System.Windows.Forms.TextBox();
            this.LabelYearMod = new System.Windows.Forms.Label();
            this.TextChassi = new System.Windows.Forms.TextBox();
            this.LabelChassi = new System.Windows.Forms.Label();
            this.TextRenavam = new System.Windows.Forms.TextBox();
            this.LabelRenavam = new System.Windows.Forms.Label();
            this.LabelColor = new System.Windows.Forms.Label();
            this.TextYearFab = new System.Windows.Forms.TextBox();
            this.LabelYearFab = new System.Windows.Forms.Label();
            this.TextTank = new System.Windows.Forms.TextBox();
            this.LabelPlate = new System.Windows.Forms.Label();
            this.LabelTank = new System.Windows.Forms.Label();
            this.TextBrand = new System.Windows.Forms.TextBox();
            this.LabelBrand = new System.Windows.Forms.Label();
            this.TextModel = new System.Windows.Forms.TextBox();
            this.LabelModel = new System.Windows.Forms.Label();
            this.TextPlate = new System.Windows.Forms.TextBox();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.PageDescription = new System.Windows.Forms.Label();
            this.vehicleWorker = new System.ComponentModel.BackgroundWorker();
            this.PanelMain.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.PanelVehicle.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.PanelMain.Controls.Add(this.ButtonHome);
            this.PanelMain.Controls.Add(this.layoutFlex);
            this.PanelMain.Controls.Add(this.PageDescription);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1220, 990);
            this.PanelMain.TabIndex = 5;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.Azure;
            this.ButtonHome.Location = new System.Drawing.Point(1116, 5);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(76, 31);
            this.ButtonHome.TabIndex = 43;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            // 
            // layoutFlex
            // 
            this.layoutFlex.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layoutFlex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.layoutFlex.ColumnCount = 1;
            this.layoutFlex.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutFlex.Controls.Add(this.MainPanel, 0, 0);
            this.layoutFlex.Location = new System.Drawing.Point(15, 36);
            this.layoutFlex.Margin = new System.Windows.Forms.Padding(0);
            this.layoutFlex.Name = "layoutFlex";
            this.layoutFlex.RowCount = 1;
            this.layoutFlex.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.layoutFlex.Size = new System.Drawing.Size(1191, 924);
            this.layoutFlex.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.PanelContainer);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1191, 924);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelContainer.Controls.Add(this.PanelVehicle);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1191, 924);
            this.PanelContainer.TabIndex = 1;
            // 
            // PanelVehicle
            // 
            this.PanelVehicle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelVehicle.BackColor = System.Drawing.Color.LightGray;
            this.PanelVehicle.Controls.Add(this.BoxColor);
            this.PanelVehicle.Controls.Add(this.BorderPanel9);
            this.PanelVehicle.Controls.Add(this.BorderPanel8);
            this.PanelVehicle.Controls.Add(this.BorderPanel7);
            this.PanelVehicle.Controls.Add(this.BorderPanel6);
            this.PanelVehicle.Controls.Add(this.BorderPanel5);
            this.PanelVehicle.Controls.Add(this.BorderPanel4);
            this.PanelVehicle.Controls.Add(this.BorderPanel3);
            this.PanelVehicle.Controls.Add(this.BorderPanel2);
            this.PanelVehicle.Controls.Add(this.BorderPanel1);
            this.PanelVehicle.Controls.Add(this.DivPanel);
            this.PanelVehicle.Controls.Add(this.TextYearMod);
            this.PanelVehicle.Controls.Add(this.LabelYearMod);
            this.PanelVehicle.Controls.Add(this.TextChassi);
            this.PanelVehicle.Controls.Add(this.LabelChassi);
            this.PanelVehicle.Controls.Add(this.TextRenavam);
            this.PanelVehicle.Controls.Add(this.LabelRenavam);
            this.PanelVehicle.Controls.Add(this.LabelColor);
            this.PanelVehicle.Controls.Add(this.TextYearFab);
            this.PanelVehicle.Controls.Add(this.LabelYearFab);
            this.PanelVehicle.Controls.Add(this.TextTank);
            this.PanelVehicle.Controls.Add(this.LabelPlate);
            this.PanelVehicle.Controls.Add(this.LabelTank);
            this.PanelVehicle.Controls.Add(this.TextBrand);
            this.PanelVehicle.Controls.Add(this.LabelBrand);
            this.PanelVehicle.Controls.Add(this.TextModel);
            this.PanelVehicle.Controls.Add(this.LabelModel);
            this.PanelVehicle.Controls.Add(this.TextPlate);
            this.PanelVehicle.Controls.Add(this.ButtonCancel);
            this.PanelVehicle.Controls.Add(this.ButtonSave);
            this.PanelVehicle.Controls.Add(this.PanelTitle);
            this.PanelVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelVehicle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelVehicle.Location = new System.Drawing.Point(107, 40);
            this.PanelVehicle.Name = "PanelVehicle";
            this.PanelVehicle.Size = new System.Drawing.Size(970, 589);
            this.PanelVehicle.TabIndex = 0;
            // 
            // BoxColor
            // 
            this.BoxColor.BackColor = System.Drawing.Color.LightGray;
            this.BoxColor.FormattingEnabled = true;
            this.BoxColor.Items.AddRange(new object[] {
            "Preto",
            "Branco",
            "Vermelho",
            "Amarelo",
            "Verde",
            "Cinza",
            "Azul",
            "Marrom"});
            this.BoxColor.Location = new System.Drawing.Point(162, 348);
            this.BoxColor.Name = "BoxColor";
            this.BoxColor.Size = new System.Drawing.Size(169, 28);
            this.BoxColor.TabIndex = 101;
            // 
            // BorderPanel9
            // 
            this.BorderPanel9.BackColor = System.Drawing.Color.Firebrick;
            this.BorderPanel9.Location = new System.Drawing.Point(617, 377);
            this.BorderPanel9.Name = "BorderPanel9";
            this.BorderPanel9.Size = new System.Drawing.Size(168, 2);
            this.BorderPanel9.TabIndex = 100;
            // 
            // BorderPanel8
            // 
            this.BorderPanel8.BackColor = System.Drawing.Color.Firebrick;
            this.BorderPanel8.Location = new System.Drawing.Point(532, 308);
            this.BorderPanel8.Name = "BorderPanel8";
            this.BorderPanel8.Size = new System.Drawing.Size(153, 2);
            this.BorderPanel8.TabIndex = 99;
            // 
            // BorderPanel7
            // 
            this.BorderPanel7.BackColor = System.Drawing.Color.Firebrick;
            this.BorderPanel7.Location = new System.Drawing.Point(807, 241);
            this.BorderPanel7.Name = "BorderPanel7";
            this.BorderPanel7.Size = new System.Drawing.Size(92, 2);
            this.BorderPanel7.TabIndex = 98;
            // 
            // BorderPanel6
            // 
            this.BorderPanel6.BackColor = System.Drawing.Color.Firebrick;
            this.BorderPanel6.Location = new System.Drawing.Point(593, 242);
            this.BorderPanel6.Name = "BorderPanel6";
            this.BorderPanel6.Size = new System.Drawing.Size(92, 2);
            this.BorderPanel6.TabIndex = 97;
            // 
            // BorderPanel5
            // 
            this.BorderPanel5.BackColor = System.Drawing.Color.Firebrick;
            this.BorderPanel5.Location = new System.Drawing.Point(532, 172);
            this.BorderPanel5.Name = "BorderPanel5";
            this.BorderPanel5.Size = new System.Drawing.Size(367, 2);
            this.BorderPanel5.TabIndex = 96;
            // 
            // BorderPanel4
            // 
            this.BorderPanel4.BackColor = System.Drawing.Color.Firebrick;
            this.BorderPanel4.Location = new System.Drawing.Point(162, 378);
            this.BorderPanel4.Name = "BorderPanel4";
            this.BorderPanel4.Size = new System.Drawing.Size(169, 2);
            this.BorderPanel4.TabIndex = 95;
            // 
            // BorderPanel3
            // 
            this.BorderPanel3.BackColor = System.Drawing.Color.Firebrick;
            this.BorderPanel3.Location = new System.Drawing.Point(162, 307);
            this.BorderPanel3.Name = "BorderPanel3";
            this.BorderPanel3.Size = new System.Drawing.Size(169, 2);
            this.BorderPanel3.TabIndex = 94;
            // 
            // BorderPanel2
            // 
            this.BorderPanel2.BackColor = System.Drawing.Color.Firebrick;
            this.BorderPanel2.Location = new System.Drawing.Point(162, 241);
            this.BorderPanel2.Name = "BorderPanel2";
            this.BorderPanel2.Size = new System.Drawing.Size(169, 2);
            this.BorderPanel2.TabIndex = 93;
            // 
            // BorderPanel1
            // 
            this.BorderPanel1.BackColor = System.Drawing.Color.Firebrick;
            this.BorderPanel1.Location = new System.Drawing.Point(161, 173);
            this.BorderPanel1.Name = "BorderPanel1";
            this.BorderPanel1.Size = new System.Drawing.Size(169, 2);
            this.BorderPanel1.TabIndex = 92;
            // 
            // DivPanel
            // 
            this.DivPanel.BackColor = System.Drawing.Color.Firebrick;
            this.DivPanel.Location = new System.Drawing.Point(390, 124);
            this.DivPanel.Name = "DivPanel";
            this.DivPanel.Size = new System.Drawing.Size(2, 366);
            this.DivPanel.TabIndex = 91;
            // 
            // TextYearMod
            // 
            this.TextYearMod.BackColor = System.Drawing.Color.LightGray;
            this.TextYearMod.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextYearMod.Location = new System.Drawing.Point(807, 221);
            this.TextYearMod.Name = "TextYearMod";
            this.TextYearMod.Size = new System.Drawing.Size(92, 19);
            this.TextYearMod.TabIndex = 88;
            // 
            // LabelYearMod
            // 
            this.LabelYearMod.AutoSize = true;
            this.LabelYearMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYearMod.ForeColor = System.Drawing.Color.Gray;
            this.LabelYearMod.Location = new System.Drawing.Point(700, 221);
            this.LabelYearMod.Name = "LabelYearMod";
            this.LabelYearMod.Size = new System.Drawing.Size(104, 20);
            this.LabelYearMod.TabIndex = 87;
            this.LabelYearMod.Text = "Ano Modelo";
            // 
            // TextChassi
            // 
            this.TextChassi.BackColor = System.Drawing.Color.LightGray;
            this.TextChassi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextChassi.Location = new System.Drawing.Point(532, 153);
            this.TextChassi.Name = "TextChassi";
            this.TextChassi.Size = new System.Drawing.Size(367, 19);
            this.TextChassi.TabIndex = 86;
            // 
            // LabelChassi
            // 
            this.LabelChassi.AutoSize = true;
            this.LabelChassi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelChassi.ForeColor = System.Drawing.Color.Gray;
            this.LabelChassi.Location = new System.Drawing.Point(443, 152);
            this.LabelChassi.Name = "LabelChassi";
            this.LabelChassi.Size = new System.Drawing.Size(63, 20);
            this.LabelChassi.TabIndex = 85;
            this.LabelChassi.Text = "Chassi";
            // 
            // TextRenavam
            // 
            this.TextRenavam.BackColor = System.Drawing.Color.LightGray;
            this.TextRenavam.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextRenavam.Location = new System.Drawing.Point(532, 289);
            this.TextRenavam.Name = "TextRenavam";
            this.TextRenavam.Size = new System.Drawing.Size(153, 19);
            this.TextRenavam.TabIndex = 84;
            // 
            // LabelRenavam
            // 
            this.LabelRenavam.AutoSize = true;
            this.LabelRenavam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRenavam.ForeColor = System.Drawing.Color.Gray;
            this.LabelRenavam.Location = new System.Drawing.Point(442, 288);
            this.LabelRenavam.Name = "LabelRenavam";
            this.LabelRenavam.Size = new System.Drawing.Size(84, 20);
            this.LabelRenavam.TabIndex = 83;
            this.LabelRenavam.Text = "Renavam";
            // 
            // LabelColor
            // 
            this.LabelColor.AutoSize = true;
            this.LabelColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelColor.ForeColor = System.Drawing.Color.Gray;
            this.LabelColor.Location = new System.Drawing.Point(80, 358);
            this.LabelColor.Name = "LabelColor";
            this.LabelColor.Size = new System.Drawing.Size(37, 20);
            this.LabelColor.TabIndex = 81;
            this.LabelColor.Text = "Cor";
            // 
            // TextYearFab
            // 
            this.TextYearFab.BackColor = System.Drawing.Color.LightGray;
            this.TextYearFab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextYearFab.Location = new System.Drawing.Point(593, 223);
            this.TextYearFab.Name = "TextYearFab";
            this.TextYearFab.Size = new System.Drawing.Size(92, 19);
            this.TextYearFab.TabIndex = 80;
            // 
            // LabelYearFab
            // 
            this.LabelYearFab.AutoSize = true;
            this.LabelYearFab.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelYearFab.ForeColor = System.Drawing.Color.Gray;
            this.LabelYearFab.Location = new System.Drawing.Point(442, 221);
            this.LabelYearFab.Name = "LabelYearFab";
            this.LabelYearFab.Size = new System.Drawing.Size(135, 20);
            this.LabelYearFab.TabIndex = 79;
            this.LabelYearFab.Text = "Ano Fabricação";
            // 
            // TextTank
            // 
            this.TextTank.BackColor = System.Drawing.Color.LightGray;
            this.TextTank.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextTank.Location = new System.Drawing.Point(617, 358);
            this.TextTank.Name = "TextTank";
            this.TextTank.Size = new System.Drawing.Size(168, 19);
            this.TextTank.TabIndex = 78;
            // 
            // LabelPlate
            // 
            this.LabelPlate.AutoSize = true;
            this.LabelPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlate.ForeColor = System.Drawing.Color.Gray;
            this.LabelPlate.Location = new System.Drawing.Point(80, 152);
            this.LabelPlate.Name = "LabelPlate";
            this.LabelPlate.Size = new System.Drawing.Size(53, 20);
            this.LabelPlate.TabIndex = 71;
            this.LabelPlate.Text = "Placa";
            // 
            // LabelTank
            // 
            this.LabelTank.AutoSize = true;
            this.LabelTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTank.ForeColor = System.Drawing.Color.Gray;
            this.LabelTank.Location = new System.Drawing.Point(442, 358);
            this.LabelTank.Name = "LabelTank";
            this.LabelTank.Size = new System.Drawing.Size(169, 20);
            this.LabelTank.TabIndex = 77;
            this.LabelTank.Text = "Capacidade Tanque";
            this.LabelTank.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextBrand
            // 
            this.TextBrand.BackColor = System.Drawing.Color.LightGray;
            this.TextBrand.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBrand.Location = new System.Drawing.Point(162, 223);
            this.TextBrand.Name = "TextBrand";
            this.TextBrand.Size = new System.Drawing.Size(168, 19);
            this.TextBrand.TabIndex = 74;
            // 
            // LabelBrand
            // 
            this.LabelBrand.AutoSize = true;
            this.LabelBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBrand.ForeColor = System.Drawing.Color.Gray;
            this.LabelBrand.Location = new System.Drawing.Point(80, 222);
            this.LabelBrand.Name = "LabelBrand";
            this.LabelBrand.Size = new System.Drawing.Size(58, 20);
            this.LabelBrand.TabIndex = 73;
            this.LabelBrand.Text = "Marca";
            // 
            // TextModel
            // 
            this.TextModel.BackColor = System.Drawing.Color.LightGray;
            this.TextModel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextModel.Location = new System.Drawing.Point(162, 288);
            this.TextModel.Name = "TextModel";
            this.TextModel.Size = new System.Drawing.Size(168, 19);
            this.TextModel.TabIndex = 76;
            // 
            // LabelModel
            // 
            this.LabelModel.AutoSize = true;
            this.LabelModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelModel.ForeColor = System.Drawing.Color.Gray;
            this.LabelModel.Location = new System.Drawing.Point(80, 287);
            this.LabelModel.Name = "LabelModel";
            this.LabelModel.Size = new System.Drawing.Size(67, 20);
            this.LabelModel.TabIndex = 75;
            this.LabelModel.Text = "Modelo";
            // 
            // TextPlate
            // 
            this.TextPlate.BackColor = System.Drawing.Color.LightGray;
            this.TextPlate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPlate.Location = new System.Drawing.Point(162, 153);
            this.TextPlate.Name = "TextPlate";
            this.TextPlate.Size = new System.Drawing.Size(168, 19);
            this.TextPlate.TabIndex = 72;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick;
            this.ButtonCancel.FlatAppearance.BorderSize = 2;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.Firebrick;
            this.ButtonCancel.Location = new System.Drawing.Point(818, 524);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(97, 32);
            this.ButtonCancel.TabIndex = 70;
            this.ButtonCancel.Text = "Cancelar";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.BackColor = System.Drawing.Color.Firebrick;
            this.ButtonSave.FlatAppearance.BorderSize = 0;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.Azure;
            this.ButtonSave.Location = new System.Drawing.Point(707, 524);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(97, 32);
            this.ButtonSave.TabIndex = 69;
            this.ButtonSave.Text = "Salvar";
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.Firebrick;
            this.PanelTitle.Controls.Add(this.title);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(970, 87);
            this.PanelTitle.TabIndex = 0;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Azure;
            this.title.Location = new System.Drawing.Point(35, 20);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(365, 48);
            this.title.TabIndex = 41;
            this.title.Text = "Cadastro de Veículos";
            // 
            // PageDescription
            // 
            this.PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescription.AutoSize = true;
            this.PageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescription.ForeColor = System.Drawing.Color.Azure;
            this.PageDescription.Location = new System.Drawing.Point(864, 5);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(259, 31);
            this.PageDescription.TabIndex = 42;
            this.PageDescription.Text = "Cadastrar Veículos /";
            // 
            // vehicleWorker
            // 
            this.vehicleWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SaveVehicle);
            this.vehicleWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.SaveVehicleFinish);
            // 
            // Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.PanelMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Veiculos";
            this.Size = new System.Drawing.Size(1220, 990);
            this.Load += new System.EventHandler(this.Veiculos_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelVehicle.ResumeLayout(false);
            this.PanelVehicle.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelVehicle;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox TextTank;
        private System.Windows.Forms.Label LabelPlate;
        private System.Windows.Forms.Label LabelTank;
        private System.Windows.Forms.TextBox TextBrand;
        private System.Windows.Forms.Label LabelBrand;
        private System.Windows.Forms.TextBox TextModel;
        private System.Windows.Forms.Label LabelModel;
        private System.Windows.Forms.TextBox TextPlate;
        private System.Windows.Forms.TextBox TextChassi;
        private System.Windows.Forms.Label LabelChassi;
        private System.Windows.Forms.TextBox TextRenavam;
        private System.Windows.Forms.Label LabelRenavam;
        private System.Windows.Forms.Label LabelColor;
        private System.Windows.Forms.TextBox TextYearFab;
        private System.Windows.Forms.Label LabelYearFab;
        private System.Windows.Forms.TextBox TextYearMod;
        private System.Windows.Forms.Label LabelYearMod;
        private System.Windows.Forms.Panel DivPanel;
        private System.Windows.Forms.Panel BorderPanel9;
        private System.Windows.Forms.Panel BorderPanel8;
        private System.Windows.Forms.Panel BorderPanel7;
        private System.Windows.Forms.Panel BorderPanel6;
        private System.Windows.Forms.Panel BorderPanel5;
        private System.Windows.Forms.Panel BorderPanel4;
        private System.Windows.Forms.Panel BorderPanel3;
        private System.Windows.Forms.Panel BorderPanel2;
        private System.Windows.Forms.Panel BorderPanel1;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.ComboBox BoxColor;
    }
}
