using System.Drawing;

namespace Truckleer.Creative
{
    partial class Abastecimento
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.button2 = new System.Windows.Forms.Button();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelAbastecer = new System.Windows.Forms.Panel();
            this.BorderPanel8 = new System.Windows.Forms.Panel();
            this.BorderPanel7 = new System.Windows.Forms.Panel();
            this.BorderPanel6 = new System.Windows.Forms.Panel();
            this.BorderPanel5 = new System.Windows.Forms.Panel();
            this.BorderPanel4 = new System.Windows.Forms.Panel();
            this.BorderPanel3 = new System.Windows.Forms.Panel();
            this.BorderPanel2 = new System.Windows.Forms.Panel();
            this.BorderPanel1 = new System.Windows.Forms.Panel();
            this.DivPanel = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.BoxDriver = new System.Windows.Forms.ComboBox();
            this.BoxStation = new System.Windows.Forms.ComboBox();
            this.BoxTrip = new System.Windows.Forms.ComboBox();
            this.TextPrice = new System.Windows.Forms.TextBox();
            this.TextKm = new System.Windows.Forms.TextBox();
            this.LabelStation = new System.Windows.Forms.Label();
            this.LabelTrip = new System.Windows.Forms.Label();
            this.LabelResult = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.LabelKm = new System.Windows.Forms.Label();
            this.BoxVehicle = new System.Windows.Forms.ComboBox();
            this.BoxRoute = new System.Windows.Forms.ComboBox();
            this.DatePicker = new System.Windows.Forms.DateTimePicker();
            this.TextLiters = new System.Windows.Forms.TextBox();
            this.LabelDriver = new System.Windows.Forms.Label();
            this.LabelData = new System.Windows.Forms.Label();
            this.LabelRoute = new System.Windows.Forms.Label();
            this.LabelVehicle = new System.Windows.Forms.Label();
            this.LabelLiters = new System.Windows.Forms.Label();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.PanelAbastecer.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.PanelMain.Controls.Add(this.button2);
            this.PanelMain.Controls.Add(this.layoutFlex);
            this.PanelMain.Controls.Add(this.label7);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1220, 990);
            this.PanelMain.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Azure;
            this.button2.Location = new System.Drawing.Point(1076, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 31);
            this.button2.TabIndex = 43;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
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
            this.PanelContainer.Controls.Add(this.PanelAbastecer);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1191, 924);
            this.PanelContainer.TabIndex = 1;
            // 
            // PanelAbastecer
            // 
            this.PanelAbastecer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelAbastecer.BackColor = System.Drawing.Color.LightGray;
            this.PanelAbastecer.Controls.Add(this.BorderPanel8);
            this.PanelAbastecer.Controls.Add(this.BorderPanel7);
            this.PanelAbastecer.Controls.Add(this.BorderPanel6);
            this.PanelAbastecer.Controls.Add(this.BorderPanel5);
            this.PanelAbastecer.Controls.Add(this.BorderPanel4);
            this.PanelAbastecer.Controls.Add(this.BorderPanel3);
            this.PanelAbastecer.Controls.Add(this.BorderPanel2);
            this.PanelAbastecer.Controls.Add(this.BorderPanel1);
            this.PanelAbastecer.Controls.Add(this.DivPanel);
            this.PanelAbastecer.Controls.Add(this.ButtonCancel);
            this.PanelAbastecer.Controls.Add(this.ButtonSave);
            this.PanelAbastecer.Controls.Add(this.BoxDriver);
            this.PanelAbastecer.Controls.Add(this.BoxStation);
            this.PanelAbastecer.Controls.Add(this.BoxTrip);
            this.PanelAbastecer.Controls.Add(this.TextPrice);
            this.PanelAbastecer.Controls.Add(this.TextKm);
            this.PanelAbastecer.Controls.Add(this.LabelStation);
            this.PanelAbastecer.Controls.Add(this.LabelTrip);
            this.PanelAbastecer.Controls.Add(this.LabelResult);
            this.PanelAbastecer.Controls.Add(this.LabelTotal);
            this.PanelAbastecer.Controls.Add(this.LabelPrice);
            this.PanelAbastecer.Controls.Add(this.LabelKm);
            this.PanelAbastecer.Controls.Add(this.BoxVehicle);
            this.PanelAbastecer.Controls.Add(this.BoxRoute);
            this.PanelAbastecer.Controls.Add(this.DatePicker);
            this.PanelAbastecer.Controls.Add(this.TextLiters);
            this.PanelAbastecer.Controls.Add(this.LabelDriver);
            this.PanelAbastecer.Controls.Add(this.LabelData);
            this.PanelAbastecer.Controls.Add(this.LabelRoute);
            this.PanelAbastecer.Controls.Add(this.LabelVehicle);
            this.PanelAbastecer.Controls.Add(this.LabelLiters);
            this.PanelAbastecer.Controls.Add(this.PanelTitle);
            this.PanelAbastecer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelAbastecer.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelAbastecer.Location = new System.Drawing.Point(107, 40);
            this.PanelAbastecer.Name = "PanelAbastecer";
            this.PanelAbastecer.Size = new System.Drawing.Size(970, 589);
            this.PanelAbastecer.TabIndex = 0;
            // 
            // BorderPanel8
            // 
            this.BorderPanel8.BackColor = System.Drawing.Color.RoyalBlue;
            this.BorderPanel8.Location = new System.Drawing.Point(629, 420);
            this.BorderPanel8.Name = "BorderPanel8";
            this.BorderPanel8.Size = new System.Drawing.Size(201, 2);
            this.BorderPanel8.TabIndex = 76;
            // 
            // BorderPanel7
            // 
            this.BorderPanel7.BackColor = System.Drawing.Color.RoyalBlue;
            this.BorderPanel7.Location = new System.Drawing.Point(629, 341);
            this.BorderPanel7.Name = "BorderPanel7";
            this.BorderPanel7.Size = new System.Drawing.Size(201, 2);
            this.BorderPanel7.TabIndex = 75;
            // 
            // BorderPanel6
            // 
            this.BorderPanel6.BackColor = System.Drawing.Color.RoyalBlue;
            this.BorderPanel6.Location = new System.Drawing.Point(629, 281);
            this.BorderPanel6.Name = "BorderPanel6";
            this.BorderPanel6.Size = new System.Drawing.Size(201, 2);
            this.BorderPanel6.TabIndex = 74;
            // 
            // BorderPanel5
            // 
            this.BorderPanel5.BackColor = System.Drawing.Color.RoyalBlue;
            this.BorderPanel5.Location = new System.Drawing.Point(629, 222);
            this.BorderPanel5.Name = "BorderPanel5";
            this.BorderPanel5.Size = new System.Drawing.Size(201, 2);
            this.BorderPanel5.TabIndex = 73;
            // 
            // BorderPanel4
            // 
            this.BorderPanel4.BackColor = System.Drawing.Color.RoyalBlue;
            this.BorderPanel4.Location = new System.Drawing.Point(181, 415);
            this.BorderPanel4.Name = "BorderPanel4";
            this.BorderPanel4.Size = new System.Drawing.Size(194, 2);
            this.BorderPanel4.TabIndex = 73;
            // 
            // BorderPanel3
            // 
            this.BorderPanel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.BorderPanel3.Location = new System.Drawing.Point(181, 345);
            this.BorderPanel3.Name = "BorderPanel3";
            this.BorderPanel3.Size = new System.Drawing.Size(194, 2);
            this.BorderPanel3.TabIndex = 74;
            // 
            // BorderPanel2
            // 
            this.BorderPanel2.BackColor = System.Drawing.Color.RoyalBlue;
            this.BorderPanel2.Location = new System.Drawing.Point(181, 278);
            this.BorderPanel2.Name = "BorderPanel2";
            this.BorderPanel2.Size = new System.Drawing.Size(194, 2);
            this.BorderPanel2.TabIndex = 73;
            // 
            // BorderPanel1
            // 
            this.BorderPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.BorderPanel1.Location = new System.Drawing.Point(181, 224);
            this.BorderPanel1.Name = "BorderPanel1";
            this.BorderPanel1.Size = new System.Drawing.Size(194, 2);
            this.BorderPanel1.TabIndex = 72;
            // 
            // DivPanel
            // 
            this.DivPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.DivPanel.Location = new System.Drawing.Point(468, 124);
            this.DivPanel.Name = "DivPanel";
            this.DivPanel.Size = new System.Drawing.Size(2, 366);
            this.DivPanel.TabIndex = 71;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.FlatAppearance.BorderSize = 2;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.RoyalBlue;
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
            this.ButtonSave.BackColor = System.Drawing.Color.RoyalBlue;
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
            // 
            // BoxDriver
            // 
            this.BoxDriver.AllowDrop = true;
            this.BoxDriver.BackColor = System.Drawing.Color.LightGray;
            this.BoxDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxDriver.FormattingEnabled = true;
            this.BoxDriver.Location = new System.Drawing.Point(181, 388);
            this.BoxDriver.Name = "BoxDriver";
            this.BoxDriver.Size = new System.Drawing.Size(194, 28);
            this.BoxDriver.TabIndex = 68;
            // 
            // BoxStation
            // 
            this.BoxStation.AllowDrop = true;
            this.BoxStation.BackColor = System.Drawing.Color.LightGray;
            this.BoxStation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxStation.FormattingEnabled = true;
            this.BoxStation.Location = new System.Drawing.Point(629, 391);
            this.BoxStation.Name = "BoxStation";
            this.BoxStation.Size = new System.Drawing.Size(201, 28);
            this.BoxStation.TabIndex = 67;
            // 
            // BoxTrip
            // 
            this.BoxTrip.AllowDrop = true;
            this.BoxTrip.BackColor = System.Drawing.Color.LightGray;
            this.BoxTrip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BoxTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxTrip.FormattingEnabled = true;
            this.BoxTrip.Location = new System.Drawing.Point(629, 196);
            this.BoxTrip.Name = "BoxTrip";
            this.BoxTrip.Size = new System.Drawing.Size(201, 28);
            this.BoxTrip.TabIndex = 66;
            // 
            // TextPrice
            // 
            this.TextPrice.BackColor = System.Drawing.Color.LightGray;
            this.TextPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPrice.Location = new System.Drawing.Point(629, 323);
            this.TextPrice.MaxLength = 6;
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.Size = new System.Drawing.Size(201, 19);
            this.TextPrice.TabIndex = 63;
            // 
            // TextKm
            // 
            this.TextKm.BackColor = System.Drawing.Color.LightGray;
            this.TextKm.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextKm.Location = new System.Drawing.Point(629, 261);
            this.TextKm.Name = "TextKm";
            this.TextKm.Size = new System.Drawing.Size(201, 19);
            this.TextKm.TabIndex = 62;
            // 
            // LabelStation
            // 
            this.LabelStation.AutoSize = true;
            this.LabelStation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelStation.ForeColor = System.Drawing.Color.Gray;
            this.LabelStation.Location = new System.Drawing.Point(541, 391);
            this.LabelStation.Name = "LabelStation";
            this.LabelStation.Size = new System.Drawing.Size(55, 20);
            this.LabelStation.TabIndex = 56;
            this.LabelStation.Text = "Posto";
            // 
            // LabelTrip
            // 
            this.LabelTrip.AutoSize = true;
            this.LabelTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrip.ForeColor = System.Drawing.Color.Gray;
            this.LabelTrip.Location = new System.Drawing.Point(541, 199);
            this.LabelTrip.Name = "LabelTrip";
            this.LabelTrip.Size = new System.Drawing.Size(69, 20);
            this.LabelTrip.TabIndex = 61;
            this.LabelTrip.Text = "Viagem";
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.BackColor = System.Drawing.Color.Transparent;
            this.LabelResult.ForeColor = System.Drawing.Color.Black;
            this.LabelResult.Location = new System.Drawing.Point(232, 479);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(83, 20);
            this.LabelResult.TabIndex = 60;
            this.LabelResult.Text = "Total Price";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.Color.Gray;
            this.LabelTotal.Location = new System.Drawing.Point(76, 479);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(49, 20);
            this.LabelTotal.TabIndex = 59;
            this.LabelTotal.Text = "Total";
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.ForeColor = System.Drawing.Color.Gray;
            this.LabelPrice.Location = new System.Drawing.Point(544, 323);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(55, 20);
            this.LabelPrice.TabIndex = 58;
            this.LabelPrice.Text = "Preço";
            // 
            // LabelKm
            // 
            this.LabelKm.AutoSize = true;
            this.LabelKm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelKm.ForeColor = System.Drawing.Color.Gray;
            this.LabelKm.Location = new System.Drawing.Point(541, 259);
            this.LabelKm.Name = "LabelKm";
            this.LabelKm.Size = new System.Drawing.Size(81, 20);
            this.LabelKm.TabIndex = 57;
            this.LabelKm.Text = "Km Atual";
            // 
            // BoxVehicle
            // 
            this.BoxVehicle.AllowDrop = true;
            this.BoxVehicle.BackColor = System.Drawing.Color.LightGray;
            this.BoxVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxVehicle.FormattingEnabled = true;
            this.BoxVehicle.Location = new System.Drawing.Point(181, 196);
            this.BoxVehicle.Name = "BoxVehicle";
            this.BoxVehicle.Size = new System.Drawing.Size(194, 28);
            this.BoxVehicle.TabIndex = 55;
            // 
            // BoxRoute
            // 
            this.BoxRoute.AllowDrop = true;
            this.BoxRoute.BackColor = System.Drawing.Color.LightGray;
            this.BoxRoute.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxRoute.FormattingEnabled = true;
            this.BoxRoute.Location = new System.Drawing.Point(180, 316);
            this.BoxRoute.Name = "BoxRoute";
            this.BoxRoute.Size = new System.Drawing.Size(195, 28);
            this.BoxRoute.TabIndex = 54;
            // 
            // DatePicker
            // 
            this.DatePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.DatePicker.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.DatePicker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePicker.Location = new System.Drawing.Point(181, 140);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DatePicker.RightToLeftLayout = true;
            this.DatePicker.Size = new System.Drawing.Size(143, 26);
            this.DatePicker.TabIndex = 51;
            // 
            // TextLiters
            // 
            this.TextLiters.BackColor = System.Drawing.Color.LightGray;
            this.TextLiters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextLiters.Location = new System.Drawing.Point(181, 258);
            this.TextLiters.MaxLength = 10;
            this.TextLiters.Name = "TextLiters";
            this.TextLiters.Size = new System.Drawing.Size(194, 19);
            this.TextLiters.TabIndex = 53;
            // 
            // LabelDriver
            // 
            this.LabelDriver.AutoSize = true;
            this.LabelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDriver.ForeColor = System.Drawing.Color.Gray;
            this.LabelDriver.Location = new System.Drawing.Point(76, 388);
            this.LabelDriver.Name = "LabelDriver";
            this.LabelDriver.Size = new System.Drawing.Size(84, 20);
            this.LabelDriver.TabIndex = 46;
            this.LabelDriver.Text = "Motorista";
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelData.ForeColor = System.Drawing.Color.Gray;
            this.LabelData.Location = new System.Drawing.Point(76, 140);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(48, 20);
            this.LabelData.TabIndex = 47;
            this.LabelData.Text = "Data";
            // 
            // LabelRoute
            // 
            this.LabelRoute.AutoSize = true;
            this.LabelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoute.ForeColor = System.Drawing.Color.Gray;
            this.LabelRoute.Location = new System.Drawing.Point(76, 316);
            this.LabelRoute.Name = "LabelRoute";
            this.LabelRoute.Size = new System.Drawing.Size(48, 20);
            this.LabelRoute.TabIndex = 50;
            this.LabelRoute.Text = "Rota";
            // 
            // LabelVehicle
            // 
            this.LabelVehicle.AutoSize = true;
            this.LabelVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehicle.ForeColor = System.Drawing.Color.Gray;
            this.LabelVehicle.Location = new System.Drawing.Point(76, 199);
            this.LabelVehicle.Name = "LabelVehicle";
            this.LabelVehicle.Size = new System.Drawing.Size(68, 20);
            this.LabelVehicle.TabIndex = 49;
            this.LabelVehicle.Text = "Veículo";
            // 
            // LabelLiters
            // 
            this.LabelLiters.AutoSize = true;
            this.LabelLiters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelLiters.ForeColor = System.Drawing.Color.Gray;
            this.LabelLiters.Location = new System.Drawing.Point(76, 258);
            this.LabelLiters.Name = "LabelLiters";
            this.LabelLiters.Size = new System.Drawing.Size(54, 20);
            this.LabelLiters.TabIndex = 52;
            this.LabelLiters.Text = "Litros";
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.RoyalBlue;
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
            this.title.Size = new System.Drawing.Size(186, 48);
            this.title.TabIndex = 41;
            this.title.Text = "Abastecer";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Azure;
            this.label7.Location = new System.Drawing.Point(931, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 31);
            this.label7.TabIndex = 42;
            this.label7.Text = "Abastecer /";
            // 
            // Abastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.PanelMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Abastecimento";
            this.Size = new System.Drawing.Size(1220, 990);
            this.Load += new System.EventHandler(this.Abastecimento_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelAbastecer.ResumeLayout(false);
            this.PanelAbastecer.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelAbastecer;
        private System.Windows.Forms.Panel BorderPanel8;
        private System.Windows.Forms.Panel BorderPanel7;
        private System.Windows.Forms.Panel BorderPanel6;
        private System.Windows.Forms.Panel BorderPanel5;
        private System.Windows.Forms.Panel BorderPanel4;
        private System.Windows.Forms.Panel BorderPanel3;
        private System.Windows.Forms.Panel BorderPanel2;
        private System.Windows.Forms.Panel BorderPanel1;
        private System.Windows.Forms.Panel DivPanel;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.ComboBox BoxDriver;
        private System.Windows.Forms.ComboBox BoxStation;
        private System.Windows.Forms.ComboBox BoxTrip;
        private System.Windows.Forms.TextBox TextPrice;
        private System.Windows.Forms.TextBox TextKm;
        private System.Windows.Forms.Label LabelStation;
        private System.Windows.Forms.Label LabelTrip;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Label LabelKm;
        private System.Windows.Forms.ComboBox BoxVehicle;
        private System.Windows.Forms.ComboBox BoxRoute;
        private System.Windows.Forms.DateTimePicker DatePicker;
        private System.Windows.Forms.TextBox TextLiters;
        private System.Windows.Forms.Label LabelDriver;
        private System.Windows.Forms.Label LabelData;
        private System.Windows.Forms.Label LabelRoute;
        private System.Windows.Forms.Label LabelVehicle;
        private System.Windows.Forms.Label LabelLiters;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
    }
}
