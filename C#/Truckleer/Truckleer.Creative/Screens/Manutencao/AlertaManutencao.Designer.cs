namespace Truckleer.Creative
{
    partial class AlertaManutencao
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
            this.PanelDriver = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PeçaCorretiva = new System.Windows.Forms.TextBox();
            this.PecaLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelVeiculoSupply = new System.Windows.Forms.Label();
            this.DivPanel = new System.Windows.Forms.Panel();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.PageDescription = new System.Windows.Forms.Label();
            this.BorderPanel1 = new System.Windows.Forms.Panel();
            this.BorderPanel2 = new System.Windows.Forms.Panel();
            this.BorderPanel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ContainerListas = new System.Windows.Forms.Panel();
            this.ContainerObservation = new System.Windows.Forms.Panel();
            this.PanelMain.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.PanelDriver.SuspendLayout();
            this.PanelTitle.SuspendLayout();
            this.ContainerListas.SuspendLayout();
            this.ContainerObservation.SuspendLayout();
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
            this.PanelContainer.Controls.Add(this.PanelDriver);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1191, 924);
            this.PanelContainer.TabIndex = 1;
            // 
            // PanelDriver
            // 
            this.PanelDriver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelDriver.BackColor = System.Drawing.Color.LightGray;
            this.PanelDriver.Controls.Add(this.ContainerObservation);
            this.PanelDriver.Controls.Add(this.ContainerListas);
            this.PanelDriver.Controls.Add(this.panel1);
            this.PanelDriver.Controls.Add(this.BorderPanel3);
            this.PanelDriver.Controls.Add(this.BorderPanel2);
            this.PanelDriver.Controls.Add(this.BorderPanel1);
            this.PanelDriver.Controls.Add(this.textBox2);
            this.PanelDriver.Controls.Add(this.label2);
            this.PanelDriver.Controls.Add(this.label3);
            this.PanelDriver.Controls.Add(this.button1);
            this.PanelDriver.Controls.Add(this.textBox1);
            this.PanelDriver.Controls.Add(this.label1);
            this.PanelDriver.Controls.Add(this.PeçaCorretiva);
            this.PanelDriver.Controls.Add(this.PecaLabel);
            this.PanelDriver.Controls.Add(this.comboBox1);
            this.PanelDriver.Controls.Add(this.labelVeiculoSupply);
            this.PanelDriver.Controls.Add(this.DivPanel);
            this.PanelDriver.Controls.Add(this.ButtonCancel);
            this.PanelDriver.Controls.Add(this.ButtonSave);
            this.PanelDriver.Controls.Add(this.PanelTitle);
            this.PanelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelDriver.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PanelDriver.Location = new System.Drawing.Point(107, 40);
            this.PanelDriver.Name = "PanelDriver";
            this.PanelDriver.Size = new System.Drawing.Size(970, 589);
            this.PanelDriver.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.LightGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(91, 296);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(206, 23);
            this.textBox2.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(86, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 101;
            this.label2.Text = "E-mail";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(221, 220);
            this.listBox1.TabIndex = 100;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(83, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 99;
            this.label3.Text = "Observação";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(300, 155);
            this.richTextBox1.TabIndex = 98;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Azure;
            this.button1.Location = new System.Drawing.Point(717, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 30);
            this.button1.TabIndex = 97;
            this.button1.Text = "Inserir Peça";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.LightGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(505, 147);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 23);
            this.textBox1.TabIndex = 92;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(500, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 91;
            this.label1.Text = "Peça";
            // 
            // PeçaCorretiva
            // 
            this.PeçaCorretiva.BackColor = System.Drawing.Color.LightGray;
            this.PeçaCorretiva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PeçaCorretiva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PeçaCorretiva.Location = new System.Drawing.Point(88, 226);
            this.PeçaCorretiva.Name = "PeçaCorretiva";
            this.PeçaCorretiva.Size = new System.Drawing.Size(206, 23);
            this.PeçaCorretiva.TabIndex = 96;
            // 
            // PecaLabel
            // 
            this.PecaLabel.AutoSize = true;
            this.PecaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PecaLabel.ForeColor = System.Drawing.Color.Gray;
            this.PecaLabel.Location = new System.Drawing.Point(85, 198);
            this.PecaLabel.Name = "PecaLabel";
            this.PecaLabel.Size = new System.Drawing.Size(68, 25);
            this.PecaLabel.TabIndex = 95;
            this.PecaLabel.Text = "Nome";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(88, 144);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 33);
            this.comboBox1.TabIndex = 94;
            // 
            // labelVeiculoSupply
            // 
            this.labelVeiculoSupply.AutoSize = true;
            this.labelVeiculoSupply.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVeiculoSupply.ForeColor = System.Drawing.Color.Gray;
            this.labelVeiculoSupply.Location = new System.Drawing.Point(83, 116);
            this.labelVeiculoSupply.Name = "labelVeiculoSupply";
            this.labelVeiculoSupply.Size = new System.Drawing.Size(84, 25);
            this.labelVeiculoSupply.TabIndex = 93;
            this.labelVeiculoSupply.Text = "Veículo";
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
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
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
            this.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.ButtonSave.FlatAppearance.BorderSize = 2;
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
            this.title.Size = new System.Drawing.Size(287, 48);
            this.title.TabIndex = 41;
            this.title.Text = "Cadastrar Alerta";
            // 
            // PageDescription
            // 
            this.PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescription.AutoSize = true;
            this.PageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescription.ForeColor = System.Drawing.Color.Azure;
            this.PageDescription.Location = new System.Drawing.Point(854, 5);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(268, 31);
            this.PageDescription.TabIndex = 42;
            this.PageDescription.Text = "Cadastrar Motorista /";
            // 
            // BorderPanel1
            // 
            this.BorderPanel1.BackColor = System.Drawing.Color.DarkGreen;
            this.BorderPanel1.Location = new System.Drawing.Point(90, 175);
            this.BorderPanel1.Name = "BorderPanel1";
            this.BorderPanel1.Size = new System.Drawing.Size(204, 2);
            this.BorderPanel1.TabIndex = 89;
            // 
            // BorderPanel2
            // 
            this.BorderPanel2.BackColor = System.Drawing.Color.DarkGreen;
            this.BorderPanel2.Location = new System.Drawing.Point(90, 251);
            this.BorderPanel2.Name = "BorderPanel2";
            this.BorderPanel2.Size = new System.Drawing.Size(204, 2);
            this.BorderPanel2.TabIndex = 90;
            // 
            // BorderPanel3
            // 
            this.BorderPanel3.BackColor = System.Drawing.Color.DarkGreen;
            this.BorderPanel3.Location = new System.Drawing.Point(505, 172);
            this.BorderPanel3.Name = "BorderPanel3";
            this.BorderPanel3.Size = new System.Drawing.Size(204, 2);
            this.BorderPanel3.TabIndex = 91;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Location = new System.Drawing.Point(92, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 2);
            this.panel1.TabIndex = 92;
            // 
            // ContainerListas
            // 
            this.ContainerListas.BackColor = System.Drawing.Color.DarkGreen;
            this.ContainerListas.Controls.Add(this.listBox1);
            this.ContainerListas.Location = new System.Drawing.Point(516, 226);
            this.ContainerListas.Name = "ContainerListas";
            this.ContainerListas.Size = new System.Drawing.Size(227, 227);
            this.ContainerListas.TabIndex = 103;
            // 
            // ContainerObservation
            // 
            this.ContainerObservation.BackColor = System.Drawing.Color.DarkGreen;
            this.ContainerObservation.Controls.Add(this.richTextBox1);
            this.ContainerObservation.Location = new System.Drawing.Point(88, 395);
            this.ContainerObservation.Name = "ContainerObservation";
            this.ContainerObservation.Size = new System.Drawing.Size(306, 161);
            this.ContainerObservation.TabIndex = 104;
            // 
            // AlertaManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.PanelMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AlertaManutencao";
            this.Size = new System.Drawing.Size(1220, 990);
            this.PanelMain.ResumeLayout(false);
            this.PanelMain.PerformLayout();
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelDriver.ResumeLayout(false);
            this.PanelDriver.PerformLayout();
            this.PanelTitle.ResumeLayout(false);
            this.PanelTitle.PerformLayout();
            this.ContainerListas.ResumeLayout(false);
            this.ContainerObservation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelDriver;
        private System.Windows.Forms.Panel DivPanel;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PeçaCorretiva;
        private System.Windows.Forms.Label PecaLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelVeiculoSupply;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel ContainerListas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel BorderPanel3;
        private System.Windows.Forms.Panel BorderPanel2;
        private System.Windows.Forms.Panel BorderPanel1;
        private System.Windows.Forms.Panel ContainerObservation;
    }
}
