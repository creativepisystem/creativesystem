namespace Truckleer.Creative
{
    partial class ListarAbastecimentos
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
            this.timerFilter = new System.Windows.Forms.Timer(this.components);
            this.listSupply = new System.Windows.Forms.Panel();
            this.container = new System.Windows.Forms.Panel();
            this.ButtonHome = new System.Windows.Forms.Button();
            this.PageDescription = new System.Windows.Forms.Label();
            this.ButtonFilter = new System.Windows.Forms.Button();
            this.layoutFlex = new System.Windows.Forms.TableLayoutPanel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ListPanel = new System.Windows.Forms.Panel();
            this.TitleFilter = new System.Windows.Forms.Panel();
            this.LabelTrip = new System.Windows.Forms.Label();
            this.BoxTrip = new System.Windows.Forms.ComboBox();
            this.LabelRoute = new System.Windows.Forms.Label();
            this.BoxRoute = new System.Windows.Forms.ComboBox();
            this.LabelPlate = new System.Windows.Forms.Label();
            this.BoxPlate = new System.Windows.Forms.ComboBox();
            this.LabelDriver = new System.Windows.Forms.Label();
            this.LabelFinal = new System.Windows.Forms.Label();
            this.DatePickerFinal = new System.Windows.Forms.DateTimePicker();
            this.LabelInitial = new System.Windows.Forms.Label();
            this.DatePickerInitial = new System.Windows.Forms.DateTimePicker();
            this.BoxDriver = new System.Windows.Forms.ComboBox();
            this.listSupply.SuspendLayout();
            this.container.SuspendLayout();
            this.layoutFlex.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.TitleFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerFilter
            // 
            this.timerFilter.Tick += new System.EventHandler(this.TimerFilter_Tick);
            // 
            // listSupply
            // 
            this.listSupply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.listSupply.Controls.Add(this.container);
            this.listSupply.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listSupply.Location = new System.Drawing.Point(0, 0);
            this.listSupply.Name = "listSupply";
            this.listSupply.Size = new System.Drawing.Size(900, 500);
            this.listSupply.TabIndex = 0;
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(35)))));
            this.container.Controls.Add(this.ButtonHome);
            this.container.Controls.Add(this.PageDescription);
            this.container.Controls.Add(this.ButtonFilter);
            this.container.Controls.Add(this.layoutFlex);
            this.container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.container.Location = new System.Drawing.Point(0, 0);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(900, 500);
            this.container.TabIndex = 0;
            // 
            // ButtonHome
            // 
            this.ButtonHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonHome.FlatAppearance.BorderSize = 0;
            this.ButtonHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonHome.ForeColor = System.Drawing.Color.Azure;
            this.ButtonHome.Location = new System.Drawing.Point(711, 5);
            this.ButtonHome.Name = "ButtonHome";
            this.ButtonHome.Size = new System.Drawing.Size(76, 31);
            this.ButtonHome.TabIndex = 3;
            this.ButtonHome.Text = "Home";
            this.ButtonHome.UseVisualStyleBackColor = true;
            // 
            // PageDescription
            // 
            this.PageDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PageDescription.AutoSize = true;
            this.PageDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageDescription.ForeColor = System.Drawing.Color.Azure;
            this.PageDescription.Location = new System.Drawing.Point(418, 5);
            this.PageDescription.Name = "PageDescription";
            this.PageDescription.Size = new System.Drawing.Size(297, 31);
            this.PageDescription.TabIndex = 2;
            this.PageDescription.Text = "Listar Abastecimentos /";
            // 
            // ButtonFilter
            // 
            this.ButtonFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.ButtonFilter.FlatAppearance.BorderSize = 0;
            this.ButtonFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonFilter.Location = new System.Drawing.Point(31, 20);
            this.ButtonFilter.Name = "ButtonFilter";
            this.ButtonFilter.Size = new System.Drawing.Size(75, 28);
            this.ButtonFilter.TabIndex = 1;
            this.ButtonFilter.Text = "Filtros";
            this.ButtonFilter.UseVisualStyleBackColor = false;
            this.ButtonFilter.Click += new System.EventHandler(this.Button1_Click_1);
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
            this.layoutFlex.Size = new System.Drawing.Size(871, 434);
            this.layoutFlex.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Controls.Add(this.ListPanel);
            this.MainPanel.Controls.Add(this.TitleFilter);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(871, 434);
            this.MainPanel.TabIndex = 0;
            // 
            // ListPanel
            // 
            this.ListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.ListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListPanel.Location = new System.Drawing.Point(0, 134);
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Size = new System.Drawing.Size(871, 300);
            this.ListPanel.TabIndex = 1;
            // 
            // TitleFilter
            // 
            this.TitleFilter.BackColor = System.Drawing.Color.RoyalBlue;
            this.TitleFilter.Controls.Add(this.LabelTrip);
            this.TitleFilter.Controls.Add(this.BoxTrip);
            this.TitleFilter.Controls.Add(this.LabelRoute);
            this.TitleFilter.Controls.Add(this.BoxRoute);
            this.TitleFilter.Controls.Add(this.LabelPlate);
            this.TitleFilter.Controls.Add(this.BoxPlate);
            this.TitleFilter.Controls.Add(this.LabelDriver);
            this.TitleFilter.Controls.Add(this.LabelFinal);
            this.TitleFilter.Controls.Add(this.DatePickerFinal);
            this.TitleFilter.Controls.Add(this.LabelInitial);
            this.TitleFilter.Controls.Add(this.DatePickerInitial);
            this.TitleFilter.Controls.Add(this.BoxDriver);
            this.TitleFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleFilter.Location = new System.Drawing.Point(0, 0);
            this.TitleFilter.Margin = new System.Windows.Forms.Padding(0);
            this.TitleFilter.MaximumSize = new System.Drawing.Size(2000, 134);
            this.TitleFilter.Name = "TitleFilter";
            this.TitleFilter.Size = new System.Drawing.Size(871, 134);
            this.TitleFilter.TabIndex = 0;
            // 
            // LabelTrip
            // 
            this.LabelTrip.AutoSize = true;
            this.LabelTrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTrip.ForeColor = System.Drawing.Color.Azure;
            this.LabelTrip.Location = new System.Drawing.Point(361, 26);
            this.LabelTrip.Name = "LabelTrip";
            this.LabelTrip.Size = new System.Drawing.Size(63, 20);
            this.LabelTrip.TabIndex = 12;
            this.LabelTrip.Text = "Viagem";
            // 
            // BoxTrip
            // 
            this.BoxTrip.FormattingEnabled = true;
            this.BoxTrip.Location = new System.Drawing.Point(365, 49);
            this.BoxTrip.Name = "BoxTrip";
            this.BoxTrip.Size = new System.Drawing.Size(121, 21);
            this.BoxTrip.TabIndex = 11;
            // 
            // LabelRoute
            // 
            this.LabelRoute.AutoSize = true;
            this.LabelRoute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelRoute.ForeColor = System.Drawing.Color.Azure;
            this.LabelRoute.Location = new System.Drawing.Point(536, 26);
            this.LabelRoute.Name = "LabelRoute";
            this.LabelRoute.Size = new System.Drawing.Size(44, 20);
            this.LabelRoute.TabIndex = 10;
            this.LabelRoute.Text = "Rota";
            // 
            // BoxRoute
            // 
            this.BoxRoute.FormattingEnabled = true;
            this.BoxRoute.Location = new System.Drawing.Point(540, 49);
            this.BoxRoute.Name = "BoxRoute";
            this.BoxRoute.Size = new System.Drawing.Size(121, 21);
            this.BoxRoute.TabIndex = 9;
            // 
            // LabelPlate
            // 
            this.LabelPlate.AutoSize = true;
            this.LabelPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlate.ForeColor = System.Drawing.Color.Azure;
            this.LabelPlate.Location = new System.Drawing.Point(361, 83);
            this.LabelPlate.Name = "LabelPlate";
            this.LabelPlate.Size = new System.Drawing.Size(48, 20);
            this.LabelPlate.TabIndex = 8;
            this.LabelPlate.Text = "Placa";
            // 
            // BoxPlate
            // 
            this.BoxPlate.FormattingEnabled = true;
            this.BoxPlate.Location = new System.Drawing.Point(365, 106);
            this.BoxPlate.Name = "BoxPlate";
            this.BoxPlate.Size = new System.Drawing.Size(121, 21);
            this.BoxPlate.TabIndex = 7;
            // 
            // LabelDriver
            // 
            this.LabelDriver.AutoSize = true;
            this.LabelDriver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDriver.ForeColor = System.Drawing.Color.Azure;
            this.LabelDriver.Location = new System.Drawing.Point(78, 79);
            this.LabelDriver.Name = "LabelDriver";
            this.LabelDriver.Size = new System.Drawing.Size(75, 20);
            this.LabelDriver.TabIndex = 6;
            this.LabelDriver.Text = "Motorista";
            // 
            // LabelFinal
            // 
            this.LabelFinal.AutoSize = true;
            this.LabelFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFinal.ForeColor = System.Drawing.Color.Azure;
            this.LabelFinal.Location = new System.Drawing.Point(196, 22);
            this.LabelFinal.Name = "LabelFinal";
            this.LabelFinal.Size = new System.Drawing.Size(82, 20);
            this.LabelFinal.TabIndex = 5;
            this.LabelFinal.Text = "Data Final";
            this.LabelFinal.Click += new System.EventHandler(this.Label1_Click);
            // 
            // DatePickerFinal
            // 
            this.DatePickerFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerFinal.Location = new System.Drawing.Point(200, 45);
            this.DatePickerFinal.Name = "DatePickerFinal";
            this.DatePickerFinal.Size = new System.Drawing.Size(94, 20);
            this.DatePickerFinal.TabIndex = 4;
            this.DatePickerFinal.ValueChanged += new System.EventHandler(this.DateTimePicker2_ValueChanged);
            // 
            // LabelInitial
            // 
            this.LabelInitial.AutoSize = true;
            this.LabelInitial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInitial.ForeColor = System.Drawing.Color.Azure;
            this.LabelInitial.Location = new System.Drawing.Point(78, 22);
            this.LabelInitial.Name = "LabelInitial";
            this.LabelInitial.Size = new System.Drawing.Size(88, 20);
            this.LabelInitial.TabIndex = 3;
            this.LabelInitial.Text = "Data Inicial";
            this.LabelInitial.Click += new System.EventHandler(this.Label2_Click);
            // 
            // DatePickerInitial
            // 
            this.DatePickerInitial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DatePickerInitial.Location = new System.Drawing.Point(82, 45);
            this.DatePickerInitial.Name = "DatePickerInitial";
            this.DatePickerInitial.Size = new System.Drawing.Size(95, 20);
            this.DatePickerInitial.TabIndex = 2;
            this.DatePickerInitial.ValueChanged += new System.EventHandler(this.DateTimePicker1_ValueChanged);
            // 
            // BoxDriver
            // 
            this.BoxDriver.FormattingEnabled = true;
            this.BoxDriver.Location = new System.Drawing.Point(83, 102);
            this.BoxDriver.Name = "BoxDriver";
            this.BoxDriver.Size = new System.Drawing.Size(211, 21);
            this.BoxDriver.TabIndex = 0;
            // 
            // ListarAbastecimentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(24)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.listSupply);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ListarAbastecimentos";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.ListarAbastecimentos_Load);
            this.listSupply.ResumeLayout(false);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.layoutFlex.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.TitleFilter.ResumeLayout(false);
            this.TitleFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerFilter;
        private System.Windows.Forms.Panel listSupply;
        private System.Windows.Forms.Panel container;
        private System.Windows.Forms.TableLayoutPanel layoutFlex;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ListPanel;
        private System.Windows.Forms.Panel TitleFilter;
        private System.Windows.Forms.Button ButtonFilter;
        private System.Windows.Forms.Label LabelTrip;
        private System.Windows.Forms.ComboBox BoxTrip;
        private System.Windows.Forms.Label LabelRoute;
        private System.Windows.Forms.ComboBox BoxRoute;
        private System.Windows.Forms.Label LabelPlate;
        private System.Windows.Forms.ComboBox BoxPlate;
        private System.Windows.Forms.Label LabelDriver;
        private System.Windows.Forms.Label LabelFinal;
        private System.Windows.Forms.DateTimePicker DatePickerFinal;
        private System.Windows.Forms.Label LabelInitial;
        private System.Windows.Forms.DateTimePicker DatePickerInitial;
        private System.Windows.Forms.ComboBox BoxDriver;
        private System.Windows.Forms.Label PageDescription;
        private System.Windows.Forms.Button ButtonHome;
    }
}
