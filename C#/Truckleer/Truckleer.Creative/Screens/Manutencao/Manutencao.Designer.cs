namespace Truckleer.Creative
{
    partial class Manutencao
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
            this.ButtonHome = new System.Windows.Forms.Button();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelMaintence = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BoxVehicle = new System.Windows.Forms.ComboBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.NumberQtd = new System.Windows.Forms.NumericUpDown();
            this.LabelQtd = new System.Windows.Forms.Label();
            this.TextPrice = new System.Windows.Forms.TextBox();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.PeçaCorretiva = new System.Windows.Forms.TextBox();
            this.PecaLabel = new System.Windows.Forms.Label();
            this.LabelVehicle = new System.Windows.Forms.Label();
            this.dateTimeMaintence = new System.Windows.Forms.DateTimePicker();
            this.LabelData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoxDriver = new System.Windows.Forms.ComboBox();
            this.BoxPreventiva = new System.Windows.Forms.ComboBox();
            this.LabelObservation = new System.Windows.Forms.Label();
            this.TextObservation = new System.Windows.Forms.RichTextBox();
            this.LabelDriver = new System.Windows.Forms.Label();
            this.radioButtonCorretiva = new System.Windows.Forms.RadioButton();
            this.radioButtonPreventiva = new System.Windows.Forms.RadioButton();
            this.TextCorretiva = new System.Windows.Forms.TextBox();
            this.LabelName = new System.Windows.Forms.Label();
            this.DivPanel = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.PageDescription = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.PanelMaintence.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberQtd)).BeginInit();
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
            this.PanelMain.TabIndex = 7;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.Azure;
            this.ButtonHome.Location = new System.Drawing.Point(1074, 5);
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
            this.PanelContainer.Controls.Add(this.PanelMaintence);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1191, 924);
            this.PanelContainer.TabIndex = 1;
            // 
            // PanelMaintence
            // 
            this.PanelMaintence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelMaintence.BackColor = System.Drawing.Color.LightGray;
            this.PanelMaintence.Controls.Add(this.panel5);
            this.PanelMaintence.Controls.Add(this.panel4);
            this.PanelMaintence.Controls.Add(this.panel3);
            this.PanelMaintence.Controls.Add(this.BoxVehicle);
            this.PanelMaintence.Controls.Add(this.LabelResult);
            this.PanelMaintence.Controls.Add(this.LabelTotal);
            this.PanelMaintence.Controls.Add(this.NumberQtd);
            this.PanelMaintence.Controls.Add(this.LabelQtd);
            this.PanelMaintence.Controls.Add(this.TextPrice);
            this.PanelMaintence.Controls.Add(this.LabelPrice);
            this.PanelMaintence.Controls.Add(this.PeçaCorretiva);
            this.PanelMaintence.Controls.Add(this.PecaLabel);
            this.PanelMaintence.Controls.Add(this.LabelVehicle);
            this.PanelMaintence.Controls.Add(this.dateTimeMaintence);
            this.PanelMaintence.Controls.Add(this.LabelData);
            this.PanelMaintence.Controls.Add(this.panel2);
            this.PanelMaintence.Controls.Add(this.panel1);
            this.PanelMaintence.Controls.Add(this.BoxDriver);
            this.PanelMaintence.Controls.Add(this.BoxPreventiva);
            this.PanelMaintence.Controls.Add(this.LabelObservation);
            this.PanelMaintence.Controls.Add(this.TextObservation);
            this.PanelMaintence.Controls.Add(this.LabelDriver);
            this.PanelMaintence.Controls.Add(this.radioButtonCorretiva);
            this.PanelMaintence.Controls.Add(this.radioButtonPreventiva);
            this.PanelMaintence.Controls.Add(this.TextCorretiva);
            this.PanelMaintence.Controls.Add(this.LabelName);
            this.PanelMaintence.Controls.Add(this.DivPanel);
            this.PanelMaintence.Controls.Add(this.ButtonCancel);
            this.PanelMaintence.Controls.Add(this.ButtonSave);
            this.PanelMaintence.Controls.Add(this.PanelTitle);
            this.PanelMaintence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelMaintence.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelMaintence.Location = new System.Drawing.Point(107, 40);
            this.PanelMaintence.Name = "PanelMaintence";
            this.PanelMaintence.Size = new System.Drawing.Size(970, 589);
            this.PanelMaintence.TabIndex = 0;
            this.PanelMaintence.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMaintence_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkGreen;
            this.panel5.Location = new System.Drawing.Point(608, 294);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(80, 2);
            this.panel5.TabIndex = 111;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGreen;
            this.panel4.Location = new System.Drawing.Point(608, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 2);
            this.panel4.TabIndex = 110;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkGreen;
            this.panel3.Location = new System.Drawing.Point(608, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 2);
            this.panel3.TabIndex = 90;
            // 
            // BoxVehicle
            // 
            this.BoxVehicle.AllowDrop = true;
            this.BoxVehicle.BackColor = System.Drawing.Color.LightGray;
            this.BoxVehicle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxVehicle.FormattingEnabled = true;
            this.BoxVehicle.Location = new System.Drawing.Point(608, 209);
            this.BoxVehicle.Name = "BoxVehicle";
            this.BoxVehicle.Size = new System.Drawing.Size(233, 28);
            this.BoxVehicle.TabIndex = 109;
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.BackColor = System.Drawing.Color.LightGray;
            this.LabelResult.ForeColor = System.Drawing.Color.Black;
            this.LabelResult.Location = new System.Drawing.Point(736, 396);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(83, 20);
            this.LabelResult.TabIndex = 108;
            this.LabelResult.Text = "Total Price";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTotal.ForeColor = System.Drawing.Color.Gray;
            this.LabelTotal.Location = new System.Drawing.Point(530, 396);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(49, 20);
            this.LabelTotal.TabIndex = 101;
            this.LabelTotal.Text = "Total";
            // 
            // NumberQtd
            // 
            this.NumberQtd.BackColor = System.Drawing.Color.LightGray;
            this.NumberQtd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.NumberQtd.Location = new System.Drawing.Point(833, 274);
            this.NumberQtd.Name = "NumberQtd";
            this.NumberQtd.Size = new System.Drawing.Size(40, 22);
            this.NumberQtd.TabIndex = 107;
            // 
            // LabelQtd
            // 
            this.LabelQtd.AutoSize = true;
            this.LabelQtd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelQtd.ForeColor = System.Drawing.Color.Gray;
            this.LabelQtd.Location = new System.Drawing.Point(713, 276);
            this.LabelQtd.Name = "LabelQtd";
            this.LabelQtd.Size = new System.Drawing.Size(102, 20);
            this.LabelQtd.TabIndex = 106;
            this.LabelQtd.Text = "Quantidade";
            // 
            // TextPrice
            // 
            this.TextPrice.BackColor = System.Drawing.Color.LightGray;
            this.TextPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPrice.Location = new System.Drawing.Point(608, 273);
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.Size = new System.Drawing.Size(80, 19);
            this.TextPrice.TabIndex = 105;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.ForeColor = System.Drawing.Color.Gray;
            this.LabelPrice.Location = new System.Drawing.Point(525, 271);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(55, 20);
            this.LabelPrice.TabIndex = 104;
            this.LabelPrice.Text = "Preço";
            // 
            // PeçaCorretiva
            // 
            this.PeçaCorretiva.BackColor = System.Drawing.Color.LightGray;
            this.PeçaCorretiva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeçaCorretiva.Location = new System.Drawing.Point(608, 336);
            this.PeçaCorretiva.Name = "PeçaCorretiva";
            this.PeçaCorretiva.Size = new System.Drawing.Size(233, 19);
            this.PeçaCorretiva.TabIndex = 103;
            // 
            // PecaLabel
            // 
            this.PecaLabel.AutoSize = true;
            this.PecaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PecaLabel.ForeColor = System.Drawing.Color.Gray;
            this.PecaLabel.Location = new System.Drawing.Point(525, 336);
            this.PecaLabel.Name = "PecaLabel";
            this.PecaLabel.Size = new System.Drawing.Size(49, 20);
            this.PecaLabel.TabIndex = 102;
            this.PecaLabel.Text = "Peça";
            // 
            // LabelVehicle
            // 
            this.LabelVehicle.AutoSize = true;
            this.LabelVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelVehicle.ForeColor = System.Drawing.Color.Gray;
            this.LabelVehicle.Location = new System.Drawing.Point(525, 212);
            this.LabelVehicle.Name = "LabelVehicle";
            this.LabelVehicle.Size = new System.Drawing.Size(68, 20);
            this.LabelVehicle.TabIndex = 98;
            this.LabelVehicle.Text = "Veículo";
            // 
            // dateTimeMaintence
            // 
            this.dateTimeMaintence.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeMaintence.Location = new System.Drawing.Point(619, 125);
            this.dateTimeMaintence.Name = "dateTimeMaintence";
            this.dateTimeMaintence.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dateTimeMaintence.RightToLeftLayout = true;
            this.dateTimeMaintence.Size = new System.Drawing.Size(133, 26);
            this.dateTimeMaintence.TabIndex = 100;
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelData.ForeColor = System.Drawing.Color.Gray;
            this.LabelData.Location = new System.Drawing.Point(530, 130);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(48, 20);
            this.LabelData.TabIndex = 99;
            this.LabelData.Text = "Data";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.Location = new System.Drawing.Point(76, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 2);
            this.panel2.TabIndex = 90;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Location = new System.Drawing.Point(76, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 2);
            this.panel1.TabIndex = 89;
            // 
            // BoxDriver
            // 
            this.BoxDriver.AllowDrop = true;
            this.BoxDriver.BackColor = System.Drawing.Color.LightGray;
            this.BoxDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxDriver.FormattingEnabled = true;
            this.BoxDriver.Location = new System.Drawing.Point(76, 307);
            this.BoxDriver.Name = "BoxDriver";
            this.BoxDriver.Size = new System.Drawing.Size(201, 28);
            this.BoxDriver.TabIndex = 97;
            // 
            // BoxPreventiva
            // 
            this.BoxPreventiva.AllowDrop = true;
            this.BoxPreventiva.BackColor = System.Drawing.Color.LightGray;
            this.BoxPreventiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxPreventiva.FormattingEnabled = true;
            this.BoxPreventiva.Location = new System.Drawing.Point(76, 204);
            this.BoxPreventiva.Name = "BoxPreventiva";
            this.BoxPreventiva.Size = new System.Drawing.Size(201, 28);
            this.BoxPreventiva.TabIndex = 96;
            // 
            // LabelObservation
            // 
            this.LabelObservation.AutoSize = true;
            this.LabelObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelObservation.ForeColor = System.Drawing.Color.Gray;
            this.LabelObservation.Location = new System.Drawing.Point(71, 357);
            this.LabelObservation.Name = "LabelObservation";
            this.LabelObservation.Size = new System.Drawing.Size(104, 20);
            this.LabelObservation.TabIndex = 95;
            this.LabelObservation.Text = "Observação";
            // 
            // TextObservation
            // 
            this.TextObservation.Location = new System.Drawing.Point(76, 385);
            this.TextObservation.Name = "TextObservation";
            this.TextObservation.Size = new System.Drawing.Size(329, 133);
            this.TextObservation.TabIndex = 94;
            this.TextObservation.Text = "";
            // 
            // LabelDriver
            // 
            this.LabelDriver.AutoSize = true;
            this.LabelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDriver.ForeColor = System.Drawing.Color.Gray;
            this.LabelDriver.Location = new System.Drawing.Point(71, 275);
            this.LabelDriver.Name = "LabelDriver";
            this.LabelDriver.Size = new System.Drawing.Size(84, 20);
            this.LabelDriver.TabIndex = 91;
            this.LabelDriver.Text = "Motorista";
            // 
            // radioButtonCorretiva
            // 
            this.radioButtonCorretiva.AutoSize = true;
            this.radioButtonCorretiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCorretiva.ForeColor = System.Drawing.Color.Gray;
            this.radioButtonCorretiva.Location = new System.Drawing.Point(216, 126);
            this.radioButtonCorretiva.Name = "radioButtonCorretiva";
            this.radioButtonCorretiva.Size = new System.Drawing.Size(99, 24);
            this.radioButtonCorretiva.TabIndex = 90;
            this.radioButtonCorretiva.TabStop = true;
            this.radioButtonCorretiva.Text = "Corretiva";
            this.radioButtonCorretiva.UseVisualStyleBackColor = true;
            // 
            // radioButtonPreventiva
            // 
            this.radioButtonPreventiva.AutoSize = true;
            this.radioButtonPreventiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonPreventiva.ForeColor = System.Drawing.Color.Gray;
            this.radioButtonPreventiva.Location = new System.Drawing.Point(82, 126);
            this.radioButtonPreventiva.Name = "radioButtonPreventiva";
            this.radioButtonPreventiva.Size = new System.Drawing.Size(110, 24);
            this.radioButtonPreventiva.TabIndex = 89;
            this.radioButtonPreventiva.TabStop = true;
            this.radioButtonPreventiva.Text = "Preventiva";
            this.radioButtonPreventiva.UseVisualStyleBackColor = true;
            // 
            // TextCorretiva
            // 
            this.TextCorretiva.BackColor = System.Drawing.Color.Black;
            this.TextCorretiva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextCorretiva.Location = new System.Drawing.Point(76, 220);
            this.TextCorretiva.Name = "TextCorretiva";
            this.TextCorretiva.Size = new System.Drawing.Size(201, 19);
            this.TextCorretiva.TabIndex = 93;
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.Gray;
            this.LabelName.Location = new System.Drawing.Point(71, 189);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(159, 20);
            this.LabelName.TabIndex = 92;
            this.LabelName.Text = "Nome Manutenção";
            // 
            // DivPanel
            // 
            this.DivPanel.BackColor = System.Drawing.Color.DarkGreen;
            this.DivPanel.Location = new System.Drawing.Point(466, 126);
            this.DivPanel.Name = "DivPanel";
            this.DivPanel.Size = new System.Drawing.Size(2, 343);
            this.DivPanel.TabIndex = 88;
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.FlatAppearance.BorderSize = 2;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.DarkGreen;
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
            this.ButtonSave.BackColor = System.Drawing.Color.DarkGreen;
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
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.DarkGreen;
            this.PanelTitle.Controls.Add(this.Title);
            this.PanelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(970, 87);
            this.PanelTitle.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Impact", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.Azure;
            this.Title.Location = new System.Drawing.Point(35, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(427, 48);
            this.Title.TabIndex = 41;
            this.Title.Text = "Cadastro de Manutenção";
            // 
            // PageDescription
            // 
            this.PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescription.AutoSize = true;
            this.PageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescription.ForeColor = System.Drawing.Color.Azure;
            this.PageDescription.Location = new System.Drawing.Point(776, 2);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(305, 31);
            this.PageDescription.TabIndex = 42;
            this.PageDescription.Text = "Cadastrar Manutenção /";
            // 
            // Manutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.Controls.Add(this.PanelMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "Manutencao";
            this.Size = new System.Drawing.Size(1220, 990);
            this.Load += new System.EventHandler(this.Manutencao_Load);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelMaintence.ResumeLayout(false);
            this.PanelMaintence.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumberQtd)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelMaintence;
        private System.Windows.Forms.Panel DivPanel;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.ComboBox BoxDriver;
        private System.Windows.Forms.ComboBox BoxPreventiva;
        private System.Windows.Forms.Label LabelObservation;
        private System.Windows.Forms.RichTextBox TextObservation;
        private System.Windows.Forms.Label LabelDriver;
        private System.Windows.Forms.RadioButton radioButtonCorretiva;
        private System.Windows.Forms.RadioButton radioButtonPreventiva;
        private System.Windows.Forms.TextBox TextCorretiva;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox BoxVehicle;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.NumericUpDown NumberQtd;
        private System.Windows.Forms.Label LabelQtd;
        private System.Windows.Forms.TextBox TextPrice;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox PeçaCorretiva;
        private System.Windows.Forms.Label PecaLabel;
        private System.Windows.Forms.Label LabelVehicle;
        private System.Windows.Forms.DateTimePicker dateTimeMaintence;
        private System.Windows.Forms.Label LabelData;
    }
}
