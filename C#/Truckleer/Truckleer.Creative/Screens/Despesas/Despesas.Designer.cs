namespace Truckleer.Creative.Screens.Despesas
{
    partial class Despesas
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
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.PanelCadastro = new System.Windows.Forms.Panel();
            this.TextObservation = new System.Windows.Forms.TextBox();
            this.LabelObservation = new System.Windows.Forms.Label();
            this.TextPrice = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.BorderPanel1 = new System.Windows.Forms.Panel();
            this.title = new System.Windows.Forms.Label();
            this.ButtonCancel = new System.Windows.Forms.Button();
            this.BoxTrip = new System.Windows.Forms.ComboBox();
            this.LabelTrip = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.DateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelData = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BoxDriver = new System.Windows.Forms.ComboBox();
            this.LabelDriver = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.PanelContainer.SuspendLayout();
            this.PanelCadastro.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.PanelMain.Controls.Add(this.layoutFlex);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1096, 759);
            this.PanelMain.TabIndex = 6;
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
            this.layoutFlex.Size = new System.Drawing.Size(1067, 693);
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
            this.MainPanel.Size = new System.Drawing.Size(1067, 693);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelContainer.Controls.Add(this.PanelCadastro);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1067, 693);
            this.PanelContainer.TabIndex = 1;
            // 
            // PanelCadastro
            // 
            this.PanelCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelCadastro.AutoSize = true;
            this.PanelCadastro.BackColor = System.Drawing.Color.Azure;
            this.PanelCadastro.Controls.Add(this.panel3);
            this.PanelCadastro.Controls.Add(this.BoxDriver);
            this.PanelCadastro.Controls.Add(this.LabelDriver);
            this.PanelCadastro.Controls.Add(this.TextObservation);
            this.PanelCadastro.Controls.Add(this.LabelObservation);
            this.PanelCadastro.Controls.Add(this.TextPrice);
            this.PanelCadastro.Controls.Add(this.panel1);
            this.PanelCadastro.Controls.Add(this.LabelPrice);
            this.PanelCadastro.Controls.Add(this.panel4);
            this.PanelCadastro.Controls.Add(this.panel2);
            this.PanelCadastro.Controls.Add(this.BorderPanel1);
            this.PanelCadastro.Controls.Add(this.title);
            this.PanelCadastro.Controls.Add(this.ButtonCancel);
            this.PanelCadastro.Controls.Add(this.BoxTrip);
            this.PanelCadastro.Controls.Add(this.LabelTrip);
            this.PanelCadastro.Controls.Add(this.ButtonSave);
            this.PanelCadastro.Controls.Add(this.LabelName);
            this.PanelCadastro.Controls.Add(this.TextName);
            this.PanelCadastro.Controls.Add(this.DateTimePicker);
            this.PanelCadastro.Controls.Add(this.labelData);
            this.PanelCadastro.Location = new System.Drawing.Point(163, 22);
            this.PanelCadastro.Name = "PanelCadastro";
            this.PanelCadastro.Size = new System.Drawing.Size(502, 606);
            this.PanelCadastro.TabIndex = 28;
            // 
            // TextObservation
            // 
            this.TextObservation.Location = new System.Drawing.Point(27, 443);
            this.TextObservation.Multiline = true;
            this.TextObservation.Name = "TextObservation";
            this.TextObservation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextObservation.Size = new System.Drawing.Size(442, 88);
            this.TextObservation.TabIndex = 87;
            // 
            // LabelObservation
            // 
            this.LabelObservation.AutoSize = true;
            this.LabelObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelObservation.ForeColor = System.Drawing.Color.Gray;
            this.LabelObservation.Location = new System.Drawing.Point(23, 420);
            this.LabelObservation.Name = "LabelObservation";
            this.LabelObservation.Size = new System.Drawing.Size(104, 20);
            this.LabelObservation.TabIndex = 86;
            this.LabelObservation.Text = "Observação";
            // 
            // TextPrice
            // 
            this.TextPrice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextPrice.BackColor = System.Drawing.Color.Azure;
            this.TextPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPrice.Location = new System.Drawing.Point(28, 298);
            this.TextPrice.MaxLength = 10;
            this.TextPrice.Name = "TextPrice";
            this.TextPrice.Size = new System.Drawing.Size(145, 23);
            this.TextPrice.TabIndex = 47;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel1.Location = new System.Drawing.Point(26, 322);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 2);
            this.panel1.TabIndex = 44;
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPrice.ForeColor = System.Drawing.Color.Gray;
            this.LabelPrice.Location = new System.Drawing.Point(20, 272);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(51, 20);
            this.LabelPrice.TabIndex = 46;
            this.LabelPrice.Text = "Valor";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(27, 179);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(140, 2);
            this.panel4.TabIndex = 45;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel2.Location = new System.Drawing.Point(21, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(267, 2);
            this.panel2.TabIndex = 43;
            // 
            // BorderPanel1
            // 
            this.BorderPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BorderPanel1.Location = new System.Drawing.Point(26, 115);
            this.BorderPanel1.Name = "BorderPanel1";
            this.BorderPanel1.Size = new System.Drawing.Size(444, 2);
            this.BorderPanel1.TabIndex = 41;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Black;
            this.title.Location = new System.Drawing.Point(273, 62);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(222, 26);
            this.title.TabIndex = 40;
            this.title.Text = "Cadastro de Despesa";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCancel.BackColor = System.Drawing.Color.Transparent;
            this.ButtonCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonCancel.FlatAppearance.BorderSize = 2;
            this.ButtonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCancel.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonCancel.Location = new System.Drawing.Point(389, 552);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(97, 32);
            this.ButtonCancel.TabIndex = 39;
            this.ButtonCancel.Text = "Cancelar";
            this.ButtonCancel.UseVisualStyleBackColor = false;
            // 
            // BoxTrip
            // 
            this.BoxTrip.AllowDrop = true;
            this.BoxTrip.BackColor = System.Drawing.Color.Azure;
            this.BoxTrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxTrip.FormattingEnabled = true;
            this.BoxTrip.Location = new System.Drawing.Point(22, 221);
            this.BoxTrip.Name = "BoxTrip";
            this.BoxTrip.Size = new System.Drawing.Size(266, 28);
            this.BoxTrip.TabIndex = 35;
            // 
            // LabelTrip
            // 
            this.LabelTrip.AutoSize = true;
            this.LabelTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrip.ForeColor = System.Drawing.Color.Gray;
            this.LabelTrip.Location = new System.Drawing.Point(20, 196);
            this.LabelTrip.Name = "LabelTrip";
            this.LabelTrip.Size = new System.Drawing.Size(69, 20);
            this.LabelTrip.TabIndex = 34;
            this.LabelTrip.Text = "Viagem";
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ButtonSave.FlatAppearance.BorderSize = 0;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.Azure;
            this.ButtonSave.Location = new System.Drawing.Point(278, 552);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(97, 32);
            this.ButtonSave.TabIndex = 38;
            this.ButtonSave.Text = "Salvar";
            this.ButtonSave.UseVisualStyleBackColor = false;
            // 
            // LabelName
            // 
            this.LabelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelName.ForeColor = System.Drawing.Color.Gray;
            this.LabelName.Location = new System.Drawing.Point(24, 61);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(144, 20);
            this.LabelName.TabIndex = 32;
            this.LabelName.Text = "Tipo da Despesa";
            // 
            // TextName
            // 
            this.TextName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextName.BackColor = System.Drawing.Color.Azure;
            this.TextName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextName.Location = new System.Drawing.Point(28, 92);
            this.TextName.MaxLength = 10;
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(444, 23);
            this.TextName.TabIndex = 33;
            // 
            // DateTimePicker
            // 
            this.DateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker.Location = new System.Drawing.Point(26, 155);
            this.DateTimePicker.Name = "DateTimePicker";
            this.DateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DateTimePicker.RightToLeftLayout = true;
            this.DateTimePicker.Size = new System.Drawing.Size(141, 26);
            this.DateTimePicker.TabIndex = 31;
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.ForeColor = System.Drawing.Color.Gray;
            this.labelData.Location = new System.Drawing.Point(24, 132);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 20);
            this.labelData.TabIndex = 30;
            this.labelData.Text = "Data";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(25, 405);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 2);
            this.panel3.TabIndex = 90;
            // 
            // BoxDriver
            // 
            this.BoxDriver.AllowDrop = true;
            this.BoxDriver.BackColor = System.Drawing.Color.Azure;
            this.BoxDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxDriver.FormattingEnabled = true;
            this.BoxDriver.Location = new System.Drawing.Point(26, 376);
            this.BoxDriver.Name = "BoxDriver";
            this.BoxDriver.Size = new System.Drawing.Size(266, 28);
            this.BoxDriver.TabIndex = 89;
            // 
            // LabelDriver
            // 
            this.LabelDriver.AutoSize = true;
            this.LabelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDriver.ForeColor = System.Drawing.Color.Gray;
            this.LabelDriver.Location = new System.Drawing.Point(24, 351);
            this.LabelDriver.Name = "LabelDriver";
            this.LabelDriver.Size = new System.Drawing.Size(84, 20);
            this.LabelDriver.TabIndex = 88;
            this.LabelDriver.Text = "Motorista";
            // 
            // Despesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelMain);
            this.Name = "Despesas";
            this.Size = new System.Drawing.Size(1096, 759);
            this.Load += new System.EventHandler(this.Despesas_Load);
            this.PanelMain.ResumeLayout(false);
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            this.PanelCadastro.ResumeLayout(false);
            this.PanelCadastro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel PanelCadastro;
        private System.Windows.Forms.TextBox TextObservation;
        private System.Windows.Forms.Label LabelObservation;
        private System.Windows.Forms.TextBox TextPrice;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel BorderPanel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button ButtonCancel;
        private System.Windows.Forms.ComboBox BoxTrip;
        private System.Windows.Forms.Label LabelTrip;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.DateTimePicker DateTimePicker;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox BoxDriver;
        private System.Windows.Forms.Label LabelDriver;
    }
}
