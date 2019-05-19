namespace Truckleer.Creative
{
    partial class ListarManutencao
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
            this.components = new System.ComponentModel.Container();
            this.container = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.PageDescription = new System.Windows.Forms.Label();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.filter = new System.Windows.Forms.Panel();
            this.radioButtonCorretiva = new System.Windows.Forms.RadioButton();
            this.radioButtonPreventiva = new System.Windows.Forms.RadioButton();
            this.LabelPlate = new System.Windows.Forms.Label();
            this.BoxPlate = new System.Windows.Forms.ComboBox();
            this.LabelMaintence = new System.Windows.Forms.Label();
            this.LabelDataFinal = new System.Windows.Forms.Label();
            this.DataPickerFinal = new System.Windows.Forms.DateTimePicker();
            this.LabelDataInicio = new System.Windows.Forms.Label();
            this.DataPickerInicio = new System.Windows.Forms.DateTimePicker();
            this.ComboMaintence = new System.Windows.Forms.ComboBox();
            this.timerFiltro = new System.Windows.Forms.Timer(this.components);
            this.ButtonSave = new System.Windows.Forms.Button();
            this.container.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(33)))), ((int)(((byte)(34)))));
            this.container.Controls.Add(this.ButtonHome);
            this.container.Controls.Add(this.PageDescription);
            this.container.Controls.Add(this.ButtonFilter);
            this.container.Controls.Add(this.layoutFlex);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(1170, 759);
            this.container.TabIndex = 1;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.Azure;
            this.ButtonHome.Location = new System.Drawing.Point(1028, 3);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(76, 31);
            this.ButtonHome.TabIndex = 49;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            // 
            // PageDescription
            // 
            this.PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescription.AutoSize = true;
            this.PageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescription.ForeColor = System.Drawing.Color.Azure;
            this.PageDescription.Location = new System.Drawing.Point(777, 2);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(257, 31);
            this.PageDescription.TabIndex = 48;
            this.PageDescription.Text = "Listar Manitenções /";
            // 
            // ButtonFilter
            // 
            this.ButtonFilter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ButtonFilter.FlatAppearance.BorderSize = 0;
            this.ButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFilter.Location = new System.Drawing.Point(39, 21);
            this.ButtonFilter.Name = "ButtonFilter";
            this.ButtonFilter.Size = new System.Drawing.Size(75, 28);
            this.ButtonFilter.TabIndex = 33;
            this.ButtonFilter.Text = "Filtros";
            this.ButtonFilter.UseVisualStyleBackColor = false;
            this.ButtonFilter.Click += new System.EventHandler(this.Button1_Click);
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
            this.layoutFlex.Size = new System.Drawing.Size(1141, 693);
            this.layoutFlex.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.PanelContainer);
            this.MainPanel.Controls.Add(this.filter);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1141, 693);
            this.MainPanel.TabIndex = 0;
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 105);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1141, 588);
            this.PanelContainer.TabIndex = 1;
            // 
            // filter
            // 
            this.filter.BackColor = System.Drawing.Color.DarkGreen;
            this.filter.Controls.Add(this.ButtonSave);
            this.filter.Controls.Add(this.radioButtonCorretiva);
            this.filter.Controls.Add(this.radioButtonPreventiva);
            this.filter.Controls.Add(this.LabelPlate);
            this.filter.Controls.Add(this.BoxPlate);
            this.filter.Controls.Add(this.LabelMaintence);
            this.filter.Controls.Add(this.LabelDataFinal);
            this.filter.Controls.Add(this.DataPickerFinal);
            this.filter.Controls.Add(this.LabelDataInicio);
            this.filter.Controls.Add(this.DataPickerInicio);
            this.filter.Controls.Add(this.ComboMaintence);
            this.filter.Dock = System.Windows.Forms.DockStyle.Top;
            this.filter.Location = new System.Drawing.Point(0, 0);
            this.filter.Margin = new System.Windows.Forms.Padding(0);
            this.filter.MaximumSize = new System.Drawing.Size(2000, 105);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(1141, 105);
            this.filter.TabIndex = 0;
            // 
            // radioButtonCorretiva
            // 
            this.radioButtonCorretiva.AutoSize = true;
            this.radioButtonCorretiva.ForeColor = System.Drawing.Color.Azure;
            this.radioButtonCorretiva.Location = new System.Drawing.Point(39, 66);
            this.radioButtonCorretiva.Name = "radioButtonCorretiva";
            this.radioButtonCorretiva.Size = new System.Drawing.Size(67, 17);
            this.radioButtonCorretiva.TabIndex = 32;
            this.radioButtonCorretiva.TabStop = true;
            this.radioButtonCorretiva.Text = "Corretiva";
            this.radioButtonCorretiva.UseVisualStyleBackColor = true;
            // 
            // radioButtonPreventiva
            // 
            this.radioButtonPreventiva.AutoSize = true;
            this.radioButtonPreventiva.ForeColor = System.Drawing.Color.Azure;
            this.radioButtonPreventiva.Location = new System.Drawing.Point(39, 39);
            this.radioButtonPreventiva.Name = "radioButtonPreventiva";
            this.radioButtonPreventiva.Size = new System.Drawing.Size(76, 17);
            this.radioButtonPreventiva.TabIndex = 31;
            this.radioButtonPreventiva.TabStop = true;
            this.radioButtonPreventiva.Text = "Preventiva";
            this.radioButtonPreventiva.UseVisualStyleBackColor = true;
            // 
            // LabelPlate
            // 
            this.LabelPlate.AutoSize = true;
            this.LabelPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlate.ForeColor = System.Drawing.Color.Azure;
            this.LabelPlate.Location = new System.Drawing.Point(631, 36);
            this.LabelPlate.Name = "LabelPlate";
            this.LabelPlate.Size = new System.Drawing.Size(48, 20);
            this.LabelPlate.TabIndex = 30;
            this.LabelPlate.Text = "Placa";
            // 
            // BoxPlate
            // 
            this.BoxPlate.FormattingEnabled = true;
            this.BoxPlate.Location = new System.Drawing.Point(635, 59);
            this.BoxPlate.Name = "BoxPlate";
            this.BoxPlate.Size = new System.Drawing.Size(121, 21);
            this.BoxPlate.TabIndex = 29;
            // 
            // LabelMaintence
            // 
            this.LabelMaintence.AutoSize = true;
            this.LabelMaintence.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelMaintence.ForeColor = System.Drawing.Color.Azure;
            this.LabelMaintence.Location = new System.Drawing.Point(387, 36);
            this.LabelMaintence.Name = "LabelMaintence";
            this.LabelMaintence.Size = new System.Drawing.Size(98, 20);
            this.LabelMaintence.TabIndex = 28;
            this.LabelMaintence.Text = "Manutenção";
            // 
            // LabelDataFinal
            // 
            this.LabelDataFinal.AutoSize = true;
            this.LabelDataFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDataFinal.ForeColor = System.Drawing.Color.Azure;
            this.LabelDataFinal.Location = new System.Drawing.Point(254, 36);
            this.LabelDataFinal.Name = "LabelDataFinal";
            this.LabelDataFinal.Size = new System.Drawing.Size(82, 20);
            this.LabelDataFinal.TabIndex = 27;
            this.LabelDataFinal.Text = "Data Final";
            // 
            // DataPickerFinal
            // 
            this.DataPickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataPickerFinal.Location = new System.Drawing.Point(258, 59);
            this.DataPickerFinal.Name = "DataPickerFinal";
            this.DataPickerFinal.Size = new System.Drawing.Size(94, 20);
            this.DataPickerFinal.TabIndex = 26;
            // 
            // LabelDataInicio
            // 
            this.LabelDataInicio.AutoSize = true;
            this.LabelDataInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDataInicio.ForeColor = System.Drawing.Color.Azure;
            this.LabelDataInicio.Location = new System.Drawing.Point(136, 36);
            this.LabelDataInicio.Name = "LabelDataInicio";
            this.LabelDataInicio.Size = new System.Drawing.Size(88, 20);
            this.LabelDataInicio.TabIndex = 25;
            this.LabelDataInicio.Text = "Data Inicial";
            // 
            // DataPickerInicio
            // 
            this.DataPickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataPickerInicio.Location = new System.Drawing.Point(140, 59);
            this.DataPickerInicio.Name = "DataPickerInicio";
            this.DataPickerInicio.Size = new System.Drawing.Size(95, 20);
            this.DataPickerInicio.TabIndex = 24;
            // 
            // ComboMaintence
            // 
            this.ComboMaintence.FormattingEnabled = true;
            this.ComboMaintence.Location = new System.Drawing.Point(392, 59);
            this.ComboMaintence.Name = "ComboMaintence";
            this.ComboMaintence.Size = new System.Drawing.Size(211, 21);
            this.ComboMaintence.TabIndex = 23;
            // 
            // timerFiltro
            // 
            this.timerFiltro.Interval = 40;
            this.timerFiltro.Tick += new System.EventHandler(this.TimerFiltro_Tick);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSave.BackColor = System.Drawing.Color.Crimson;
            this.ButtonSave.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.ButtonSave.FlatAppearance.BorderSize = 2;
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.Azure;
            this.ButtonSave.Location = new System.Drawing.Point(943, 52);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(170, 38);
            this.ButtonSave.TabIndex = 70;
            this.ButtonSave.Text = "Cadastrar Manutenção";
            this.ButtonSave.UseVisualStyleBackColor = false;
            // 
            // ListarManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.container);
            this.Name = "ListarManutencao";
            this.Size = new System.Drawing.Size(1170, 759);
            this.Load += new System.EventHandler(this.ListarManutencao_Load);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.filter.ResumeLayout(false);
            this.filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel filter;
        private System.Windows.Forms.RadioButton radioButtonCorretiva;
        private System.Windows.Forms.RadioButton radioButtonPreventiva;
        private System.Windows.Forms.Label LabelPlate;
        private System.Windows.Forms.ComboBox BoxPlate;
        private System.Windows.Forms.Label LabelMaintence;
        private System.Windows.Forms.Label LabelDataFinal;
        private System.Windows.Forms.DateTimePicker DataPickerFinal;
        private System.Windows.Forms.Label LabelDataInicio;
        private System.Windows.Forms.DateTimePicker DataPickerInicio;
        private System.Windows.Forms.ComboBox ComboMaintence;
        private System.Windows.Forms.Button ButtonFilter;
        private System.Windows.Forms.Timer timerFiltro;
        private System.Windows.Forms.Button ButtonHome;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.Button ButtonSave;
    }
}
